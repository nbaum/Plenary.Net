using OpenTK.Graphics.OpenGL4;

namespace Plenary.Graphics.OpenGL
{
  public class Texture2D : Texture
  {
    
    public Texture2D () : base(TextureTarget.Texture2D)
    {
    }

    public Texture2D (int width, int height, SizedInternalFormat iformat, int levels = 1) : this()
    {
      Storage (width, height, iformat, levels);
    }

    public void Storage (int width, int height, SizedInternalFormat iformat, int levels = 1) {
      GL.TextureStorage2D (Name, levels, iformat, width, height);
    }

    public int Width => GetInt (GetTextureParameter.TextureWidth);

    public int Height => GetInt (GetTextureParameter.TextureHeight);

  }
}
