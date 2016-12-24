using Plenary.Math;
using Plenary.OpenGL;
using Plenary.SceneGraph;

namespace Plenary.Primitives
{
  public class Cube : Mesh
  {

    public Cube ()
    {
      var verts = new [] {
        new Vec3f (-0.5, -0.5,  0.5),
        new Vec3f ( 0.5, -0.5,  0.5),
        new Vec3f ( 0.5,  0.5,  0.5),
        new Vec3f (-0.5,  0.5,  0.5),
        new Vec3f (-0.5, -0.5, -0.5),
        new Vec3f ( 0.5, -0.5, -0.5),
        new Vec3f ( 0.5,  0.5, -0.5),
        new Vec3f (-0.5,  0.5, -0.5),
      };
      var indices = new ushort[] {
        0, 1, 2,
        2, 3, 0,
        1, 5, 6,
        6, 2, 1,
        7, 6, 5,
        5, 4, 7,
        4, 0, 3,
        3, 7, 4,
        4, 5, 1,
        1, 0, 4,
        3, 2, 6,
        6, 7, 3,
      };
      Buffers["position"] = new Buffer ().Storage(verts);
      Elements = new Buffer ().Storage (indices);
    }
  }
}
