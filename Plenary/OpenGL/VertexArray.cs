using System;
using Plenary.Interop;

namespace Plenary.OpenGL
{
  
    public class VertexArray : Named
    {

        public static VertexArray Bound;
        public int Length = 0;
        private Buffer _Elements;

        public VertexArray ()
        {
            GL.CreateVertexArrays (1, out Name);
            GL.CheckErrors ();
        }

        public override void Dispose ()
        {
            GL.DeleteVertexArrays (1, new[] { Name });
        }

        public Buffer Elements {
            get {
                return _Elements;
            }
            set {
                _Elements = value;
                GL.VertexArrayElementBuffer (Name, value.Name);
                GL.CheckErrors ();
            }
        }

        public VertexArray Attach (Buffer buffer, uint binding, uint attribute)
        {
            Length = System.Math.Max (Length, buffer.Length);
            GL.VertexArrayAttribFormat (Name, attribute, buffer.ElementSize, buffer.ElementType, false, 0);
            GL.VertexArrayVertexBuffer (Name, binding, buffer.Name, 0, buffer.ElementStride);
            GL.VertexArrayAttribBinding (Name, attribute, binding);
            GL.EnableVertexArrayAttrib (Name, attribute);
            GL.CheckErrors ();
            return this;
        }

        public VertexArray Bind ()
        {
            if (Bound != this) {
                Bound = this;
                GL.BindVertexArray (Name);
                GL.CheckErrors ();
            }
            return this;
        }

        public VertexArray Draw ()
        {
            if (Elements != null) {
                GL.DrawElementsInstancedBaseVertexBaseInstance (GL.TRIANGLES, Elements.Length, Elements.ElementType, IntPtr.Zero, 1, 0, 0);
            } else {
                GL.DrawArraysInstancedBaseInstance (GL.TRIANGLES, 0, Length, 1, 0);
            }
            GL.CheckErrors ();
            return this;
        }

    }

}
