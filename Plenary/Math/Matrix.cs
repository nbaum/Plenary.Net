using MathNet.Spatial.Euclidean;
using System.Runtime.InteropServices;
using System;

namespace Plenary.Math {

  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
  public partial struct Mat4f {

    public float M00, M01, M02, M03,
                    M10, M11, M12, M13,
                    M20, M21, M22, M23,
                    M30, M31, M32, M33;

    public static implicit operator float[] (Mat4f m) {
      return new [] { m.M00, m.M01, m.M02, m.M03,
                      m.M10, m.M11, m.M12, m.M13,
                      m.M20, m.M21, m.M22, m.M23,
                      m.M30, m.M31, m.M32, m.M33 };
    }

    public Mat4f (float m00, float m01, float m02, float m03,
                            float m10, float m11, float m12, float m13,
                            float m20, float m21, float m22, float m23,
                            float m30, float m31, float m32, float m33) {
      M00 = (float) m00; M01 = (float) m01; M02 = (float) m02; M03 = (float) m03;
      M10 = (float) m10; M11 = (float) m11; M12 = (float) m12; M13 = (float) m13;
      M20 = (float) m20; M21 = (float) m21; M22 = (float) m22; M23 = (float) m23;
      M30 = (float) m30; M31 = (float) m31; M32 = (float) m32; M33 = (float) m33;
    }

    public Mat4f (double m00, double m01, double m02, double m03,
                            double m10, double m11, double m12, double m13,
                            double m20, double m21, double m22, double m23,
                            double m30, double m31, double m32, double m33) {
      M00 = (float) m00; M01 = (float) m01; M02 = (float) m02; M03 = (float) m03;
      M10 = (float) m10; M11 = (float) m11; M12 = (float) m12; M13 = (float) m13;
      M20 = (float) m20; M21 = (float) m21; M22 = (float) m22; M23 = (float) m23;
      M30 = (float) m30; M31 = (float) m31; M32 = (float) m32; M33 = (float) m33;
    }

    public static Mat4f Eye {
      get {
        Mat4f m;
        m.M00 = 1; m.M01 = 0; m.M02 = 0; m.M03 = 0;
        m.M10 = 0; m.M11 = 1; m.M12 = 0; m.M13 = 0;
        m.M20 = 0; m.M21 = 0; m.M22 = 1; m.M23 = 0;
        m.M30 = 0; m.M31 = 0; m.M32 = 0; m.M33 = 1;
        return m;
      }
    }

    public unsafe static Mat4f operator* (Mat4f a, Mat4f b) {
      Mat4f c;
      c.M00 = b.M00 * a.M00 + b.M10 * a.M01 + b.M20 * a.M02 + b.M30 * a.M03;
      c.M01 = b.M01 * a.M00 + b.M11 * a.M01 + b.M21 * a.M02 + b.M31 * a.M03;
      c.M02 = b.M02 * a.M00 + b.M12 * a.M01 + b.M22 * a.M02 + b.M32 * a.M03;
      c.M03 = b.M03 * a.M00 + b.M13 * a.M01 + b.M23 * a.M02 + b.M33 * a.M03;
      c.M10 = b.M00 * a.M10 + b.M10 * a.M11 + b.M20 * a.M12 + b.M30 * a.M13;
      c.M11 = b.M01 * a.M10 + b.M11 * a.M11 + b.M21 * a.M12 + b.M31 * a.M13;
      c.M12 = b.M02 * a.M10 + b.M12 * a.M11 + b.M22 * a.M12 + b.M32 * a.M13;
      c.M13 = b.M03 * a.M10 + b.M13 * a.M11 + b.M23 * a.M12 + b.M33 * a.M13;
      c.M20 = b.M00 * a.M20 + b.M10 * a.M21 + b.M20 * a.M22 + b.M30 * a.M23;
      c.M21 = b.M01 * a.M20 + b.M11 * a.M21 + b.M21 * a.M22 + b.M31 * a.M23;
      c.M22 = b.M02 * a.M20 + b.M12 * a.M21 + b.M22 * a.M22 + b.M32 * a.M23;
      c.M23 = b.M03 * a.M20 + b.M13 * a.M21 + b.M23 * a.M22 + b.M33 * a.M23;
      c.M30 = b.M00 * a.M30 + b.M10 * a.M31 + b.M20 * a.M32 + b.M30 * a.M33;
      c.M31 = b.M01 * a.M30 + b.M11 * a.M31 + b.M21 * a.M32 + b.M31 * a.M33;
      c.M32 = b.M02 * a.M30 + b.M12 * a.M31 + b.M22 * a.M32 + b.M32 * a.M33;
      c.M33 = b.M03 * a.M30 + b.M13 * a.M31 + b.M23 * a.M32 + b.M33 * a.M33;
      return c;
    }

