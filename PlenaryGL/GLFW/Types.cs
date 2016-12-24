using System;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Security.Policy;
using System.Security.Cryptography;

namespace PlenaryGL
{
  public static partial class GLFW
  {
    public class Monitor {}
    public class Window {}
    public class Cursor {}
    public delegate void ErrorCallback (int error, [MarshalAs(UnmanagedType.LPStr)] string description);
    public delegate void WindowPosCallback (Window window, int xpos, int ypos);
    public delegate void WindowSizeCallback (Window window, int width, int height);
    public delegate void WindowCloseCallback (Window window);
    public delegate void WindowRefreshCallback (Window window);
    public delegate void WindowFocusCallback (Window window, [MarshalAs(UnmanagedType.I4)] bool focused);
    public delegate void WindowIconifyCallback (Window window, [MarshalAs(UnmanagedType.I4)] bool iconified);
    public delegate void FramebufferSizeCallback (Window window, int width, int height);
    public delegate void MouseButtonCallback (Window window, int button, int action, int mods);
    public delegate void CursorPosCallback (Window window, int xpos, int ypos);
    public delegate void CursorEnterCallback (Window window, [MarshalAs(UnmanagedType.I4)] bool entered);
    public delegate void ScrollCallback (Window window, int xoffset, int yoffset);
    public delegate void KeyCallback (Window window, int key, int scancode, int action, int mods);
    public delegate void CharCallback (Window window, uint codepoint);
    public delegate void CharModsCallback (Window window, uint codepoint, int mods);
    public delegate void DropCallback (Window window, int count, [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.LPStr, SizeParamIndex=1)] string[] pathnames);
    public delegate void MonitorCallback (Monitor monitor, [MarshalAs(UnmanagedType.I4)] bool connected);
    public delegate void JoystickCallback (int joystick, int eventType);
    [StructLayout(LayoutKind.Sequential)]
    public struct VideoMode {
      public int width;
      public int height;
      public int redbits;
      public int greenbits;
      public int bluebits;
    }
    public struct GammaRamp {
      [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=4)] public ushort[] red;
      [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=4)] public ushort[] green;
      [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=4)] public ushort[] blue;
      [MarshalAs(UnmanagedType.LPArray, SizeParamIndex=4)] public uint size;
    }
    public unsafe struct Image {
      public int width;
      public int height;
      public byte *pixels;
    }
  }
}
