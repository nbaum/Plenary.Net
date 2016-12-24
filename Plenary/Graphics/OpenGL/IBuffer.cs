using OpenTK.Graphics.OpenGL4;

namespace Plenary.Graphics.OpenGL
{
  public interface IBuffer
  {

    int Length { get; }
    VertexAttribType AttribType { get; }

  }
}