    public unsafe static Vec4f operator* (Mat4f a, Vec4f b) {
      Vec4f c;
      c.X = a.M00 * b.X + a.M01 * b.Y + a.M02 * b.Z + a.M03 * b.W;
      c.Y = a.M10 * b.X + a.M11 * b.Y + a.M12 * b.Z + a.M13 * b.W;
      c.Z = a.M20 * b.X + a.M21 * b.Y + a.M22 * b.Z + a.M23 * b.W;
      c.W = a.M30 * b.X + a.M31 * b.Y + a.M32 * b.Z + a.M33 * b.W;
      return c;
    }

    public unsafe static Vec3f operator* (Mat4f a, Vec3f b) {
      Vec3f c;
      c.X = a.M00 * b.X + a.M01 * b.Y + a.M02 * b.Z + a.M03;
      c.Y = a.M10 * b.X + a.M11 * b.Y + a.M12 * b.Z + a.M13;
      c.Z = a.M20 * b.X + a.M21 * b.Y + a.M22 * b.Z + a.M23;
      return c;
    }

    public unsafe Vec3f TransformDirection (Vec3f b) {
      Vec3f c;
      c.X = M00 * b.X + M01 * b.Y + M02 * b.Z;
      c.Y = M10 * b.X + M11 * b.Y + M12 * b.Z;
      c.Z = M20 * b.X + M21 * b.Y + M22 * b.Z;
      return c / M33;
    }

    public unsafe Vec3f TransformPoint (Vec3f b) {
      b.X += M03;
      b.Y += M13;
      b.Z += M23;
      return b;
    }

    public static Mat4f Ortho (double size, double aspect, double near, double far) {
      return new Mat4f(
        (2 * aspect) / size, 0,          0,                   0,
        0,                   2.0 / size, 0,                   0,
        0,                   0,          -2.0 / (far - near), -(far + near) / (far - near),
        0,                   0,          0,                   1.0
      );
    }

    public static Mat4f Perspective (double fov, double aspect, double near, double far) {
      double range = System.Math.Tan(fov / 2) * near;
      double sy = near / range;
      double sx = sy * aspect;
      double sz = -(far + near) / (far - near);
      double pz = -(2 * far * near) / (far - near);
      return new Mat4f(
        sx, 0,  0,  0,
        0,  sy, 0,  0,
        0,  0,  sz, pz,
        0,  0,  -1, 0
      );
    }

    public static Mat4f Scale (double x, double y, double z, double w = 1) {
      return new Mat4f(
        x, 0, 0, 0,
        0, y, 0, 0,
        0, 0, z, 0,
        0, 0, 0, w
      );
    }

    public static Mat4f Scale (double s, double w = 1) {
      return new Mat4f(
        s, 0, 0, 0,
        0, s, 0, 0,
        0, 0, s, 0,
        0, 0, 0, w
      );
    }

    public static Mat4f Translate (double x, double y, double z, double w = 1) {
      return new Mat4f(
        1, 0, 0, x,
        0, 1, 0, y,
        0, 0, 1, z,
        0, 0, 0, w
      );
    }

