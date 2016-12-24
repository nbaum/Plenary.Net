
using System.Runtime.InteropServices;
using System;

namespace Plenary.Math {

  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec2f {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec2d {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec2i {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec2c {

    public char X, Y;

    public Vec2c (char x, char y) {
            X = x;
            Y = y;
          }

    
    public static implicit operator Vec2c (char v) {
      return new Vec2c(v, v);
    }

    public static Vec2c operator+ (Vec2c a, Vec2c b) {
            a.X += b.X;
            a.Y += b.Y;
            return a;
    }

    public static Vec2c operator- (Vec2c a, Vec2c b) {
            a.X -= b.X;
            a.Y -= b.Y;
            return a;
    }

    public static Vec2c operator* (Vec2c a, Vec2c b) {
            a.X *= b.X;
            a.Y *= b.Y;
            return a;
    }

    public static Vec2c operator/ (Vec2c a, Vec2c b) {
            a.X /= b.X;
            a.Y /= b.Y;
            return a;
    }

    public static Vec2c operator% (Vec2c a, Vec2c b) {
            a.X %= b.X;
            a.Y %= b.Y;
            return a;
    }

    public static Vec2c operator+ (Vec2c a, char b) {
            a.X += b;
            a.Y += b;
            return a;
    }

    public static Vec2c operator- (Vec2c a, char b) {
            a.X -= b;
            a.Y -= b;
            return a;
    }

    public static Vec2c operator* (Vec2c a, char b) {
            a.X *= b;
            a.Y *= b;
            return a;
    }

    public static Vec2c operator/ (Vec2c a, char b) {
            a.X /= b;
            a.Y /= b;
            return a;
    }

    public static Vec2c operator% (Vec2c a, char b) {
            a.X %= b;
            a.Y %= b;
            return a;
    }

    public static Vec2c operator+ (char a, Vec2c b) {
      Vec2c c = a;
            c.X += b.X;
            c.Y += b.Y;
            return c;
    }

    public static Vec2c operator- (char a, Vec2c b) {
      Vec2c c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            return c;
    }

    public static Vec2c operator* (char a, Vec2c b) {
      Vec2c c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            return c;
    }

    public static Vec2c operator/ (char a, Vec2c b) {
      Vec2c c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            return c;
    }

    public static Vec2c operator% (char a, Vec2c b) {
      Vec2c c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            return c;
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec3f {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec3d {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec3i {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec3c {

    public char X, Y, Z;

    public Vec3c (char x, char y, char z) {
            X = x;
            Y = y;
            Z = z;
          }

    
    public static implicit operator Vec3c (char v) {
      return new Vec3c(v, v, v);
    }

    public static Vec3c operator+ (Vec3c a, Vec3c b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            return a;
    }

    public static Vec3c operator- (Vec3c a, Vec3c b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            return a;
    }

    public static Vec3c operator* (Vec3c a, Vec3c b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            return a;
    }

    public static Vec3c operator/ (Vec3c a, Vec3c b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            return a;
    }

    public static Vec3c operator% (Vec3c a, Vec3c b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            return a;
    }

    public static Vec3c operator+ (Vec3c a, char b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            return a;
    }

    public static Vec3c operator- (Vec3c a, char b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            return a;
    }

    public static Vec3c operator* (Vec3c a, char b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            return a;
    }

    public static Vec3c operator/ (Vec3c a, char b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            return a;
    }

    public static Vec3c operator% (Vec3c a, char b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            return a;
    }

    public static Vec3c operator+ (char a, Vec3c b) {
      Vec3c c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            return c;
    }

    public static Vec3c operator- (char a, Vec3c b) {
      Vec3c c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            return c;
    }

    public static Vec3c operator* (char a, Vec3c b) {
      Vec3c c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            return c;
    }

    public static Vec3c operator/ (char a, Vec3c b) {
      Vec3c c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            return c;
    }

    public static Vec3c operator% (char a, Vec3c b) {
      Vec3c c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            return c;
    }

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec4f {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec4d {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec4i {

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

  }


  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
    public struct Vec4c {

    public char X, Y, Z, W;

    public Vec4c (char x, char y, char z, char w) {
            X = x;
            Y = y;
            Z = z;
            W = w;
          }

    
    public static implicit operator Vec4c (char v) {
      return new Vec4c(v, v, v, v);
    }

    public static Vec4c operator+ (Vec4c a, Vec4c b) {
            a.X += b.X;
            a.Y += b.Y;
            a.Z += b.Z;
            a.W += b.W;
            return a;
    }

    public static Vec4c operator- (Vec4c a, Vec4c b) {
            a.X -= b.X;
            a.Y -= b.Y;
            a.Z -= b.Z;
            a.W -= b.W;
            return a;
    }

    public static Vec4c operator* (Vec4c a, Vec4c b) {
            a.X *= b.X;
            a.Y *= b.Y;
            a.Z *= b.Z;
            a.W *= b.W;
            return a;
    }

    public static Vec4c operator/ (Vec4c a, Vec4c b) {
            a.X /= b.X;
            a.Y /= b.Y;
            a.Z /= b.Z;
            a.W /= b.W;
            return a;
    }

    public static Vec4c operator% (Vec4c a, Vec4c b) {
            a.X %= b.X;
            a.Y %= b.Y;
            a.Z %= b.Z;
            a.W %= b.W;
            return a;
    }

    public static Vec4c operator+ (Vec4c a, char b) {
            a.X += b;
            a.Y += b;
            a.Z += b;
            a.W += b;
            return a;
    }

    public static Vec4c operator- (Vec4c a, char b) {
            a.X -= b;
            a.Y -= b;
            a.Z -= b;
            a.W -= b;
            return a;
    }

    public static Vec4c operator* (Vec4c a, char b) {
            a.X *= b;
            a.Y *= b;
            a.Z *= b;
            a.W *= b;
            return a;
    }

    public static Vec4c operator/ (Vec4c a, char b) {
            a.X /= b;
            a.Y /= b;
            a.Z /= b;
            a.W /= b;
            return a;
    }

    public static Vec4c operator% (Vec4c a, char b) {
            a.X %= b;
            a.Y %= b;
            a.Z %= b;
            a.W %= b;
            return a;
    }

    public static Vec4c operator+ (char a, Vec4c b) {
      Vec4c c = a;
            c.X += b.X;
            c.Y += b.Y;
            c.Z += b.Z;
            c.W += b.W;
            return c;
    }

    public static Vec4c operator- (char a, Vec4c b) {
      Vec4c c = a;
            c.X -= b.X;
            c.Y -= b.Y;
            c.Z -= b.Z;
            c.W -= b.W;
            return c;
    }

    public static Vec4c operator* (char a, Vec4c b) {
      Vec4c c = a;
            c.X *= b.X;
            c.Y *= b.Y;
            c.Z *= b.Z;
            c.W *= b.W;
            return c;
    }

    public static Vec4c operator/ (char a, Vec4c b) {
      Vec4c c = a;
            c.X /= b.X;
            c.Y /= b.Y;
            c.Z /= b.Z;
            c.W /= b.W;
            return c;
    }

    public static Vec4c operator% (char a, Vec4c b) {
      Vec4c c = a;
            c.X %= b.X;
            c.Y %= b.Y;
            c.Z %= b.Z;
            c.W %= b.W;
            return c;
    }

  }


}
