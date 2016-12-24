using Plenary.OpenGL;
using Plenary.Interop;
using System;

namespace Plenary.SceneGraph {

  public enum RenderStage {
    Shadows,
    Forward,
    Filters
  }

  public class Manager {
    
    public RenderStage stage = RenderStage.Forward;
    public Uniforms Uniforms = new Uniforms();
    public double Time = System.DateTime.Now.Ticks / 10000000.0; 
    public double TimeDelta = 0;

    public void Tick () {
      var now = System.DateTime.Now.Ticks / 10000000.0;
      TimeDelta = now - Time;
    }

    public void Tock (double delay) {
      var duration = (System.DateTime.Now.Ticks / 10000000.0 - Time);
      if (duration > delay)
        Utils.Debug("Missed tock deadline by {0:P}", 1 - (delay / duration));
      else
        SDL.Delay((uint) (delay - duration) * 1000000);
      Time = System.DateTime.Now.Ticks / 10000000.0;
    }

    public void Render (IRenderable renderable) {
      renderable.Render(this);
    }

    public void Render (Framebuffer fb) {
      fb.Bind();
    }

    public void Render (Program p) {
      p.Bind();
    }

    public void Render (IRenderable[] renderables) {
      foreach (var r in renderables) {
        Render(r);
      }
    }

    public void UpdateGL () {
      Uniforms.UpdateGL();
    }

  }

}
