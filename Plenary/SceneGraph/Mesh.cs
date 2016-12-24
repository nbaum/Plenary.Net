using System.Collections.Generic;
using Plenary.OpenGL;

namespace Plenary.SceneGraph {

  public class Mesh : IRenderable {
    
    public Buffer Elements = null;

    public Dictionary<string, Buffer> Buffers = new Dictionary<string, Buffer>();

    public Dictionary<Program, VertexArray> Programs = new Dictionary<Program, VertexArray>();

    public Math.Mat4f Transform = Math.Mat4f.Eye;

    public Mesh () {
    }

    public Mesh (string filename) {
      var r = new ASIF.Reader(filename);
      var d = (Dictionary<object, object>) r.Read();
      foreach (var p in d) {
        var dd = (Dictionary<object, object>) p.Value;
        if (dd["rotate"] != null) {
          var rot = (double[]) dd["rotate"];
          Transform *= Math.Mat4f.Rotate(System.Math.PI / 180 * rot[0], System.Math.PI / 180 * rot[1], System.Math.PI / 180 * rot[2]);
        }
        if (dd["translate"] != null) {
          var trn = (double[]) dd["translate"];
          Transform *= Math.Mat4f.Translate(trn[0], trn[1], trn[2]);
        }
        if (dd["scale"] != null) {
          var scl = (double[]) dd["scale"];
          Transform *= Math.Mat4f.Scale(scl[0], scl[1], scl[2]);
        }
        var m = (Dictionary<object, object>) dd["mesh"];
        foreach (var q in m) {
          var name = (string) q.Key;
          var data = (dynamic) q.Value;
          var buffer = new Buffer().Storage(data);
          if (name == "indices")
            Elements = buffer;
          else
            Buffers[name] = new Buffer().Storage(data);
        }
      }
    }

    public void Render (Manager manager) {
      VertexArray va;
      if (!Programs.TryGetValue(Program.Bound, out va)) {
        va = new VertexArray();
        uint binding = 0;
        if (Elements != null)
          va.Elements = Elements;
        foreach (var p in Buffers) {
          var name = p.Key;
          var buffer = p.Value;
          var loc = Program.Bound.InputLocation(name);
          if (loc > -1)
            va.Attach(buffer, binding++, (uint) loc);
        }
      }
      using (var x = manager.Uniforms.Restoring("scene.model", (dynamic m) => m * Transform)) {
        manager.UpdateGL();
        va.Bind().Draw();
      }
    }

  }

}
