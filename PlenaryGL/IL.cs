using System;
using System.Runtime.InteropServices;

namespace Plenary.Interop
{
  public static class IL
  {
    
    [DllImport("IL", EntryPoint="ilGenImages") ] public static extern void GenImages(uint num, out uint images);
    [DllImport("IL", EntryPoint="ilDeleteImages") ] public static extern void DeleteImages(uint num, ref uint images);
    [DllImport("IL", EntryPoint="ilBindImage") ] public static extern void BindImage(uint image);

    [DllImport("IL", EntryPoint="ilLoadImage") ] public static extern void LoadImage([MarshalAs(UnmanagedType.LPStr)] string filename);

    [DllImport("IL", EntryPoint="ilGetData") ] public static extern IntPtr GetData();

  }
}
