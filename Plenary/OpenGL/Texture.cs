using Plenary.Interop;

namespace Plenary.OpenGL
{
  public class Texture : Named
  {

        public uint Target;

        public Texture (uint target)
        {
            Target = target;
            GL.CreateTextures (target, 1, out Name);
            GL.CheckErrors ();
        }

        public Texture (int width, int height, uint format) : this(GL.TEXTURE_2D)
        {
            GL.TextureStorage2D (Name, 1, format, width, height);
            GL.CheckErrors ();
        }

        public Texture(string source) : this(GL.TEXTURE_2D)
        {
            var ptr = SDL.LoadImage (source);
            try {
                if (ptr == System.IntPtr.Zero)
                    throw new System.Exception (System.String.Format("Unable to load image from {0}", source));
                var surface = SDL.Surface.FromPtr (ptr);
                var format = SDL.PixelFormat.FromPtr (surface.Format);
                switch (format.code) {
                case PixelFormats.RGB24:
                    GL.TextureStorage2D (Name, 4, GL.RGBA8, surface.Width, surface.Height);
                    GL.TextureSubImage2D (Name, 0, 0, 0, surface.Width, surface.Height, GL.RGB, GL.UNSIGNED_BYTE, surface.Pixels);
                    break;
                case PixelFormats.ABGR8888:
                    GL.TextureStorage2D (Name, 4, GL.RGBA8, surface.Width, surface.Height);
                    GL.TextureSubImage2D (Name, 0, 0, 0, surface.Width, surface.Height, GL.RGBA, GL.UNSIGNED_BYTE, surface.Pixels);
                    break;
                default:
                    throw new System.Exception (System.String.Format("Unsupported pixel format {0}", format.code));
                }
                GL.GenerateTextureMipmap (Name);
                GL.CheckErrors ();
            } finally {
                SDL.FreeSurface (ptr);
            }
        }

        public override void Dispose ()
        {
            GL.DeleteTextures (1, new[] { Name });
        }

    public Texture NearestFilter () {
      GL.TextureParameteri(Name, GL.TEXTURE_MIN_FILTER, (int) GL.NEAREST);
      GL.TextureParameteri(Name, GL.TEXTURE_MAG_FILTER, (int) GL.NEAREST);
      return this;
    }

    public Texture BorderClamp () {
      GL.TextureParameteri(Name, GL.TEXTURE_WRAP_S, (int) GL.CLAMP_TO_BORDER);
      GL.TextureParameteri(Name, GL.TEXTURE_WRAP_T, (int) GL.CLAMP_TO_BORDER);
      GL.TextureParameteri(Name, GL.TEXTURE_WRAP_R, (int) GL.CLAMP_TO_BORDER);
      return this;
    }

  }
}
