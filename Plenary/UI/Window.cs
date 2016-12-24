using Plenary.Interop;
using Plenary.OpenGL;
using System;
using System.Runtime.InteropServices;

namespace Plenary.UI
{
    
    public class Window
    {
     
        internal IntPtr SDLWindow;

        delegate void DebugDelegate (uint source, uint type, int id, uint severity, uint length, IntPtr msg, IntPtr param);

        public static void DebugCallback (uint source, uint type, int id, uint severity, uint length, IntPtr msg, IntPtr param)
        {
            var message = Marshal.PtrToStringAnsi (msg, (int)length);
            Console.WriteLine (message);
        }

        public Window ()
        {
            SDL.Init (InitFlags.Video);
            // SDL.GL_SetAttribute (GLattr.MultisampleSamples, 4);
            SDL.GL_SetAttribute (GLattr.ContextMajorVersion, 4);
            SDL.GL_SetAttribute (GLattr.ContextMinorVersion, 5);
            SDL.GL_SetAttribute (GLattr.ContextFlags, GLcontextFlag.Debug);
            SDL.GL_SetAttribute (GLattr.ContextProfileMask, GLprofile.Core);
            SDLWindow = SDL.CreateWindow ("My Test", 0, 0, 1920, 1080, WindowFlags.OpenGL | WindowFlags.Hidden | WindowFlags.FullscreenDesktop);
            SDL.GL_CreateContext (SDLWindow);
            NamedString.ImportDirectory ("Assets/Shaders/Include");
            GL.DebugMessageControl (GL.DONT_CARE, GL.DONT_CARE, GL.DONT_CARE, 0, null, true);
            GL.DebugMessageCallback (Marshal.GetFunctionPointerForDelegate (new DebugDelegate (DebugCallback)), IntPtr.Zero);
            GL.Enable (GL.DEBUG_OUTPUT);
            SDL.GL_SetSwapInterval (1);
        }

        public void Show ()
        {
            SDL.ShowWindow (SDLWindow);
        }

        public void SwapBuffers ()
        {
            SDL.GL_SwapWindow (SDLWindow);
        }

    }

}
