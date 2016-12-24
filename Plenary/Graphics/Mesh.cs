using System.Collections.Generic;
using System.Security.AccessControl;
using Plenary.Graphics.OpenGL;
using System;

namespace Plenary.Graphics
{
  
  public class Mesh
  {

    readonly Dictionary<String, IBuffer> buffers = new Dictionary<string, IBuffer>();
    readonly Dictionary<Program, VertexArray> vertexArrays = new Dictionary<Program, VertexArray>();

    public Mesh ()
    {
    }

    public void Render (RenderState state)
    {
      VertexArray va;
      if (!vertexArrays.TryGetValue (state.CurrentProgram, out va)) {
        vertexArrays [state.CurrentProgram] = new VertexArray (buffers, state.CurrentProgram);
      }
      va.Draw ();
    }

  }

}
