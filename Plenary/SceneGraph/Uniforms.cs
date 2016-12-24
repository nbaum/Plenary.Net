using System.Collections.Generic;
using Plenary.OpenGL;
using Plenary.Interop;
using System;

namespace Plenary.SceneGraph {

  public class Uniforms : IRenderable {

    public class Restorer : System.IDisposable {
      
      Uniforms uniforms;

      string name;

      object value;

      public Restorer (Uniforms uniforms, string name, object value) {
        this.uniforms = uniforms;
        this.name = name;
        this.value = value;
      }

      public void Dispose () {
        uniforms[name] = value;
      }

    }

    internal Dictionary<string, object> Values = new Dictionary<string, object>();

    internal Dictionary<string, long> Timestamps = new Dictionary<string, long>();

    public void Render (Manager manager) {
      foreach (var p in Values) {
        var name = p.Key;
        var value = p.Value;
        manager.Uniforms[name] = value;
      }
    }

    public void UpdateGL () {
      if (Program.Bound == null)
        return;
      int unit = 0;
      foreach (var p in Values) {
        var name = p.Key;
        var value = p.Value;
        //if (Timestamps[name] < Program.Bound.UniformTimestamp)
        //  continue;
        var loc = Program.Bound.UniformLocation(name);
        if (loc == -1)
          continue;
        var tex = value as Texture;
        if (tex != null) {
          GL.BindTextureUnit((uint) unit, tex.Name);
          Program.Bound.Uniform(loc, unit);
          unit += 1;
          GL.CheckErrors();
        } else {
          Program.Bound.Uniform(loc, (dynamic) value);
        }
      }
      Program.Bound.UniformTimestamp = System.DateTime.Now.Ticks;
    }

    public Restorer Restoring<T> (string name, System.Func<T, T> f) {
      var ur = new Restorer(this, name, this[name]);
      this[name] = f((T) this[name]);
      return ur;
    }

    public object this [string name] {
      get {
        return Values[name];
      }
      set {
        if (!Values.ContainsKey(name) || !Values[name].Equals(value)) {
          Values[name] = value;
          Timestamps[name] = System.DateTime.Now.Ticks;
        }
      }
    }

  }

}
