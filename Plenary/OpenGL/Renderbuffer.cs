using Plenary.Interop;

namespace Plenary.OpenGL
{
    public class Renderbuffer : Named
    {
        public Renderbuffer (int width, int height, int samples = 0, uint format = GL.RGBA8)
        {
            GL.CreateRenderbuffers (1, out Name);
            GL.NamedRenderbufferStorageMultisample (Name, samples, format, width, height);
            GL.CheckErrors ();
        }

        public override void Dispose ()
        {
            GL.DeleteRenderbuffers (1, new[] { Name });
        }
    }
}
