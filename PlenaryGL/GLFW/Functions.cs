using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Security.Policy;
using System.Threading;

namespace PlenaryGL
{
  public static partial class GLFW
  {
  
    [DllImport("glfw", EntryPoint = "glfwInit")]
    public static extern int Init();

    [DllImport("glfw", EntryPoint = "glfwTerminate")]
    public static extern void Terminate();

    [DllImport("glfw", EntryPoint = "glfwGetVersion")]
    public static extern void GetVersion(out int major, out int minor, out int rev);

    [DllImport("glfw", EntryPoint = "glfwGetVersionString")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static extern string GetVersionString();

    [DllImport("glfw", EntryPoint = "glfwSetErrorCallback")]
    public static extern ErrorCallback SetErrorCallback(ErrorCallback fun);

    [DllImport("glfw", EntryPoint = "glfwGetMonitors")]
    public static extern Monitor[] GetMonitors(out int count);

    [DllImport("glfw", EntryPoint = "glfwGetMonitorPos")]
    public static extern void GetMonitorPos (Monitor monitor, out int xpos, out int ypos);

    [DllImport("glfw", EntryPoint = "glfwGetPhysicalMonitorSize")]
    public static extern void GetPhysicalMonitorSize (Monitor monitor, out int widthMM, out int heightMM);

    [DllImport("glfw", EntryPoint = "glfwGetMonitorName")]
    [return: MarshalAs(UnmanagedType.LPStr)]
    public static extern string GetMonitorName(Monitor monitor);

    [DllImport("glfw", EntryPoint = "glfwCreateWindow")]
    public static extern Window CreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] String title, Monitor monitor, Window window);

  }
}