    public static Mat4f Rotate (double angle, double x, double y, double z) {
      double cos = System.Math.Cos(angle);
      double sin = System.Math.Sin(angle);
      double t = 1 - cos;
      double txx = t * x * x,
             txy = t * x * y,
             txz = t * x * z,
             tyy = t * y * y,
             tyz = t * y * z,
             tzz = t * z * z,
             sinx = sin * x,
             siny = sin * y,
             sinz = sin * z;
      var m = Mat4f.Eye;
      m.M00 = (float) (txx + cos);
      m.M01 = (float) (txy - sinz);
      m.M02 = (float) (txz + siny);
      m.M10 = (float) (txy + sinz);
      m.M11 = (float) (tyy + cos);
      m.M12 = (float) (tyz - sinx);
      m.M20 = (float) (txz - siny);
      m.M21 = (float) (tyz + sinx);
      m.M22 = (float) (tzz + cos);
      return m;
    }

    public static Mat4f Rotate (double x, double y, double z) =>  RotateX(x) * RotateY(y) * RotateZ(z);
    public static Mat4f RotateX (double a) => Rotate(a, 1, 0, 0);
    public static Mat4f RotateY (double a) => Rotate(a, 0, 1, 0);
    public static Mat4f RotateZ (double a) => Rotate(a, 0, 0, 1);

    public Mat4f RotScale {
      get {
        return new Mat4f(M00, M01, M02, 0,
                                   M10, M11, M12, 0,
                                   M20, M21, M22, 0,
                                   0,   0,   0, 1);
      }
    }

    public Mat4f Inverse {
      
      get {
        float a00 = M00, a01 = M01, a02 = M02, a03 = M03,
              a10 = M10, a11 = M11, a12 = M12, a13 = M13,
              a20 = M20, a21 = M21, a22 = M22, a23 = M23,
              a30 = M30, a31 = M31, a32 = M32, a33 = M33,
              b00 = a00 * a11 - a01 * a10,
              b01 = a00 * a12 - a02 * a10,
              b02 = a00 * a13 - a03 * a10,
              b03 = a01 * a12 - a02 * a11,
              b04 = a01 * a13 - a03 * a11,
              b05 = a02 * a13 - a03 * a12,
              b06 = a20 * a31 - a21 * a30,
              b07 = a20 * a32 - a22 * a30,
              b08 = a20 * a33 - a23 * a30,
              b09 = a21 * a32 - a22 * a31,
              b10 = a21 * a33 - a23 * a31,
              b11 = a22 * a33 - a23 * a32,
              det = b00 * b11 - b01 * b10 + b02 * b09 + b03 * b08 - b04 * b07 + b05 * b06;
        return new Mat4f((a11 * b11 - a12 * b10 + a13 * b09) / det,
                     (a02 * b10 - a01 * b11 - a03 * b09) / det,
                     (a31 * b05 - a32 * b04 + a33 * b03) / det,
                     (a22 * b04 - a21 * b05 - a23 * b03) / det,
                     (a12 * b08 - a10 * b11 - a13 * b07) / det,
                     (a00 * b11 - a02 * b08 + a03 * b07) / det,
                     (a32 * b02 - a30 * b05 - a33 * b01) / det,
                     (a20 * b05 - a22 * b02 + a23 * b01) / det,
                     (a10 * b10 - a11 * b08 + a13 * b06) / det,
                     (a01 * b08 - a00 * b10 - a03 * b06) / det,
                     (a30 * b04 - a31 * b02 + a33 * b00) / det,
                     (a21 * b02 - a20 * b04 - a23 * b00) / det,
                     (a11 * b07 - a10 * b09 - a12 * b06) / det,
                     (a00 * b09 - a01 * b07 + a02 * b06) / det,
                     (a31 * b01 - a30 * b03 - a32 * b00) / det,
                     (a20 * b03 - a21 * b01 + a22 * b00) / det);
      }

    }

  }

  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
  public partial struct Mat4d {

