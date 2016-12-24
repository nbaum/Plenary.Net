using System;
using System.Runtime.InteropServices;

namespace Plenary.Interop
{

    [Flags] public enum InitFlags
    {
        Timer = 0x00000001,
        Audio = 0x00000010,
        Video = 0x00000020,
        Joystick = 0x00000200,
        Haptick = 0x00001000,
        GameController = 0x00002000,
        Events = 0x00004000,
        NoParachute = 0x00100000,
        Everything = Timer | Audio | Video | Events | Joystick | Haptick | GameController
    }

    [Flags] public enum WindowFlags
    {
        Fullscreen = 0x00000001,
        OpenGL = 0x00000002,
        Shown = 0x00000004,
        Hidden = 0x00000008,
        Borderless = 0x00000010,
        Resizable = 0x00000020,
        Minimized = 0x00000040,
        Maximized = 0x00000080,
        InputGrabbed = 0x00000100,
        InputFocus = 0x00000200,
        MouseFocus = 0x00000400,
        Foreign = 0x00000800,
        FullscreenDesktop = 0x00001000 | Fullscreen,
        AllowHighDPI = 0x00002000,
        MouseCapture = 0x00004000
    }

    public enum GLattr
    {
        RedSize,
        GreenSize,
        BlueSize,
        AlphaSize,
        BufferSize,
        Doublebuffer,
        DepthSize,
        StencilSize,
        AccumRedSize,
        AccumGreenSize,
        AccumBlueSize,
        AccumAlphaSize,
        Stereo,
        MultisampleBuffers,
        MultisampleSamples,
        AcceleratedVisual,
        RetainedBacking,
        ContextMajorVersion,
        ContextMinorVersion,
        ContextEGL,
        ContextFlags,
        ContextProfileMask,
        ShareWithCurrentContext,
        FramebufferSRGBCapable,
        ContextReleaseBehaviour
    }

    [Flags] public enum GLprofile : int
    {
        Core = 1,
        Compatibility = 2,
        ES = 4
    }

    [Flags] public enum GLcontextFlag : int
    {
        Debug = 1,
        ForwardCompatible = 2,
        RobustAccess = 4,
        ResetIsolation = 8
    }

    [Flags] public enum GLcontextReleaseBehaviour : int
    {
        None = 0,
        Flush = 1
    }

    [Flags] public enum RendererFlags : uint
    {
        Software = 1,
        Accelerated = 2,
        PresentVSync = 4,
        TargetTexture = 8
    }

    public enum PixelFormats : uint
    {
        UNKNOWN = 0x00000000,
        INDEX1LSB = 0x11100100,
        INDEX1MSB = 0x11200100,
        INDEX4LSB = 0x12100400,
        INDEX4MSB = 0x12200400,
        INDEX8 = 0x13000801,
        RGB332 = 0x14110801,
        RGB444 = 0x15120c02,
        RGB555 = 0x15130f02,
        BGR555 = 0x15530f02,
        ARGB4444 = 0x15321002,
        RGBA4444 = 0x15421002,
        ABGR4444 = 0x15721002,
        BGRA4444 = 0x15821002,
        ARGB1555 = 0x15331002,
        RGBA5551 = 0x15441002,
        ABGR1555 = 0x15731002,
        BGRA5551 = 0x15841002,
        RGB565 = 0x15151002,
        BGR565 = 0x15551002,
        RGB24 = 0x17101803,
        BGR24 = 0x17401803,
        RGB888 = 0x16161804,
        RGBX8888 = 0x16261804,
        BGR888 = 0x16561804,
        BGRX8888 = 0x16661804,
        ARGB8888 = 0x16362004,
        RGBA8888 = 0x16462004,
        ABGR8888 = 0x16762004,
        BGRA8888 = 0x16862004,
        ARGB2101010 = 0x16372004,
        YV12 = 0x32315659,
        IYUV = 0x56555949,
        YUY2 = 0x32595559,
        UYVY = 0x59565955,
        YVYU = 0x55595659
    }

    public static unsafe class SDL
    {

        [DllImport ("SDL2", EntryPoint = "SDL_GetError")] static extern IntPtr getError ();

        public static string GetError ()
        {
            var p = getError ();
            if (p == IntPtr.Zero) {
                return Marshal.PtrToStringAuto (p);
            } else {
                return "No error";
            }
        }

        [DllImport ("SDL2", EntryPoint = "SDL_Init")] public static extern int Init (InitFlags flags);

        [DllImport ("SDL2", EntryPoint = "SDL_CreateWindow")] public static extern IntPtr CreateWindow ([MarshalAs (UnmanagedType.LPStr)] string title, int x, int y, int w, int h, WindowFlags flags);

        [DllImport ("SDL2", EntryPoint = "SDL_ShowWindow")] public static extern void ShowWindow (IntPtr window);

        [DllImport ("SDL2", EntryPoint = "SDL_GL_SwapWindow")] public static extern void GL_SwapWindow (IntPtr window);

        [DllImport ("SDL2", EntryPoint = "SDL_CreateRenderer")] public static extern IntPtr GL_CreateContext (IntPtr window);

        [DllImport ("SDL2", EntryPoint = "SDL_GL_SetAttribute")] public static extern int GL_SetAttribute (GLattr attr, int value);

        [DllImport ("SDL2", EntryPoint = "SDL_GL_SetAttribute")] public static extern int GL_SetAttribute (GLattr attr, GLcontextFlag value);

        [DllImport ("SDL2", EntryPoint = "SDL_GL_SetAttribute")] public static extern int GL_SetAttribute (GLattr attr, GLcontextReleaseBehaviour value);

        [DllImport ("SDL2", EntryPoint = "SDL_GL_SetAttribute")] public static extern int GL_SetAttribute (GLattr attr, GLprofile value);

        [DllImport ("SDL2", EntryPoint = "SDL_GL_SetSwapInterval")] public static extern int GL_SetSwapInterval (int interval);

        [DllImport ("SDL2", EntryPoint = "SDL_Delay")] public static extern void Delay (UInt32 ms);

        [Serializable]
        public struct Surface
        {
            public UInt32 Flags;
            public IntPtr Format;
            public int Width;
            public int Height;
            public int Pitch;
            public IntPtr Pixels;

            public static Surface FromPtr (IntPtr ptr)
            {
                return Marshal.PtrToStructure<Surface> (ptr);
            }
        }

        [Serializable]
        public struct PixelFormat
        {
            public PixelFormats code;
            public IntPtr palette;
            public byte bitsperpixel;
            public byte bytesperpixel;
            public UInt32 rmask, gmask, bmask, amask;
            public static PixelFormat FromPtr (IntPtr ptr)
            {
                return Marshal.PtrToStructure<PixelFormat> (ptr);
            }
        }

        [DllImport ("SDL2_image", EntryPoint = "SDL_FreeSurface")] public static extern void FreeSurface (IntPtr surface);

        [DllImport ("SDL2_image", EntryPoint = "IMG_Load")] public static extern IntPtr LoadImage ([MarshalAs (UnmanagedType.LPStr)] string file);

    }
}
