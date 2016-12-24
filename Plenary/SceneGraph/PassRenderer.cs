using System;

namespace Plenary.SceneGraph {

  public abstract class PassRenderer : IRenderable {

    public virtual void RenderShadows(Manager m) {}
    public virtual void RenderForward(Manager m) {}

    public void Render (Manager m) {
      switch (m.stage) {
      case RenderStage.Shadows:
        RenderShadows(m);
        break;
      case RenderStage.Forward:
        RenderForward(m);
        break;
      }
    }

  }

}

