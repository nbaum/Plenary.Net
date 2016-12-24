using System.Runtime.InteropServices;
using Plenary.Interop;
using Plenary.Math;

namespace Plenary.OpenGL {

  public class Buffer: Named {
    
    public uint ElementType;

    public int ElementSize, ElementStride;

    public int Length;

    public Buffer () {
      GL.CreateBuffers(1, out Name);
    }

    public override void Dispose () {
      GL.DeleteBuffers(1, new []{ Name });
    }

    public Buffer Storage<T> (T[] data, uint type, int size) {
      ElementType = type;
      ElementSize = size;
      ElementStride = Marshal.SizeOf<T>();
      Length = data.Length;
      Utils.WithIntPtr(data, (len, ptr) => GL.NamedBufferStorage(Name, len, ptr, 0));
      return this;
    }

    public Buffer Storage<T> (T[,] data, uint type) {
      ElementType = type;
      ElementSize = data.GetLength(1);
      ElementStride = Marshal.SizeOf<T>() * ElementSize;
      Length = data.GetLength(0);
      Utils.WithIntPtr(data, (len, ptr) => GL.NamedBufferStorage(Name, len, ptr, 0));
      return this;
    }

    public Buffer Storage (Vec2f[] data) => Storage(data, GL.FLOAT, 2);

    public Buffer Storage (Vec3f[] data) => Storage(data, GL.FLOAT, 3);

    public Buffer Storage (Vec4f[] data) => Storage(data, GL.FLOAT, 4);

    public Buffer Storage (Vec2d[] data) => Storage(data, GL.DOUBLE, 2);

    public Buffer Storage (Vec3d[] data) => Storage(data, GL.DOUBLE, 3);

    public Buffer Storage (Vec4d[] data) => Storage(data, GL.DOUBLE, 4);

    public Buffer Storage (Vec2i[] data) => Storage(data, GL.INT, 2);

    public Buffer Storage (Vec3i[] data) => Storage(data, GL.INT, 3);

    public Buffer Storage (Vec4i[] data) => Storage(data, GL.INT, 4);

    public Buffer Storage (Vec2b[] data) => Storage(data, GL.BYTE, 2);

    public Buffer Storage (Vec3b[] data) => Storage(data, GL.BYTE, 3);

    public Buffer Storage (Vec4b[] data) => Storage(data, GL.BYTE, 4);

    public Buffer Storage (byte[] data) => Storage(data, GL.UNSIGNED_BYTE, 1);

    public Buffer Storage (uint[] data) => Storage(data, GL.UNSIGNED_INT, 1);

    public Buffer Storage (ushort[] data) => Storage(data, GL.UNSIGNED_SHORT, 1);

    public Buffer Storage (float[,] data) => Storage(data, GL.FLOAT);

    public Buffer Storage (double[,] data) => Storage(data, GL.DOUBLE);

  }

}