    public double M00, M01, M02, M03,
                    M10, M11, M12, M13,
                    M20, M21, M22, M23,
                    M30, M31, M32, M33;

    public static implicit operator double[] (Mat4d m) {
      return new [] { m.M00, m.M01, m.M02, m.M03,
                      m.M10, m.M11, m.M12, m.M13,
                      m.M20, m.M21, m.M22, m.M23,
                      m.M30, m.M31, m.M32, m.M33 };
    }

    public Mat4d (float m00, float m01, float m02, float m03,
                            float m10, float m11, float m12, float m13,
                            float m20, float m21, float m22, float m23,
                            float m30, float m31, float m32, float m33) {
      M00 = (double) m00; M01 = (double) m01; M02 = (double) m02; M03 = (double) m03;
      M10 = (double) m10; M11 = (double) m11; M12 = (double) m12; M13 = (double) m13;
      M20 = (double) m20; M21 = (double) m21; M22 = (double) m22; M23 = (double) m23;
      M30 = (double) m30; M31 = (double) m31; M32 = (double) m32; M33 = (double) m33;
    }

    public Mat4d (double m00, double m01, double m02, double m03,
                            double m10, double m11, double m12, double m13,
                            double m20, double m21, double m22, double m23,
                            double m30, double m31, double m32, double m33) {
      M00 = (double) m00; M01 = (double) m01; M02 = (double) m02; M03 = (double) m03;
      M10 = (double) m10; M11 = (double) m11; M12 = (double) m12; M13 = (double) m13;
      M20 = (double) m20; M21 = (double) m21; M22 = (double) m22; M23 = (double) m23;
      M30 = (double) m30; M31 = (double) m31; M32 = (double) m32; M33 = (double) m33;
    }

    public static Mat4d Eye {
      get {
        Mat4d m;
        m.M00 = 1; m.M01 = 0; m.M02 = 0; m.M03 = 0;
        m.M10 = 0; m.M11 = 1; m.M12 = 0; m.M13 = 0;
        m.M20 = 0; m.M21 = 0; m.M22 = 1; m.M23 = 0;
        m.M30 = 0; m.M31 = 0; m.M32 = 0; m.M33 = 1;
        return m;
      }
    }

    public unsafe static Mat4d operator* (Mat4d a, Mat4d b) {
      Mat4d c;
      c.M00 = b.M00 * a.M00 + b.M10 * a.M01 + b.M20 * a.M02 + b.M30 * a.M03;
      c.M01 = b.M01 * a.M00 + b.M11 * a.M01 + b.M21 * a.M02 + b.M31 * a.M03;
      c.M02 = b.M02 * a.M00 + b.M12 * a.M01 + b.M22 * a.M02 + b.M32 * a.M03;
      c.M03 = b.M03 * a.M00 + b.M13 * a.M01 + b.M23 * a.M02 + b.M33 * a.M03;
      c.M10 = b.M00 * a.M10 + b.M10 * a.M11 + b.M20 * a.M12 + b.M30 * a.M13;
      c.M11 = b.M01 * a.M10 + b.M11 * a.M11 + b.M21 * a.M12 + b.M31 * a.M13;
      c.M12 = b.M02 * a.M10 + b.M12 * a.M11 + b.M22 * a.M12 + b.M32 * a.M13;
      c.M13 = b.M03 * a.M10 + b.M13 * a.M11 + b.M23 * a.M12 + b.M33 * a.M13;
      c.M20 = b.M00 * a.M20 + b.M10 * a.M21 + b.M20 * a.M22 + b.M30 * a.M23;
      c.M21 = b.M01 * a.M20 + b.M11 * a.M21 + b.M21 * a.M22 + b.M31 * a.M23;
      c.M22 = b.M02 * a.M20 + b.M12 * a.M21 + b.M22 * a.M22 + b.M32 * a.M23;
      c.M23 = b.M03 * a.M20 + b.M13 * a.M21 + b.M23 * a.M22 + b.M33 * a.M23;
      c.M30 = b.M00 * a.M30 + b.M10 * a.M31 + b.M20 * a.M32 + b.M30 * a.M33;
      c.M31 = b.M01 * a.M30 + b.M11 * a.M31 + b.M21 * a.M32 + b.M31 * a.M33;
      c.M32 = b.M02 * a.M30 + b.M12 * a.M31 + b.M22 * a.M32 + b.M32 * a.M33;
      c.M33 = b.M03 * a.M30 + b.M13 * a.M31 + b.M23 * a.M32 + b.M33 * a.M33;
      return c;
    }

