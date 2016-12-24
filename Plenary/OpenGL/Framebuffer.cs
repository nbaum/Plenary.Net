using Plenary.Interop;

namespace Plenary.OpenGL {

  public class Framebuffer : Named {

    public int Width, Height;

    public static Framebuffer Default = new Framebuffer(0, 1920, 1080);
    public static Framebuffer Bound = Default;

    Framebuffer (uint name, int width, int height) {
      Name = name;
      Width = width;
      Height = height;
    }

    public Framebuffer (int width, int height) {
      GL.CreateFramebuffers(1, out Name);
      GL.CheckErrors();
      Width = width;
      Height = height;
    }

    public override void Dispose () {
      GL.CheckErrors();
      GL.DeleteFramebuffers(1, new[] { Name });
    }

    public Framebuffer Attach (uint attachment, Renderbuffer rb) {
      GL.NamedFramebufferRenderbuffer(Name, attachment, GL.RENDERBUFFER, rb.Name);
      GL.CheckErrors();
      return this;
    }

    public Framebuffer Attach (uint attachment, Texture tex, int level = 0) {
      GL.NamedFramebufferTexture(Name, attachment, tex.Name, level);
      GL.CheckErrors();
      return this;
    }

    public Framebuffer Bind () {
      GL.BindFramebuffer(GL.FRAMEBUFFER, Name);
      GL.CheckErrors();
      Bound = this;
      return this;
    }

    public Framebuffer BlitTo (Framebuffer Dest) {
      GL.BlitNamedFramebuffer(Name, Dest.Name, 0, 0, Width, Height, 0, 0, Dest.Width, Dest.Height, GL.COLOR_BUFFER_BIT, GL.SCALED_RESOLVE_FASTEST);
//      GL.BlitNamedFramebuffer(Name, Dest.Name, 0, 0, Width, Height, 0, 0, Dest.Width, Dest.Height, GL.DEPTH_BUFFER_BIT, GL.NEAREST);
      GL.CheckErrors();
      return this;
    }

  }

}
