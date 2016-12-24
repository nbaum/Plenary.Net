using OpenTK.Graphics.OpenGL4;
using System;

namespace Plenary
{
  public class Shader : Named, IDisposable
  {

    public Shader (int name) : base(name)
    {
      if (!GL.IsShader (name))
        throw new BadNameException<Shader> (name);
    }

    public Shader (ShaderType type) : base(GL.CreateShader(type))
    {
    }

    public void Source (params string[] source)
    {
      GL.ShaderSource (Name, source.Length, source, (int[]) null);
    }

    public void Compile ()
    {
      GL.CompileShader (Name);
    }

    public void Dispose ()
    {
      GL.DeleteShader (Name);
    }

  }
}