    public unsafe static Vec4d operator* (Mat4d a, Vec4d b) {
      Vec4d c;
      c.X = a.M00 * b.X + a.M01 * b.Y + a.M02 * b.Z + a.M03 * b.W;
      c.Y = a.M10 * b.X + a.M11 * b.Y + a.M12 * b.Z + a.M13 * b.W;
      c.Z = a.M20 * b.X + a.M21 * b.Y + a.M22 * b.Z + a.M23 * b.W;
      c.W = a.M30 * b.X + a.M31 * b.Y + a.M32 * b.Z + a.M33 * b.W;
      return c;
    }

    public unsafe static Vec3d operator* (Mat4d a, Vec3d b) {
      Vec3d c;
      c.X = a.M00 * b.X + a.M01 * b.Y + a.M02 * b.Z + a.M03;
      c.Y = a.M10 * b.X + a.M11 * b.Y + a.M12 * b.Z + a.M13;
      c.Z = a.M20 * b.X + a.M21 * b.Y + a.M22 * b.Z + a.M23;
      return c;
    }

    public unsafe Vec3d TransformDirection (Vec3d b) {
      Vec3d c;
      c.X = M00 * b.X + M01 * b.Y + M02 * b.Z;
      c.Y = M10 * b.X + M11 * b.Y + M12 * b.Z;
      c.Z = M20 * b.X + M21 * b.Y + M22 * b.Z;
      return c / M33;
    }

    public unsafe Vec3d TransformPoint (Vec3d b) {
      b.X += M03;
      b.Y += M13;
      b.Z += M23;
      return b;
    }

    public static Mat4d Ortho (double size, double aspect, double near, double far) {
      return new Mat4d(
        (2 * aspect) / size, 0,          0,                   0,
        0,                   2.0 / size, 0,                   0,
        0,                   0,          -2.0 / (far - near), -(far + near) / (far - near),
        0,                   0,          0,                   1.0
      );
    }

    public static Mat4d Perspective (double fov, double aspect, double near, double far) {
      double range = System.Math.Tan(fov / 2) * near;
      double sy = near / range;
      double sx = sy * aspect;
      double sz = -(far + near) / (far - near);
      double pz = -(2 * far * near) / (far - near);
      return new Mat4d(
        sx, 0,  0,  0,
        0,  sy, 0,  0,
        0,  0,  sz, pz,
        0,  0,  -1, 0
      );
    }

    public static Mat4d Scale (double x, double y, double z, double w = 1) {
      return new Mat4d(
        x, 0, 0, 0,
        0, y, 0, 0,
        0, 0, z, 0,
        0, 0, 0, w
      );
    }

    public static Mat4d Scale (double s, double w = 1) {
      return new Mat4d(
        s, 0, 0, 0,
        0, s, 0, 0,
        0, 0, s, 0,
        0, 0, 0, w
      );
    }

    public static Mat4d Translate (double x, double y, double z, double w = 1) {
      return new Mat4d(
        1, 0, 0, x,
        0, 1, 0, y,
        0, 0, 1, z,
        0, 0, 0, w
      );
    }

