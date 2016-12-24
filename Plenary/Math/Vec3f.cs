namespace Plenary.Math {
  
  public class Vec4f {
    
    public float X, Y, Z, W;

    public Vec4f (float x, float y, float z, float w) {
      X = x;
      Y = y;
      Z = z;
      W = w;
    }

    public static Vec4f operator+ (Vec4f a, Vec4f b) {
      a.X += b.X;
      a.Y += b.Y;
      a.Z += b.Z;
      a.W += b.W;
      return a;
    }

    public static Vec4f operator- (Vec4f a, Vec4f b) {
      a.X -= b.X;
      a.Y -= b.Y;
      a.Z -= b.Z;
      a.W -= b.W;
      return a;
    }

  }

}
