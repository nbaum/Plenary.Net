using System.Runtime.InteropServices;
using Plenary.Interop;
using Plenary.Math;
using System.IO;

namespace Plenary.OpenGL {

  public class Program : Named {

    public static Program Bound;

    public long UniformTimestamp = 0;

    public Program () {
      Name = GL.CreateProgram();
      GL.CheckErrors();
    }

    public Program (params string[] sources) : this() {
      foreach (var source in sources) {
        var fi = new FileInfo(source);
        switch (fi.Extension) {
        case ".frag":
          Attach(new Shader(GL.FRAGMENT_SHADER).Source(fi.OpenText().ReadToEnd(), fi.Name));
          break;
        case ".vert":
          Attach(new Shader(GL.VERTEX_SHADER).Source(fi.OpenText().ReadToEnd(), fi.Name));
          break;
        default:
          throw new System.Exception(string.Format("Unknown extension for {0}", source));
        }
      }
      Link();
    }

    public Program (params Shader[] shaders)
      : this() {
      Attach(shaders).Link();
    }

    public override void Dispose () {
      GL.DeleteProgram(Name);
      GL.CheckErrors();
    }

    public Program Attach (params Shader[] shaders) {
      foreach (var shader in shaders) {
        GL.AttachShader(Name, shader.Name);
        GL.CheckErrors();
      }
      return this;
    }

    public Program Link () {
      GL.LinkProgram(Name);
      System.Console.WriteLine(InfoLog);
      GL.CheckErrors();
      return this;
    }

    public Program Bind () {
      if (Bound != this) {
        Bound = this;
        GL.UseProgram(Name);
        GL.CheckErrors();
      }
      return this;
    }

    public int InputLocation (string name) {
      try {
        return GL.GetProgramResourceLocation(Name, GL.PROGRAM_INPUT, name);
      } finally {
        GL.CheckErrors();
      }
    }

    public int UniformLocation (string name) {
      try {
        return GL.GetProgramResourceLocation(Name, GL.UNIFORM, name);
      } finally {
        GL.CheckErrors();
      }
    }

    public void Uniform (int location, int v) {
      GL.ProgramUniform1i(Name, location, v);
      GL.CheckErrors();
    }

    public void Uniform (int location, Vec2f v) {
      GL.ProgramUniform2f(Name, location, v.X, v.Y);
      GL.CheckErrors();
    }

    public void Uniform (int location, Vec3f v) {
      GL.ProgramUniform3f(Name, location, v.X, v.Y, v.Z);
      GL.CheckErrors();
    }

    public void Uniform (int location, Vec4f v) {
      GL.ProgramUniform4f(Name, location, v.X, v.Y, v.Z, v.W);
      GL.CheckErrors();
    }


    public void Uniform (int location, Mat4f m) {
      Utils.WithIntPtr(m, (_, ptr) => GL.ProgramUniformMatrix4fv(Name, location, 1, true, ptr));
      GL.CheckErrors();
    }

    public void Uniform (int location, Mat4d m) {
      Utils.WithIntPtr(m, (_, ptr) => GL.ProgramUniformMatrix4dv(Name, location, 1, true, ptr));
      GL.CheckErrors();
    }

    public string InfoLog {
      get {
        int len;
        GL.GetProgramiv(Name, GL.INFO_LOG_LENGTH, out len);
        GL.CheckErrors();
        var ptr = Marshal.AllocHGlobal(len);
        GL.GetProgramInfoLog(Name, len, null, ptr);
        GL.CheckErrors();
        var log = Marshal.PtrToStringAuto(ptr, len);
        Marshal.FreeHGlobal(ptr);
        return log;
      }
    }

  }

}