    public static Mat4d Rotate (double angle, double x, double y, double z) {
      double cos = System.Math.Cos(angle);
      double sin = System.Math.Sin(angle);
      double t = 1 - cos;
      double txx = t * x * x,
             txy = t * x * y,
             txz = t * x * z,
             tyy = t * y * y,
             tyz = t * y * z,
             tzz = t * z * z,
             sinx = sin * x,
             siny = sin * y,
             sinz = sin * z;
      var m = Mat4d.Eye;
      m.M00 = (double) (txx + cos);
      m.M01 = (double) (txy - sinz);
      m.M02 = (double) (txz + siny);
      m.M10 = (double) (txy + sinz);
      m.M11 = (double) (tyy + cos);
      m.M12 = (double) (tyz - sinx);
      m.M20 = (double) (txz - siny);
      m.M21 = (double) (tyz + sinx);
      m.M22 = (double) (tzz + cos);
      return m;
    }

    public static Mat4d Rotate (double x, double y, double z) =>  RotateX(x) * RotateY(y) * RotateZ(z);
    public static Mat4d RotateX (double a) => Rotate(a, 1, 0, 0);
    public static Mat4d RotateY (double a) => Rotate(a, 0, 1, 0);
    public static Mat4d RotateZ (double a) => Rotate(a, 0, 0, 1);

    public Mat4d RotScale {
      get {
        return new Mat4d(M00, M01, M02, 0,
                                   M10, M11, M12, 0,
                                   M20, M21, M22, 0,
                                   0,   0,   0, 1);
      }
    }

    public Mat4d Inverse {
      
      get {
        double a00 = M00, a01 = M01, a02 = M02, a03 = M03,
              a10 = M10, a11 = M11, a12 = M12, a13 = M13,
              a20 = M20, a21 = M21, a22 = M22, a23 = M23,
              a30 = M30, a31 = M31, a32 = M32, a33 = M33,
              b00 = a00 * a11 - a01 * a10,
              b01 = a00 * a12 - a02 * a10,
              b02 = a00 * a13 - a03 * a10,
              b03 = a01 * a12 - a02 * a11,
              b04 = a01 * a13 - a03 * a11,
              b05 = a02 * a13 - a03 * a12,
              b06 = a20 * a31 - a21 * a30,
              b07 = a20 * a32 - a22 * a30,
              b08 = a20 * a33 - a23 * a30,
              b09 = a21 * a32 - a22 * a31,
              b10 = a21 * a33 - a23 * a31,
              b11 = a22 * a33 - a23 * a32,
              det = b00 * b11 - b01 * b10 + b02 * b09 + b03 * b08 - b04 * b07 + b05 * b06;
        return new Mat4d((a11 * b11 - a12 * b10 + a13 * b09) / det,
                     (a02 * b10 - a01 * b11 - a03 * b09) / det,
                     (a31 * b05 - a32 * b04 + a33 * b03) / det,
                     (a22 * b04 - a21 * b05 - a23 * b03) / det,
                     (a12 * b08 - a10 * b11 - a13 * b07) / det,
                     (a00 * b11 - a02 * b08 + a03 * b07) / det,
                     (a32 * b02 - a30 * b05 - a33 * b01) / det,
                     (a20 * b05 - a22 * b02 + a23 * b01) / det,
                     (a10 * b10 - a11 * b08 + a13 * b06) / det,
                     (a01 * b08 - a00 * b10 - a03 * b06) / det,
                     (a30 * b04 - a31 * b02 + a33 * b00) / det,
                     (a21 * b02 - a20 * b04 - a23 * b00) / det,
                     (a11 * b07 - a10 * b09 - a12 * b06) / det,
                     (a00 * b09 - a01 * b07 + a02 * b06) / det,
                     (a31 * b01 - a30 * b03 - a32 * b00) / det,
                     (a20 * b03 - a21 * b01 + a22 * b00) / det);
      }

    }

  }

}
