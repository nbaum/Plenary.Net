using System;

namespace Plenary.OpenGL
{
  public abstract class Named : IDisposable
  {
    public uint Name;
    public abstract void Dispose();
  }
}
