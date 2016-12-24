using System;
using System.Runtime.InteropServices;

using Plenary.Math;
using Plenary.Interop;

namespace Plenary.OpenGL
{
  
  public static class Utils
  {

    public static void Debug(string format, params object[] args) {
      var message = string.Format(format, args);
      GL.DebugMessageInsert(GL.DEBUG_SOURCE_APPLICATION, GL.DEBUG_TYPE_OTHER, 0, GL.DEBUG_SEVERITY_NOTIFICATION, message.Length, message);
    }

    public static void WithIntPtr<T> (T[,] array, Action<int, IntPtr> handler) {
      var len = Marshal.SizeOf<T>() * array.Length;
      var ptr = Marshal.AllocHGlobal(len);
      try {
        var tmp = ptr;
        for (var i = 0; i < array.GetLength(0); ++i) {
          for (var j = 0; j < array.GetLength(1); ++j) {
            Marshal.StructureToPtr(array[i, j], tmp, false);
            tmp = IntPtr.Add(tmp, Marshal.SizeOf<T>());
          }
        }
        handler(len, ptr);
      } finally {
        Marshal.FreeHGlobal(ptr);
      }
    }

    public static void WithIntPtr<T> (T[] array, Action<int, IntPtr> handler) {
      var len = Marshal.SizeOf<T>() * array.Length;
      var ptr = Marshal.AllocHGlobal(len);
      try {
        var tmp = IntPtr.Add(ptr, 0);
        for (var i = 0; i < array.Length; ++i) {
          Marshal.StructureToPtr(array[i], tmp, false);
          tmp = IntPtr.Add(tmp, Marshal.SizeOf<T>());
        };
        handler(len, ptr);
      } finally {
        Marshal.FreeHGlobal(ptr);
      }
    }

    public static void WithIntPtr (Mat4f mat, Action<int, IntPtr> handler) {
      var stride = Marshal.SizeOf<float> ();
      var len = stride * 16;
      var ptr = Marshal.AllocHGlobal(len);
      try {
        Marshal.StructureToPtr(mat.M00, IntPtr.Add(ptr,  0 * stride), false);
        Marshal.StructureToPtr(mat.M01, IntPtr.Add(ptr,  1 * stride), false);
        Marshal.StructureToPtr(mat.M02, IntPtr.Add(ptr,  2 * stride), false);
        Marshal.StructureToPtr(mat.M03, IntPtr.Add(ptr,  3 * stride), false);
        Marshal.StructureToPtr(mat.M10, IntPtr.Add(ptr,  4 * stride), false);
        Marshal.StructureToPtr(mat.M11, IntPtr.Add(ptr,  5 * stride), false);
        Marshal.StructureToPtr(mat.M12, IntPtr.Add(ptr,  6 * stride), false);
        Marshal.StructureToPtr(mat.M13, IntPtr.Add(ptr,  7 * stride), false);
        Marshal.StructureToPtr(mat.M20, IntPtr.Add(ptr,  8 * stride), false);
        Marshal.StructureToPtr(mat.M21, IntPtr.Add(ptr,  9 * stride), false);
        Marshal.StructureToPtr(mat.M22, IntPtr.Add(ptr, 10 * stride), false);
        Marshal.StructureToPtr(mat.M23, IntPtr.Add(ptr, 11 * stride), false);
        Marshal.StructureToPtr(mat.M30, IntPtr.Add(ptr, 12 * stride), false);
        Marshal.StructureToPtr(mat.M31, IntPtr.Add(ptr, 13 * stride), false);
        Marshal.StructureToPtr(mat.M32, IntPtr.Add(ptr, 14 * stride), false);
        Marshal.StructureToPtr(mat.M33, IntPtr.Add(ptr, 15 * stride), false);
        handler(len, ptr);
      } finally {
        Marshal.FreeHGlobal(ptr);
      }
    }

    public static void WithIntPtr (Mat4d mat, Action<int, IntPtr> handler) {
      var stride = Marshal.SizeOf<double> ();
      var len = stride * 16;
      var ptr = Marshal.AllocHGlobal(len);
      try {
        Marshal.StructureToPtr(mat.M00, IntPtr.Add(ptr,  0 * stride), false);
        Marshal.StructureToPtr(mat.M01, IntPtr.Add(ptr,  1 * stride), false);
        Marshal.StructureToPtr(mat.M02, IntPtr.Add(ptr,  2 * stride), false);
        Marshal.StructureToPtr(mat.M03, IntPtr.Add(ptr,  3 * stride), false);
        Marshal.StructureToPtr(mat.M10, IntPtr.Add(ptr,  4 * stride), false);
        Marshal.StructureToPtr(mat.M11, IntPtr.Add(ptr,  5 * stride), false);
        Marshal.StructureToPtr(mat.M12, IntPtr.Add(ptr,  6 * stride), false);
        Marshal.StructureToPtr(mat.M13, IntPtr.Add(ptr,  7 * stride), false);
        Marshal.StructureToPtr(mat.M20, IntPtr.Add(ptr,  8 * stride), false);
        Marshal.StructureToPtr(mat.M21, IntPtr.Add(ptr,  9 * stride), false);
        Marshal.StructureToPtr(mat.M22, IntPtr.Add(ptr, 10 * stride), false);
        Marshal.StructureToPtr(mat.M23, IntPtr.Add(ptr, 11 * stride), false);
        Marshal.StructureToPtr(mat.M30, IntPtr.Add(ptr, 12 * stride), false);
        Marshal.StructureToPtr(mat.M31, IntPtr.Add(ptr, 13 * stride), false);
        Marshal.StructureToPtr(mat.M32, IntPtr.Add(ptr, 14 * stride), false);
        Marshal.StructureToPtr(mat.M33, IntPtr.Add(ptr, 15 * stride), false);
        handler(len, ptr);
      } finally {
        Marshal.FreeHGlobal(ptr);
      }
    }

  }
}

