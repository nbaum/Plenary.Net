using Plenary.OpenGL;
using System;

namespace Plenary.SceneGraph
{
    
    public class Material : IRenderable
    {

        Program forward;
        Program shadow;

        public Material (Program forward = null, Program shadow = null)
        {
            this.forward = forward;
            this.shadow = shadow;
        }

        public void Render (Manager man)
        {
            switch (man.stage) {
            case RenderStage.Shadows:
                man.Render (shadow);
                break;
            case RenderStage.Forward:
                man.Render (forward);
                break;
            }
        }

    }

}
