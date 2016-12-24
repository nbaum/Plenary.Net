using System;

namespace Plenary.Graphics.OpenGL
{
  public interface IBindable
  {
    void Bind();
    IBindable Bound();
  }
}

