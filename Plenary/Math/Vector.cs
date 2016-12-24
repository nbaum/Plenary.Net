
using System.Runtime.InteropServices;
using System;

namespace Plenary.Math {

  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec2f {

    public static readonly Vec2f One = new Vec2f(1, 1);
    public static readonly Vec2f Zero = new Vec2f(0, 0);

    public float X, Y;

    public Vec2f (float x, float y) {
            X = x;
            Y = y;
          }

        public Vec2f (double x, double y) {
            X = (float) x;
            Y = (float) y;
          }
    
    public static implicit operator Vec2f (float v) {
      return new Vec2f(v, v);
    }

    public static Vec2f operator+ (Vec2f a, Vec2f b) {
            a.X += b.X;
            a.Y += b.Y;
            return a;
    }

    public static Vec2f operator- (Vec2f a, Vec2f b) {
            a.X -= b.X;
            a.Y -= b.Y;
            return a;
    }

    public static Vec2f operator* (Vec2f a, Vec2f b) {
            a.X *= b.X;
            a.Y *= b.Y;
            return a;
    }

    public static Vec2f operator/ (Vec2f a, Vec2f b) {
            a.X /= b.X;
            a.Y /= b.Y;
            return a;
    }

    public static Vec2f operator% (Vec2f a, Vec2f b) {
            a.X %= b.X;
            a.Y %= b.Y;
            return a;
    }

    public static Vec2f operator+ (Vec2f a, float b) {
            a.X += b;
            a.Y += b;
            return a;
    }

    public static Vec2f operator- (Vec2f a, float b) {
            a.X -= b;
            a.Y -= b;
            return a;
    }

    public static Vec2f operator* (Vec2f a, float b) {
            a.X *= b;
            a.Y *= b;
            return a;
    }

    public static Vec2f operator/ (Vec2f a, float b) {
            a.X /= b;
            a.Y /= b;
            return a;
    }

    public static Vec2f operator% (Vec2f a, float b) {
            a.X %= b;
            a.Y %= b;
            return a;
    }

    public static Vec2f operator+ (float a, Vec2f b) {
      Vec2f c = a;
            c.X += b.X;
            c.Y += b.Y;
            return c;
    }

    public static Vec2f operator- (float a, Vec2f b) {
      Vec2f c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            return c;
    }

    public static Vec2f operator* (float a, Vec2f b) {
      Vec2f c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            return c;
    }

    public static Vec2f operator/ (float a, Vec2f b) {
      Vec2f c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            return c;
    }

    public static Vec2f operator% (float a, Vec2f b) {
      Vec2f c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            return c;
    }

    public float LengthSquared {
      get {
        float t = 0;
                t += (float) (X * X);
                t += (float) (Y * Y);
                return t;
      }
    }

    public float Length {
      get {
        return (float) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec2f Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec2d {

    public static readonly Vec2d One = new Vec2d(1, 1);
    public static readonly Vec2d Zero = new Vec2d(0, 0);

    public double X, Y;

    public Vec2d (double x, double y) {
            X = x;
            Y = y;
          }

    
    public static implicit operator Vec2d (double v) {
      return new Vec2d(v, v);
    }

    public static Vec2d operator+ (Vec2d a, Vec2d b) {
            a.X += b.X;
            a.Y += b.Y;
            return a;
    }

    public static Vec2d operator- (Vec2d a, Vec2d b) {
            a.X -= b.X;
            a.Y -= b.Y;
            return a;
    }

    public static Vec2d operator* (Vec2d a, Vec2d b) {
            a.X *= b.X;
            a.Y *= b.Y;
            return a;
    }

    public static Vec2d operator/ (Vec2d a, Vec2d b) {
            a.X /= b.X;
            a.Y /= b.Y;
            return a;
    }

    public static Vec2d operator% (Vec2d a, Vec2d b) {
            a.X %= b.X;
            a.Y %= b.Y;
            return a;
    }

    public static Vec2d operator+ (Vec2d a, double b) {
            a.X += b;
            a.Y += b;
            return a;
    }

    public static Vec2d operator- (Vec2d a, double b) {
            a.X -= b;
            a.Y -= b;
            return a;
    }

    public static Vec2d operator* (Vec2d a, double b) {
            a.X *= b;
            a.Y *= b;
            return a;
    }

    public static Vec2d operator/ (Vec2d a, double b) {
            a.X /= b;
            a.Y /= b;
            return a;
    }

    public static Vec2d operator% (Vec2d a, double b) {
            a.X %= b;
            a.Y %= b;
            return a;
    }

    public static Vec2d operator+ (double a, Vec2d b) {
      Vec2d c = a;
            c.X += b.X;
            c.Y += b.Y;
            return c;
    }

    public static Vec2d operator- (double a, Vec2d b) {
      Vec2d c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            return c;
    }

    public static Vec2d operator* (double a, Vec2d b) {
      Vec2d c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            return c;
    }

    public static Vec2d operator/ (double a, Vec2d b) {
      Vec2d c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            return c;
    }

    public static Vec2d operator% (double a, Vec2d b) {
      Vec2d c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            return c;
    }

    public double LengthSquared {
      get {
        double t = 0;
                t += (double) (X * X);
                t += (double) (Y * Y);
                return t;
      }
    }

    public double Length {
      get {
        return (double) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec2d Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec2i {

    public static readonly Vec2i One = new Vec2i(1, 1);
    public static readonly Vec2i Zero = new Vec2i(0, 0);

    public int X, Y;

    public Vec2i (int x, int y) {
            X = x;
            Y = y;
          }

    
    public static implicit operator Vec2i (int v) {
      return new Vec2i(v, v);
    }

    public static Vec2i operator+ (Vec2i a, Vec2i b) {
            a.X += b.X;
            a.Y += b.Y;
            return a;
    }

    public static Vec2i operator- (Vec2i a, Vec2i b) {
            a.X -= b.X;
            a.Y -= b.Y;
            return a;
    }

    public static Vec2i operator* (Vec2i a, Vec2i b) {
            a.X *= b.X;
            a.Y *= b.Y;
            return a;
    }

    public static Vec2i operator/ (Vec2i a, Vec2i b) {
            a.X /= b.X;
            a.Y /= b.Y;
            return a;
    }

    public static Vec2i operator% (Vec2i a, Vec2i b) {
            a.X %= b.X;
            a.Y %= b.Y;
            return a;
    }

    public static Vec2i operator+ (Vec2i a, int b) {
            a.X += b;
            a.Y += b;
            return a;
    }

    public static Vec2i operator- (Vec2i a, int b) {
            a.X -= b;
            a.Y -= b;
            return a;
    }

    public static Vec2i operator* (Vec2i a, int b) {
            a.X *= b;
            a.Y *= b;
            return a;
    }

    public static Vec2i operator/ (Vec2i a, int b) {
            a.X /= b;
            a.Y /= b;
            return a;
    }

    public static Vec2i operator% (Vec2i a, int b) {
            a.X %= b;
            a.Y %= b;
            return a;
    }

    public static Vec2i operator+ (int a, Vec2i b) {
      Vec2i c = a;
            c.X += b.X;
            c.Y += b.Y;
            return c;
    }

    public static Vec2i operator- (int a, Vec2i b) {
      Vec2i c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            return c;
    }

    public static Vec2i operator* (int a, Vec2i b) {
      Vec2i c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            return c;
    }

    public static Vec2i operator/ (int a, Vec2i b) {
      Vec2i c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            return c;
    }

    public static Vec2i operator% (int a, Vec2i b) {
      Vec2i c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            return c;
    }

    public int LengthSquared {
      get {
        int t = 0;
                t += (int) (X * X);
                t += (int) (Y * Y);
                return t;
      }
    }

    public int Length {
      get {
        return (int) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec2i Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec2b {

    public static readonly Vec2b One = new Vec2b(1, 1);
    public static readonly Vec2b Zero = new Vec2b(0, 0);

    public sbyte X, Y;

    public Vec2b (sbyte x, sbyte y) {
            X = x;
            Y = y;
          }

    
    public static implicit operator Vec2b (sbyte v) {
      return new Vec2b(v, v);
    }

    public static Vec2b operator+ (Vec2b a, Vec2b b) {
            a.X += b.X;
            a.Y += b.Y;
            return a;
    }

    public static Vec2b operator- (Vec2b a, Vec2b b) {
            a.X -= b.X;
            a.Y -= b.Y;
            return a;
    }

    public static Vec2b operator* (Vec2b a, Vec2b b) {
            a.X *= b.X;
            a.Y *= b.Y;
            return a;
    }

    public static Vec2b operator/ (Vec2b a, Vec2b b) {
            a.X /= b.X;
            a.Y /= b.Y;
            return a;
    }

    public static Vec2b operator% (Vec2b a, Vec2b b) {
            a.X %= b.X;
            a.Y %= b.Y;
            return a;
    }

    public static Vec2b operator+ (Vec2b a, sbyte b) {
            a.X += b;
            a.Y += b;
            return a;
    }

    public static Vec2b operator- (Vec2b a, sbyte b) {
            a.X -= b;
            a.Y -= b;
            return a;
    }

    public static Vec2b operator* (Vec2b a, sbyte b) {
            a.X *= b;
            a.Y *= b;
            return a;
    }

    public static Vec2b operator/ (Vec2b a, sbyte b) {
            a.X /= b;
            a.Y /= b;
            return a;
    }

    public static Vec2b operator% (Vec2b a, sbyte b) {
            a.X %= b;
            a.Y %= b;
            return a;
    }

    public static Vec2b operator+ (sbyte a, Vec2b b) {
      Vec2b c = a;
            c.X += b.X;
            c.Y += b.Y;
            return c;
    }

    public static Vec2b operator- (sbyte a, Vec2b b) {
      Vec2b c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            return c;
    }

    public static Vec2b operator* (sbyte a, Vec2b b) {
      Vec2b c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            return c;
    }

    public static Vec2b operator/ (sbyte a, Vec2b b) {
      Vec2b c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            return c;
    }

    public static Vec2b operator% (sbyte a, Vec2b b) {
      Vec2b c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            return c;
    }

    public sbyte LengthSquared {
      get {
        sbyte t = 0;
                t += (sbyte) (X * X);
                t += (sbyte) (Y * Y);
                return t;
      }
    }

    public sbyte Length {
      get {
        return (sbyte) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec2b Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec3f {

    public static readonly Vec3f One = new Vec3f(1, 1, 1);
    public static readonly Vec3f Zero = new Vec3f(0, 0, 0);

    public float X, Y, Z;

    public Vec3f (float x, float y, float z) {
            X = x;
            Y = y;
            Z = z;
          }

        public Vec3f (double x, double y, double z) {
            X = (float) x;
            Y = (float) y;
            Z = (float) z;
          }
    
    public static implicit operator Vec3f (float v) {
      return new Vec3f(v, v, v);
    }

    public static Vec3f operator+ (Vec3f a, Vec3f b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            return a;
    }

    public static Vec3f operator- (Vec3f a, Vec3f b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            return a;
    }

    public static Vec3f operator* (Vec3f a, Vec3f b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            return a;
    }

    public static Vec3f operator/ (Vec3f a, Vec3f b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            return a;
    }

    public static Vec3f operator% (Vec3f a, Vec3f b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            return a;
    }

    public static Vec3f operator+ (Vec3f a, float b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            return a;
    }

    public static Vec3f operator- (Vec3f a, float b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            return a;
    }

    public static Vec3f operator* (Vec3f a, float b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            return a;
    }

    public static Vec3f operator/ (Vec3f a, float b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            return a;
    }

    public static Vec3f operator% (Vec3f a, float b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            return a;
    }

    public static Vec3f operator+ (float a, Vec3f b) {
      Vec3f c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            return c;
    }

    public static Vec3f operator- (float a, Vec3f b) {
      Vec3f c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            return c;
    }

    public static Vec3f operator* (float a, Vec3f b) {
      Vec3f c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            return c;
    }

    public static Vec3f operator/ (float a, Vec3f b) {
      Vec3f c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            return c;
    }

    public static Vec3f operator% (float a, Vec3f b) {
      Vec3f c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            return c;
    }

    public float LengthSquared {
      get {
        float t = 0;
                t += (float) (X * X);
                t += (float) (Y * Y);
                t += (float) (Z * Z);
                return t;
      }
    }

    public float Length {
      get {
        return (float) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec3f Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec3d {

    public static readonly Vec3d One = new Vec3d(1, 1, 1);
    public static readonly Vec3d Zero = new Vec3d(0, 0, 0);

    public double X, Y, Z;

    public Vec3d (double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
          }

    
    public static implicit operator Vec3d (double v) {
      return new Vec3d(v, v, v);
    }

    public static Vec3d operator+ (Vec3d a, Vec3d b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            return a;
    }

    public static Vec3d operator- (Vec3d a, Vec3d b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            return a;
    }

    public static Vec3d operator* (Vec3d a, Vec3d b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            return a;
    }

    public static Vec3d operator/ (Vec3d a, Vec3d b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            return a;
    }

    public static Vec3d operator% (Vec3d a, Vec3d b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            return a;
    }

    public static Vec3d operator+ (Vec3d a, double b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            return a;
    }

    public static Vec3d operator- (Vec3d a, double b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            return a;
    }

    public static Vec3d operator* (Vec3d a, double b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            return a;
    }

    public static Vec3d operator/ (Vec3d a, double b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            return a;
    }

    public static Vec3d operator% (Vec3d a, double b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            return a;
    }

    public static Vec3d operator+ (double a, Vec3d b) {
      Vec3d c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            return c;
    }

    public static Vec3d operator- (double a, Vec3d b) {
      Vec3d c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            return c;
    }

    public static Vec3d operator* (double a, Vec3d b) {
      Vec3d c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            return c;
    }

    public static Vec3d operator/ (double a, Vec3d b) {
      Vec3d c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            return c;
    }

    public static Vec3d operator% (double a, Vec3d b) {
      Vec3d c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            return c;
    }

    public double LengthSquared {
      get {
        double t = 0;
                t += (double) (X * X);
                t += (double) (Y * Y);
                t += (double) (Z * Z);
                return t;
      }
    }

    public double Length {
      get {
        return (double) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec3d Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec3i {

    public static readonly Vec3i One = new Vec3i(1, 1, 1);
    public static readonly Vec3i Zero = new Vec3i(0, 0, 0);

    public int X, Y, Z;

    public Vec3i (int x, int y, int z) {
            X = x;
            Y = y;
            Z = z;
          }

    
    public static implicit operator Vec3i (int v) {
      return new Vec3i(v, v, v);
    }

    public static Vec3i operator+ (Vec3i a, Vec3i b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            return a;
    }

    public static Vec3i operator- (Vec3i a, Vec3i b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            return a;
    }

    public static Vec3i operator* (Vec3i a, Vec3i b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            return a;
    }

    public static Vec3i operator/ (Vec3i a, Vec3i b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            return a;
    }

    public static Vec3i operator% (Vec3i a, Vec3i b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            return a;
    }

    public static Vec3i operator+ (Vec3i a, int b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            return a;
    }

    public static Vec3i operator- (Vec3i a, int b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            return a;
    }

    public static Vec3i operator* (Vec3i a, int b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            return a;
    }

    public static Vec3i operator/ (Vec3i a, int b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            return a;
    }

    public static Vec3i operator% (Vec3i a, int b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            return a;
    }

    public static Vec3i operator+ (int a, Vec3i b) {
      Vec3i c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            return c;
    }

    public static Vec3i operator- (int a, Vec3i b) {
      Vec3i c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            return c;
    }

    public static Vec3i operator* (int a, Vec3i b) {
      Vec3i c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            return c;
    }

    public static Vec3i operator/ (int a, Vec3i b) {
      Vec3i c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            return c;
    }

    public static Vec3i operator% (int a, Vec3i b) {
      Vec3i c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            return c;
    }

    public int LengthSquared {
      get {
        int t = 0;
                t += (int) (X * X);
                t += (int) (Y * Y);
                t += (int) (Z * Z);
                return t;
      }
    }

    public int Length {
      get {
        return (int) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec3i Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec3b {

    public static readonly Vec3b One = new Vec3b(1, 1, 1);
    public static readonly Vec3b Zero = new Vec3b(0, 0, 0);

    public sbyte X, Y, Z;

    public Vec3b (sbyte x, sbyte y, sbyte z) {
            X = x;
            Y = y;
            Z = z;
          }

    
    public static implicit operator Vec3b (sbyte v) {
      return new Vec3b(v, v, v);
    }

    public static Vec3b operator+ (Vec3b a, Vec3b b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            return a;
    }

    public static Vec3b operator- (Vec3b a, Vec3b b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            return a;
    }

    public static Vec3b operator* (Vec3b a, Vec3b b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            return a;
    }

    public static Vec3b operator/ (Vec3b a, Vec3b b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            return a;
    }

    public static Vec3b operator% (Vec3b a, Vec3b b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            return a;
    }

    public static Vec3b operator+ (Vec3b a, sbyte b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            return a;
    }

    public static Vec3b operator- (Vec3b a, sbyte b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            return a;
    }

    public static Vec3b operator* (Vec3b a, sbyte b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            return a;
    }

    public static Vec3b operator/ (Vec3b a, sbyte b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            return a;
    }

    public static Vec3b operator% (Vec3b a, sbyte b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            return a;
    }

    public static Vec3b operator+ (sbyte a, Vec3b b) {
      Vec3b c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            return c;
    }

    public static Vec3b operator- (sbyte a, Vec3b b) {
      Vec3b c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            return c;
    }

    public static Vec3b operator* (sbyte a, Vec3b b) {
      Vec3b c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            return c;
    }

    public static Vec3b operator/ (sbyte a, Vec3b b) {
      Vec3b c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            return c;
    }

    public static Vec3b operator% (sbyte a, Vec3b b) {
      Vec3b c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            return c;
    }

    public sbyte LengthSquared {
      get {
        sbyte t = 0;
                t += (sbyte) (X * X);
                t += (sbyte) (Y * Y);
                t += (sbyte) (Z * Z);
                return t;
      }
    }

    public sbyte Length {
      get {
        return (sbyte) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec3b Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec4f {

    public static readonly Vec4f One = new Vec4f(1, 1, 1, 1);
    public static readonly Vec4f Zero = new Vec4f(0, 0, 0, 0);

    public float X, Y, Z, W;

    public Vec4f (float x, float y, float z, float w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
          }

        public Vec4f (double x, double y, double z, double w) {
            X = (float) x;
            Y = (float) y;
            Z = (float) z;
            W = (float) w;
          }
    
    public static implicit operator Vec4f (float v) {
      return new Vec4f(v, v, v, v);
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

    public static Vec4f operator* (Vec4f a, Vec4f b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            a.W *= b.W;
            return a;
    }

    public static Vec4f operator/ (Vec4f a, Vec4f b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            a.W /= b.W;
            return a;
    }

    public static Vec4f operator% (Vec4f a, Vec4f b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            a.W %= b.W;
            return a;
    }

    public static Vec4f operator+ (Vec4f a, float b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            a.W += b;
            return a;
    }

    public static Vec4f operator- (Vec4f a, float b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            a.W -= b;
            return a;
    }

    public static Vec4f operator* (Vec4f a, float b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            a.W *= b;
            return a;
    }

    public static Vec4f operator/ (Vec4f a, float b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            a.W /= b;
            return a;
    }

    public static Vec4f operator% (Vec4f a, float b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            a.W %= b;
            return a;
    }

    public static Vec4f operator+ (float a, Vec4f b) {
      Vec4f c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            c.W += b.W;
            return c;
    }

    public static Vec4f operator- (float a, Vec4f b) {
      Vec4f c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            c.W -= b.W;
            return c;
    }

    public static Vec4f operator* (float a, Vec4f b) {
      Vec4f c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            c.W *= b.W;
            return c;
    }

    public static Vec4f operator/ (float a, Vec4f b) {
      Vec4f c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            c.W /= b.W;
            return c;
    }

    public static Vec4f operator% (float a, Vec4f b) {
      Vec4f c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            c.W %= b.W;
            return c;
    }

    public float LengthSquared {
      get {
        float t = 0;
                t += (float) (X * X);
                t += (float) (Y * Y);
                t += (float) (Z * Z);
                t += (float) (W * W);
                return t;
      }
    }

    public float Length {
      get {
        return (float) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec4f Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec4d {

    public static readonly Vec4d One = new Vec4d(1, 1, 1, 1);
    public static readonly Vec4d Zero = new Vec4d(0, 0, 0, 0);

    public double X, Y, Z, W;

    public Vec4d (double x, double y, double z, double w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
          }

    
    public static implicit operator Vec4d (double v) {
      return new Vec4d(v, v, v, v);
    }

    public static Vec4d operator+ (Vec4d a, Vec4d b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            a.W += b.W;
            return a;
    }

    public static Vec4d operator- (Vec4d a, Vec4d b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            a.W -= b.W;
            return a;
    }

    public static Vec4d operator* (Vec4d a, Vec4d b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            a.W *= b.W;
            return a;
    }

    public static Vec4d operator/ (Vec4d a, Vec4d b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            a.W /= b.W;
            return a;
    }

    public static Vec4d operator% (Vec4d a, Vec4d b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            a.W %= b.W;
            return a;
    }

    public static Vec4d operator+ (Vec4d a, double b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            a.W += b;
            return a;
    }

    public static Vec4d operator- (Vec4d a, double b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            a.W -= b;
            return a;
    }

    public static Vec4d operator* (Vec4d a, double b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            a.W *= b;
            return a;
    }

    public static Vec4d operator/ (Vec4d a, double b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            a.W /= b;
            return a;
    }

    public static Vec4d operator% (Vec4d a, double b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            a.W %= b;
            return a;
    }

    public static Vec4d operator+ (double a, Vec4d b) {
      Vec4d c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            c.W += b.W;
            return c;
    }

    public static Vec4d operator- (double a, Vec4d b) {
      Vec4d c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            c.W -= b.W;
            return c;
    }

    public static Vec4d operator* (double a, Vec4d b) {
      Vec4d c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            c.W *= b.W;
            return c;
    }

    public static Vec4d operator/ (double a, Vec4d b) {
      Vec4d c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            c.W /= b.W;
            return c;
    }

    public static Vec4d operator% (double a, Vec4d b) {
      Vec4d c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            c.W %= b.W;
            return c;
    }

    public double LengthSquared {
      get {
        double t = 0;
                t += (double) (X * X);
                t += (double) (Y * Y);
                t += (double) (Z * Z);
                t += (double) (W * W);
                return t;
      }
    }

    public double Length {
      get {
        return (double) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec4d Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec4i {

    public static readonly Vec4i One = new Vec4i(1, 1, 1, 1);
    public static readonly Vec4i Zero = new Vec4i(0, 0, 0, 0);

    public int X, Y, Z, W;

    public Vec4i (int x, int y, int z, int w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
          }

    
    public static implicit operator Vec4i (int v) {
      return new Vec4i(v, v, v, v);
    }

    public static Vec4i operator+ (Vec4i a, Vec4i b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            a.W += b.W;
            return a;
    }

    public static Vec4i operator- (Vec4i a, Vec4i b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            a.W -= b.W;
            return a;
    }

    public static Vec4i operator* (Vec4i a, Vec4i b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            a.W *= b.W;
            return a;
    }

    public static Vec4i operator/ (Vec4i a, Vec4i b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            a.W /= b.W;
            return a;
    }

    public static Vec4i operator% (Vec4i a, Vec4i b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            a.W %= b.W;
            return a;
    }

    public static Vec4i operator+ (Vec4i a, int b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            a.W += b;
            return a;
    }

    public static Vec4i operator- (Vec4i a, int b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            a.W -= b;
            return a;
    }

    public static Vec4i operator* (Vec4i a, int b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            a.W *= b;
            return a;
    }

    public static Vec4i operator/ (Vec4i a, int b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            a.W /= b;
            return a;
    }

    public static Vec4i operator% (Vec4i a, int b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            a.W %= b;
            return a;
    }

    public static Vec4i operator+ (int a, Vec4i b) {
      Vec4i c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            c.W += b.W;
            return c;
    }

    public static Vec4i operator- (int a, Vec4i b) {
      Vec4i c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            c.W -= b.W;
            return c;
    }

    public static Vec4i operator* (int a, Vec4i b) {
      Vec4i c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            c.W *= b.W;
            return c;
    }

    public static Vec4i operator/ (int a, Vec4i b) {
      Vec4i c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            c.W /= b.W;
            return c;
    }

    public static Vec4i operator% (int a, Vec4i b) {
      Vec4i c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            c.W %= b.W;
            return c;
    }

    public int LengthSquared {
      get {
        int t = 0;
                t += (int) (X * X);
                t += (int) (Y * Y);
                t += (int) (Z * Z);
                t += (int) (W * W);
                return t;
      }
    }

    public int Length {
      get {
        return (int) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec4i Normalized {
      get {
        return this / Length;
      }
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public partial struct Vec4b {

    public static readonly Vec4b One = new Vec4b(1, 1, 1, 1);
    public static readonly Vec4b Zero = new Vec4b(0, 0, 0, 0);

    public sbyte X, Y, Z, W;

    public Vec4b (sbyte x, sbyte y, sbyte z, sbyte w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
          }

    
    public static implicit operator Vec4b (sbyte v) {
      return new Vec4b(v, v, v, v);
    }

    public static Vec4b operator+ (Vec4b a, Vec4b b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            a.W += b.W;
            return a;
    }

    public static Vec4b operator- (Vec4b a, Vec4b b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            a.W -= b.W;
            return a;
    }

    public static Vec4b operator* (Vec4b a, Vec4b b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            a.W *= b.W;
            return a;
    }

    public static Vec4b operator/ (Vec4b a, Vec4b b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            a.W /= b.W;
            return a;
    }

    public static Vec4b operator% (Vec4b a, Vec4b b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            a.W %= b.W;
            return a;
    }

    public static Vec4b operator+ (Vec4b a, sbyte b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            a.W += b;
            return a;
    }

    public static Vec4b operator- (Vec4b a, sbyte b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            a.W -= b;
            return a;
    }

    public static Vec4b operator* (Vec4b a, sbyte b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            a.W *= b;
            return a;
    }

    public static Vec4b operator/ (Vec4b a, sbyte b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            a.W /= b;
            return a;
    }

    public static Vec4b operator% (Vec4b a, sbyte b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            a.W %= b;
            return a;
    }

    public static Vec4b operator+ (sbyte a, Vec4b b) {
      Vec4b c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            c.W += b.W;
            return c;
    }

    public static Vec4b operator- (sbyte a, Vec4b b) {
      Vec4b c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            c.W -= b.W;
            return c;
    }

    public static Vec4b operator* (sbyte a, Vec4b b) {
      Vec4b c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            c.W *= b.W;
            return c;
    }

    public static Vec4b operator/ (sbyte a, Vec4b b) {
      Vec4b c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            c.W /= b.W;
            return c;
    }

    public static Vec4b operator% (sbyte a, Vec4b b) {
      Vec4b c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            c.W %= b.W;
            return c;
    }

    public sbyte LengthSquared {
      get {
        sbyte t = 0;
                t += (sbyte) (X * X);
                t += (sbyte) (Y * Y);
                t += (sbyte) (Z * Z);
                t += (sbyte) (W * W);
                return t;
      }
    }

    public sbyte Length {
      get {
        return (sbyte) System.Math.Sqrt(LengthSquared);
      }
    }

    public Vec4b Normalized {
      get {
        return this / Length;
      }
    }

  }


}
