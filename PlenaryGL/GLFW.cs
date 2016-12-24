using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Security.Policy;

namespace PlenaryGL
{
  public static partial class GLFW
  {
    public class Monitor {
    }
    public class Window {
    }

    [DllImport("glfw", EntryPoint = "glfwCreateWindow")] public static unsafe extern Window CreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] String title, Monitor monitor, Window window);
  }
}
