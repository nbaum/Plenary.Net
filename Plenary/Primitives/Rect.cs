using Plenary.Math;
using Plenary.OpenGL;
using Plenary.SceneGraph;

namespace Plenary.Primitives
{
  public class Rect : Mesh
  {
    public Rect ()
    {
      var verts = new [] {
        new Vec2f (0, 0),
        new Vec2f (1, 0),
        new Vec2f (1, 1),
        new Vec2f (0, 0),
        new Vec2f (1, 1),
        new Vec2f (0, 1),
      };
      Buffers ["position"] = new Buffer ().Storage (verts);
    }
  }
}
