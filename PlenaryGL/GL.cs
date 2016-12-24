using System;
using System.Runtime.InteropServices;

namespace Plenary.OpenGL
{
  
    public static unsafe class GL
    {

        public static void CheckErrors ()
        {
            var err = GL.GetError ();
            if (err == NO_ERROR)
                return;
            else if (err == INVALID_ENUM)
                throw new Exception (String.Format ("INVALID_ENUM"));
            else if (err == INVALID_VALUE)
                throw new Exception (String.Format ("INVALID_VALUE"));
            else if (err == INVALID_OPERATION)
                throw new Exception (String.Format ("INVALID_OPERATION"));
            else if (err == INVALID_FRAMEBUFFER_OPERATION)
                throw new Exception (String.Format ("INVALID_FRAMEBUFFER_OPERATION"));
            else if (err == OUT_OF_MEMORY)
                throw new Exception (String.Format ("OUT_OF_MEMORY"));
            else if (err == STACK_UNDERFLOW)
                throw new Exception (String.Format ("STACK_UNDERFLOW"));
            else if (err != STACK_OVERFLOW)
                throw new Exception (String.Format ("STACK_OVERFLOW", err));
        }

        public const uint ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9;
        public const uint ACTIVE_ATTRIBUTES = 0x8B89;
        public const uint ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A;
        public const uint ACTIVE_PROGRAM = 0x8259;
        public const uint ACTIVE_RESOURCES = 0x92F5;
        public const uint ACTIVE_SUBROUTINES = 0x8DE5;
        public const uint ACTIVE_SUBROUTINE_MAX_LENGTH = 0x8E48;
        public const uint ACTIVE_SUBROUTINE_UNIFORMS = 0x8DE6;
        public const uint ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS = 0x8E47;
        public const uint ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH = 0x8E49;
        public const uint ACTIVE_TEXTURE = 0x84E0;
        public const uint ACTIVE_UNIFORMS = 0x8B86;
        public const uint ACTIVE_UNIFORM_BLOCKS = 0x8A36;
        public const uint ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;
        public const uint ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87;
        public const uint ACTIVE_VARIABLES = 0x9305;
        public const uint ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const uint ALL_BARRIER_BITS = 0xFFFFFFFF;
        public const uint ALL_SHADER_BITS = 0xFFFFFFFF;
        public const uint ALPHA = 0x1906;
        public const uint ALREADY_SIGNALED = 0x911A;
        public const uint ALWAYS = 0x0207;
        public const uint AND = 0x1501;
        public const uint AND_INVERTED = 0x1504;
        public const uint AND_REVERSE = 0x1502;
        public const uint ANY_SAMPLES_PASSED = 0x8C2F;
        public const uint ANY_SAMPLES_PASSED_CONSERVATIVE = 0x8D6A;
        public const uint ARRAY_BUFFER = 0x8892;
        public const uint ARRAY_BUFFER_BINDING = 0x8894;
        public const uint ARRAY_SIZE = 0x92FB;
        public const uint ARRAY_STRIDE = 0x92FE;
        public const uint ATOMIC_COUNTER_BARRIER_BIT = 0x00001000;
        public const uint ATOMIC_COUNTER_BUFFER = 0x92C0;
        public const uint ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5;
        public const uint ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6;
        public const uint ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1;
        public const uint ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4;
        public const uint ATOMIC_COUNTER_BUFFER_INDEX = 0x9301;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9;
        public const uint ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7;
        public const uint ATOMIC_COUNTER_BUFFER_SIZE = 0x92C3;
        public const uint ATOMIC_COUNTER_BUFFER_START = 0x92C2;
        public const uint ATTACHED_SHADERS = 0x8B85;
        public const uint AUTO_GENERATE_MIPMAP = 0x8295;
        public const uint BACK = 0x0405;
        public const uint BACK_LEFT = 0x0402;
        public const uint BACK_RIGHT = 0x0403;
        public const uint BGR = 0x80E0;
        public const uint BGRA = 0x80E1;
        public const uint BGRA_INTEGER = 0x8D9B;
        public const uint BGR_INTEGER = 0x8D9A;
        public const uint BLEND = 0x0BE2;
        public const uint BLEND_DST = 0x0BE0;
        public const uint BLEND_DST_ALPHA = 0x80CA;
        public const uint BLEND_DST_RGB = 0x80C8;
        public const uint BLEND_EQUATION_ALPHA = 0x883D;
        public const uint BLEND_EQUATION_RGB = 0x8009;
        public const uint BLEND_SRC = 0x0BE1;
        public const uint BLEND_SRC_ALPHA = 0x80CB;
        public const uint BLEND_SRC_RGB = 0x80C9;
        public const uint BLOCK_INDEX = 0x92FD;
        public const uint BLUE = 0x1905;
        public const uint BLUE_INTEGER = 0x8D96;
        public const uint BOOL = 0x8B56;
        public const uint BOOL_VEC2 = 0x8B57;
        public const uint BOOL_VEC3 = 0x8B58;
        public const uint BOOL_VEC4 = 0x8B59;
        public const uint BUFFER = 0x82E0;
        public const uint BUFFER_ACCESS = 0x88BB;
        public const uint BUFFER_ACCESS_FLAGS = 0x911F;
        public const uint BUFFER_BINDING = 0x9302;
        public const uint BUFFER_DATA_SIZE = 0x9303;
        public const uint BUFFER_IMMUTABLE_STORAGE = 0x821F;
        public const uint BUFFER_MAPPED = 0x88BC;
        public const uint BUFFER_MAP_LENGTH = 0x9120;
        public const uint BUFFER_MAP_OFFSET = 0x9121;
        public const uint BUFFER_MAP_POINTER = 0x88BD;
        public const uint BUFFER_SIZE = 0x8764;
        public const uint BUFFER_STORAGE_FLAGS = 0x8220;
        public const uint BUFFER_UPDATE_BARRIER_BIT = 0x00000200;
        public const uint BUFFER_USAGE = 0x8765;
        public const uint BUFFER_VARIABLE = 0x92E5;
        public const uint BYTE = 0x1400;
        public const uint CAVEAT_SUPPORT = 0x82B8;
        public const uint CCW = 0x0901;
        public const uint CLAMP_READ_COLOR = 0x891C;
        public const uint CLAMP_TO_BORDER = 0x812D;
        public const uint CLAMP_TO_EDGE = 0x812F;
        public const uint CLEAR = 0x1500;
        public const uint CLEAR_BUFFER = 0x82B4;
        public const uint CLEAR_TEXTURE = 0x9365;
        public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;
        public const uint CLIENT_STORAGE_BIT = 0x0200;
        public const uint CLIP_DEPTH_MODE = 0x935D;
        public const uint CLIP_DISTANCE0 = 0x3000;
        public const uint CLIP_DISTANCE1 = 0x3001;
        public const uint CLIP_DISTANCE2 = 0x3002;
        public const uint CLIP_DISTANCE3 = 0x3003;
        public const uint CLIP_DISTANCE4 = 0x3004;
        public const uint CLIP_DISTANCE5 = 0x3005;
        public const uint CLIP_DISTANCE6 = 0x3006;
        public const uint CLIP_DISTANCE7 = 0x3007;
        public const uint CLIP_ORIGIN = 0x935C;
        public const uint COLOR = 0x1800;
        public const uint COLOR_ATTACHMENT0 = 0x8CE0;
        public const uint COLOR_ATTACHMENT1 = 0x8CE1;
        public const uint COLOR_ATTACHMENT10 = 0x8CEA;
        public const uint COLOR_ATTACHMENT11 = 0x8CEB;
        public const uint COLOR_ATTACHMENT12 = 0x8CEC;
        public const uint COLOR_ATTACHMENT13 = 0x8CED;
        public const uint COLOR_ATTACHMENT14 = 0x8CEE;
        public const uint COLOR_ATTACHMENT15 = 0x8CEF;
        public const uint COLOR_ATTACHMENT16 = 0x8CF0;
        public const uint COLOR_ATTACHMENT17 = 0x8CF1;
        public const uint COLOR_ATTACHMENT18 = 0x8CF2;
        public const uint COLOR_ATTACHMENT19 = 0x8CF3;
        public const uint COLOR_ATTACHMENT2 = 0x8CE2;
        public const uint COLOR_ATTACHMENT20 = 0x8CF4;
        public const uint COLOR_ATTACHMENT21 = 0x8CF5;
        public const uint COLOR_ATTACHMENT22 = 0x8CF6;
        public const uint COLOR_ATTACHMENT23 = 0x8CF7;
        public const uint COLOR_ATTACHMENT24 = 0x8CF8;
        public const uint COLOR_ATTACHMENT25 = 0x8CF9;
        public const uint COLOR_ATTACHMENT26 = 0x8CFA;
        public const uint COLOR_ATTACHMENT27 = 0x8CFB;
        public const uint COLOR_ATTACHMENT28 = 0x8CFC;
        public const uint COLOR_ATTACHMENT29 = 0x8CFD;
        public const uint COLOR_ATTACHMENT3 = 0x8CE3;
        public const uint COLOR_ATTACHMENT30 = 0x8CFE;
        public const uint COLOR_ATTACHMENT31 = 0x8CFF;
        public const uint COLOR_ATTACHMENT4 = 0x8CE4;
        public const uint COLOR_ATTACHMENT5 = 0x8CE5;
        public const uint COLOR_ATTACHMENT6 = 0x8CE6;
        public const uint COLOR_ATTACHMENT7 = 0x8CE7;
        public const uint COLOR_ATTACHMENT8 = 0x8CE8;
        public const uint COLOR_ATTACHMENT9 = 0x8CE9;
        public const uint COLOR_BUFFER_BIT = 0x00004000;
        public const uint COLOR_CLEAR_VALUE = 0x0C22;
        public const uint COLOR_COMPONENTS = 0x8283;
        public const uint COLOR_ENCODING = 0x8296;
        public const uint COLOR_LOGIC_OP = 0x0BF2;
        public const uint COLOR_RENDERABLE = 0x8286;
        public const uint COLOR_WRITEMASK = 0x0C23;
        public const uint COMMAND_BARRIER_BIT = 0x00000040;
        public const uint COMPARE_REF_TO_TEXTURE = 0x884E;
        public const uint COMPATIBLE_SUBROUTINES = 0x8E4B;
        public const uint COMPILE_STATUS = 0x8B81;
        public const uint COMPRESSED_R11_EAC = 0x9270;
        public const uint COMPRESSED_RED = 0x8225;
        public const uint COMPRESSED_RED_RGTC1 = 0x8DBB;
        public const uint COMPRESSED_RG = 0x8226;
        public const uint COMPRESSED_RG11_EAC = 0x9272;
        public const uint COMPRESSED_RGB = 0x84ED;
        public const uint COMPRESSED_RGB8_ETC2 = 0x9274;
        public const uint COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276;
        public const uint COMPRESSED_RGBA = 0x84EE;
        public const uint COMPRESSED_RGBA8_ETC2_EAC = 0x9278;
        public const uint COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C;
        public const uint COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E;
        public const uint COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F;
        public const uint COMPRESSED_RG_RGTC2 = 0x8DBD;
        public const uint COMPRESSED_SIGNED_R11_EAC = 0x9271;
        public const uint COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;
        public const uint COMPRESSED_SIGNED_RG11_EAC = 0x9273;
        public const uint COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;
        public const uint COMPRESSED_SRGB = 0x8C48;
        public const uint COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279;
        public const uint COMPRESSED_SRGB8_ETC2 = 0x9275;
        public const uint COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277;
        public const uint COMPRESSED_SRGB_ALPHA = 0x8C49;
        public const uint COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D;
        public const uint COMPRESSED_TEXTURE_FORMATS = 0x86A3;
        public const uint COMPUTE_SHADER = 0x91B9;
        public const uint COMPUTE_SHADER_BIT = 0x00000020;
        public const uint COMPUTE_SUBROUTINE = 0x92ED;
        public const uint COMPUTE_SUBROUTINE_UNIFORM = 0x92F3;
        public const uint COMPUTE_TEXTURE = 0x82A0;
        public const uint COMPUTE_WORK_GROUP_SIZE = 0x8267;
        public const uint CONDITION_SATISFIED = 0x911C;
        public const uint CONSTANT_ALPHA = 0x8003;
        public const uint CONSTANT_COLOR = 0x8001;
        public const uint CONTEXT_COMPATIBILITY_PROFILE_BIT = 0x00000002;
        public const uint CONTEXT_CORE_PROFILE_BIT = 0x00000001;
        public const uint CONTEXT_FLAGS = 0x821E;
        public const uint CONTEXT_FLAG_DEBUG_BIT = 0x00000002;
        public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;
        public const uint CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004;
        public const uint CONTEXT_LOST = 0x0507;
        public const uint CONTEXT_PROFILE_MASK = 0x9126;
        public const uint CONTEXT_RELEASE_BEHAVIOR = 0x82FB;
        public const uint CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x82FC;
        public const uint COPY = 0x1503;
        public const uint COPY_INVERTED = 0x150C;
        public const uint COPY_READ_BUFFER = 0x8F36;
        public const uint COPY_READ_BUFFER_BINDING = 0x8F36;
        public const uint COPY_WRITE_BUFFER = 0x8F37;
        public const uint COPY_WRITE_BUFFER_BINDING = 0x8F37;
        public const uint CULL_FACE = 0x0B44;
        public const uint CULL_FACE_MODE = 0x0B45;
        public const uint CURRENT_PROGRAM = 0x8B8D;
        public const uint CURRENT_QUERY = 0x8865;
        public const uint CURRENT_VERTEX_ATTRIB = 0x8626;
        public const uint CW = 0x0900;
        public const uint DEBUG_CALLBACK_FUNCTION = 0x8244;
        public const uint DEBUG_CALLBACK_USER_PARAM = 0x8245;
        public const uint DEBUG_GROUP_STACK_DEPTH = 0x826D;
        public const uint DEBUG_LOGGED_MESSAGES = 0x9145;
        public const uint DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243;
        public const uint DEBUG_OUTPUT = 0x92E0;
        public const uint DEBUG_OUTPUT_SYNCHRONOUS = 0x8242;
        public const uint DEBUG_SEVERITY_HIGH = 0x9146;
        public const uint DEBUG_SEVERITY_LOW = 0x9148;
        public const uint DEBUG_SEVERITY_MEDIUM = 0x9147;
        public const uint DEBUG_SEVERITY_NOTIFICATION = 0x826B;
        public const uint DEBUG_SOURCE_API = 0x8246;
        public const uint DEBUG_SOURCE_APPLICATION = 0x824A;
        public const uint DEBUG_SOURCE_OTHER = 0x824B;
        public const uint DEBUG_SOURCE_SHADER_COMPILER = 0x8248;
        public const uint DEBUG_SOURCE_THIRD_PARTY = 0x8249;
        public const uint DEBUG_SOURCE_WINDOW_SYSTEM = 0x8247;
        public const uint DEBUG_TYPE_DEPRECATED_BEHAVIOR = 0x824D;
        public const uint DEBUG_TYPE_ERROR = 0x824C;
        public const uint DEBUG_TYPE_MARKER = 0x8268;
        public const uint DEBUG_TYPE_OTHER = 0x8251;
        public const uint DEBUG_TYPE_PERFORMANCE = 0x8250;
        public const uint DEBUG_TYPE_POP_GROUP = 0x826A;
        public const uint DEBUG_TYPE_PORTABILITY = 0x824F;
        public const uint DEBUG_TYPE_PUSH_GROUP = 0x8269;
        public const uint DEBUG_TYPE_UNDEFINED_BEHAVIOR = 0x824E;
        public const uint DECR = 0x1E03;
        public const uint DECR_WRAP = 0x8508;
        public const uint DELETE_STATUS = 0x8B80;
        public const uint DEPTH = 0x1801;
        public const uint DEPTH24_STENCIL8 = 0x88F0;
        public const uint DEPTH32F_STENCIL8 = 0x8CAD;
        public const uint DEPTH_ATTACHMENT = 0x8D00;
        public const uint DEPTH_BUFFER_BIT = 0x00000100;
        public const uint DEPTH_CLAMP = 0x864F;
        public const uint DEPTH_CLEAR_VALUE = 0x0B73;
        public const uint DEPTH_COMPONENT = 0x1902;
        public const uint DEPTH_COMPONENT16 = 0x81A5;
        public const uint DEPTH_COMPONENT24 = 0x81A6;
        public const uint DEPTH_COMPONENT32 = 0x81A7;
        public const uint DEPTH_COMPONENT32F = 0x8CAC;
        public const uint DEPTH_COMPONENTS = 0x8284;
        public const uint DEPTH_FUNC = 0x0B74;
        public const uint DEPTH_RANGE = 0x0B70;
        public const uint DEPTH_RENDERABLE = 0x8287;
        public const uint DEPTH_STENCIL = 0x84F9;
        public const uint DEPTH_STENCIL_ATTACHMENT = 0x821A;
        public const uint DEPTH_STENCIL_TEXTURE_MODE = 0x90EA;
        public const uint DEPTH_TEST = 0x0B71;
        public const uint DEPTH_WRITEMASK = 0x0B72;
        public const uint DISPATCH_INDIRECT_BUFFER = 0x90EE;
        public const uint DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF;
        public const uint DISPLAY_LIST = 0x82E7;
        public const uint DITHER = 0x0BD0;
        public const uint DONT_CARE = 0x1100;
        public const uint DOUBLE = 0x140A;
        public const uint DOUBLEBUFFER = 0x0C32;
        public const uint DOUBLE_MAT2 = 0x8F46;
        public const uint DOUBLE_MAT2x3 = 0x8F49;
        public const uint DOUBLE_MAT2x4 = 0x8F4A;
        public const uint DOUBLE_MAT3 = 0x8F47;
        public const uint DOUBLE_MAT3x2 = 0x8F4B;
        public const uint DOUBLE_MAT3x4 = 0x8F4C;
        public const uint DOUBLE_MAT4 = 0x8F48;
        public const uint DOUBLE_MAT4x2 = 0x8F4D;
        public const uint DOUBLE_MAT4x3 = 0x8F4E;
        public const uint DOUBLE_VEC2 = 0x8FFC;
        public const uint DOUBLE_VEC3 = 0x8FFD;
        public const uint DOUBLE_VEC4 = 0x8FFE;
        public const uint DRAW_BUFFER = 0x0C01;
        public const uint DRAW_BUFFER0 = 0x8825;
        public const uint DRAW_BUFFER1 = 0x8826;
        public const uint DRAW_BUFFER10 = 0x882F;
        public const uint DRAW_BUFFER11 = 0x8830;
        public const uint DRAW_BUFFER12 = 0x8831;
        public const uint DRAW_BUFFER13 = 0x8832;
        public const uint DRAW_BUFFER14 = 0x8833;
        public const uint DRAW_BUFFER15 = 0x8834;
        public const uint DRAW_BUFFER2 = 0x8827;
        public const uint DRAW_BUFFER3 = 0x8828;
        public const uint DRAW_BUFFER4 = 0x8829;
        public const uint DRAW_BUFFER5 = 0x882A;
        public const uint DRAW_BUFFER6 = 0x882B;
        public const uint DRAW_BUFFER7 = 0x882C;
        public const uint DRAW_BUFFER8 = 0x882D;
        public const uint DRAW_BUFFER9 = 0x882E;
        public const uint DRAW_FRAMEBUFFER = 0x8CA9;
        public const uint DRAW_FRAMEBUFFER_BINDING = 0x8CA6;
        public const uint DRAW_INDIRECT_BUFFER = 0x8F3F;
        public const uint DRAW_INDIRECT_BUFFER_BINDING = 0x8F43;
        public const uint DST_ALPHA = 0x0304;
        public const uint DST_COLOR = 0x0306;
        public const uint DYNAMIC_COPY = 0x88EA;
        public const uint DYNAMIC_DRAW = 0x88E8;
        public const uint DYNAMIC_READ = 0x88E9;
        public const uint DYNAMIC_STORAGE_BIT = 0x0100;
        public const uint ELEMENT_ARRAY_BARRIER_BIT = 0x00000002;
        public const uint ELEMENT_ARRAY_BUFFER = 0x8893;
        public const uint ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;
        public const uint EQUAL = 0x0202;
        public const uint EQUIV = 0x1509;
        public const uint EXTENSIONS = 0x1F03;
        public const uint FALSE = 0;
        public const uint FASTEST = 0x1101;
        public const uint FILL = 0x1B02;
        public const uint FILTER = 0x829A;
        public const uint FIRST_VERTEX_CONVENTION = 0x8E4D;
        public const uint FIXED = 0x140C;
        public const uint FIXED_ONLY = 0x891D;
        public const uint FLOAT = 0x1406;
        public const uint FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;
        public const uint FLOAT_MAT2 = 0x8B5A;
        public const uint FLOAT_MAT2x3 = 0x8B65;
        public const uint FLOAT_MAT2x4 = 0x8B66;
        public const uint FLOAT_MAT3 = 0x8B5B;
        public const uint FLOAT_MAT3x2 = 0x8B67;
        public const uint FLOAT_MAT3x4 = 0x8B68;
        public const uint FLOAT_MAT4 = 0x8B5C;
        public const uint FLOAT_MAT4x2 = 0x8B69;
        public const uint FLOAT_MAT4x3 = 0x8B6A;
        public const uint FLOAT_VEC2 = 0x8B50;
        public const uint FLOAT_VEC3 = 0x8B51;
        public const uint FLOAT_VEC4 = 0x8B52;
        public const uint FRACTIONAL_EVEN = 0x8E7C;
        public const uint FRACTIONAL_ODD = 0x8E7B;
        public const uint FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D;
        public const uint FRAGMENT_SHADER = 0x8B30;
        public const uint FRAGMENT_SHADER_BIT = 0x00000002;
        public const uint FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B;
        public const uint FRAGMENT_SUBROUTINE = 0x92EC;
        public const uint FRAGMENT_SUBROUTINE_UNIFORM = 0x92F2;
        public const uint FRAGMENT_TEXTURE = 0x829F;
        public const uint FRAMEBUFFER = 0x8D40;
        public const uint FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;
        public const uint FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;
        public const uint FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;
        public const uint FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;
        public const uint FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;
        public const uint FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;
        public const uint FRAMEBUFFER_ATTACHMENT_LAYERED = 0x8DA7;
        public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;
        public const uint FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;
        public const uint FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;
        public const uint FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;
        public const uint FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;
        public const uint FRAMEBUFFER_BARRIER_BIT = 0x00000400;
        public const uint FRAMEBUFFER_BINDING = 0x8CA6;
        public const uint FRAMEBUFFER_BLEND = 0x828B;
        public const uint FRAMEBUFFER_COMPLETE = 0x8CD5;
        public const uint FRAMEBUFFER_DEFAULT = 0x8218;
        public const uint FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314;
        public const uint FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311;
        public const uint FRAMEBUFFER_DEFAULT_LAYERS = 0x9312;
        public const uint FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313;
        public const uint FRAMEBUFFER_DEFAULT_WIDTH = 0x9310;
        public const uint FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;
        public const uint FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;
        public const uint FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8;
        public const uint FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;
        public const uint FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;
        public const uint FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;
        public const uint FRAMEBUFFER_RENDERABLE = 0x8289;
        public const uint FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A;
        public const uint FRAMEBUFFER_SRGB = 0x8DB9;
        public const uint FRAMEBUFFER_UNDEFINED = 0x8219;
        public const uint FRAMEBUFFER_UNSUPPORTED = 0x8CDD;
        public const uint FRONT = 0x0404;
        public const uint FRONT_AND_BACK = 0x0408;
        public const uint FRONT_FACE = 0x0B46;
        public const uint FRONT_LEFT = 0x0400;
        public const uint FRONT_RIGHT = 0x0401;
        public const uint FULL_SUPPORT = 0x82B7;
        public const uint FUNC_ADD = 0x8006;
        public const uint FUNC_REVERSE_SUBTRACT = 0x800B;
        public const uint FUNC_SUBTRACT = 0x800A;
        public const uint GEOMETRY_INPUT_TYPE = 0x8917;
        public const uint GEOMETRY_OUTPUT_TYPE = 0x8918;
        public const uint GEOMETRY_SHADER = 0x8DD9;
        public const uint GEOMETRY_SHADER_BIT = 0x00000004;
        public const uint GEOMETRY_SHADER_INVOCATIONS = 0x887F;
        public const uint GEOMETRY_SUBROUTINE = 0x92EB;
        public const uint GEOMETRY_SUBROUTINE_UNIFORM = 0x92F1;
        public const uint GEOMETRY_TEXTURE = 0x829E;
        public const uint GEOMETRY_VERTICES_OUT = 0x8916;
        public const uint GEQUAL = 0x0206;
        public const uint GET_TEXTURE_IMAGE_FORMAT = 0x8291;
        public const uint GET_TEXTURE_IMAGE_TYPE = 0x8292;
        public const uint GREATER = 0x0204;
        public const uint GREEN = 0x1904;
        public const uint GREEN_INTEGER = 0x8D95;
        public const uint GUILTY_CONTEXT_RESET = 0x8253;
        public const uint HALF_FLOAT = 0x140B;
        public const uint HIGH_FLOAT = 0x8DF2;
        public const uint HIGH_INT = 0x8DF5;
        public const uint IMAGE_1D = 0x904C;
        public const uint IMAGE_1D_ARRAY = 0x9052;
        public const uint IMAGE_2D = 0x904D;
        public const uint IMAGE_2D_ARRAY = 0x9053;
        public const uint IMAGE_2D_MULTISAMPLE = 0x9055;
        public const uint IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056;
        public const uint IMAGE_2D_RECT = 0x904F;
        public const uint IMAGE_3D = 0x904E;
        public const uint IMAGE_BINDING_ACCESS = 0x8F3E;
        public const uint IMAGE_BINDING_FORMAT = 0x906E;
        public const uint IMAGE_BINDING_LAYER = 0x8F3D;
        public const uint IMAGE_BINDING_LAYERED = 0x8F3C;
        public const uint IMAGE_BINDING_LEVEL = 0x8F3B;
        public const uint IMAGE_BINDING_NAME = 0x8F3A;
        public const uint IMAGE_BUFFER = 0x9051;
        public const uint IMAGE_CLASS_10_10_10_2 = 0x82C3;
        public const uint IMAGE_CLASS_11_11_10 = 0x82C2;
        public const uint IMAGE_CLASS_1_X_16 = 0x82BE;
        public const uint IMAGE_CLASS_1_X_32 = 0x82BB;
        public const uint IMAGE_CLASS_1_X_8 = 0x82C1;
        public const uint IMAGE_CLASS_2_X_16 = 0x82BD;
        public const uint IMAGE_CLASS_2_X_32 = 0x82BA;
        public const uint IMAGE_CLASS_2_X_8 = 0x82C0;
        public const uint IMAGE_CLASS_4_X_16 = 0x82BC;
        public const uint IMAGE_CLASS_4_X_32 = 0x82B9;
        public const uint IMAGE_CLASS_4_X_8 = 0x82BF;
        public const uint IMAGE_COMPATIBILITY_CLASS = 0x82A8;
        public const uint IMAGE_CUBE = 0x9050;
        public const uint IMAGE_CUBE_MAP_ARRAY = 0x9054;
        public const uint IMAGE_FORMAT_COMPATIBILITY_BY_CLASS = 0x90C9;
        public const uint IMAGE_FORMAT_COMPATIBILITY_BY_SIZE = 0x90C8;
        public const uint IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7;
        public const uint IMAGE_PIXEL_FORMAT = 0x82A9;
        public const uint IMAGE_PIXEL_TYPE = 0x82AA;
        public const uint IMAGE_TEXEL_SIZE = 0x82A7;
        public const uint IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;
        public const uint IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;
        public const uint INCR = 0x1E02;
        public const uint INCR_WRAP = 0x8507;
        public const uint INDEX = 0x8222;
        public const uint INFO_LOG_LENGTH = 0x8B84;
        public const uint INNOCENT_CONTEXT_RESET = 0x8254;
        public const uint INT = 0x1404;
        public const uint INTERLEAVED_ATTRIBS = 0x8C8C;
        public const uint INTERNALFORMAT_ALPHA_SIZE = 0x8274;
        public const uint INTERNALFORMAT_ALPHA_TYPE = 0x827B;
        public const uint INTERNALFORMAT_BLUE_SIZE = 0x8273;
        public const uint INTERNALFORMAT_BLUE_TYPE = 0x827A;
        public const uint INTERNALFORMAT_DEPTH_SIZE = 0x8275;
        public const uint INTERNALFORMAT_DEPTH_TYPE = 0x827C;
        public const uint INTERNALFORMAT_GREEN_SIZE = 0x8272;
        public const uint INTERNALFORMAT_GREEN_TYPE = 0x8279;
        public const uint INTERNALFORMAT_PREFERRED = 0x8270;
        public const uint INTERNALFORMAT_RED_SIZE = 0x8271;
        public const uint INTERNALFORMAT_RED_TYPE = 0x8278;
        public const uint INTERNALFORMAT_SHARED_SIZE = 0x8277;
        public const uint INTERNALFORMAT_STENCIL_SIZE = 0x8276;
        public const uint INTERNALFORMAT_STENCIL_TYPE = 0x827D;
        public const uint INTERNALFORMAT_SUPPORTED = 0x826F;
        public const uint INT_2_10_10_10_REV = 0x8D9F;
        public const uint INT_IMAGE_1D = 0x9057;
        public const uint INT_IMAGE_1D_ARRAY = 0x905D;
        public const uint INT_IMAGE_2D = 0x9058;
        public const uint INT_IMAGE_2D_ARRAY = 0x905E;
        public const uint INT_IMAGE_2D_MULTISAMPLE = 0x9060;
        public const uint INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061;
        public const uint INT_IMAGE_2D_RECT = 0x905A;
        public const uint INT_IMAGE_3D = 0x9059;
        public const uint INT_IMAGE_BUFFER = 0x905C;
        public const uint INT_IMAGE_CUBE = 0x905B;
        public const uint INT_IMAGE_CUBE_MAP_ARRAY = 0x905F;
        public const uint INT_SAMPLER_1D = 0x8DC9;
        public const uint INT_SAMPLER_1D_ARRAY = 0x8DCE;
        public const uint INT_SAMPLER_2D = 0x8DCA;
        public const uint INT_SAMPLER_2D_ARRAY = 0x8DCF;
        public const uint INT_SAMPLER_2D_MULTISAMPLE = 0x9109;
        public const uint INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C;
        public const uint INT_SAMPLER_2D_RECT = 0x8DCD;
        public const uint INT_SAMPLER_3D = 0x8DCB;
        public const uint INT_SAMPLER_BUFFER = 0x8DD0;
        public const uint INT_SAMPLER_CUBE = 0x8DCC;
        public const uint INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E;
        public const uint INT_VEC2 = 0x8B53;
        public const uint INT_VEC3 = 0x8B54;
        public const uint INT_VEC4 = 0x8B55;
        public const uint INVALID_ENUM = 0x0500;
        public const uint INVALID_FRAMEBUFFER_OPERATION = 0x0506;
        public const uint INVALID_INDEX = 0xFFFFFFFF;
        public const uint INVALID_OPERATION = 0x0502;
        public const uint INVALID_VALUE = 0x0501;
        public const uint INVERT = 0x150A;
        public const uint ISOLINES = 0x8E7A;
        public const uint IS_PER_PATCH = 0x92E7;
        public const uint IS_ROW_MAJOR = 0x9300;
        public const uint KEEP = 0x1E00;
        public const uint LAST_VERTEX_CONVENTION = 0x8E4E;
        public const uint LAYER_PROVOKING_VERTEX = 0x825E;
        public const uint LEFT = 0x0406;
        public const uint LEQUAL = 0x0203;
        public const uint LESS = 0x0201;
        public const uint LINE = 0x1B01;
        public const uint LINEAR = 0x2601;
        public const uint LINEAR_MIPMAP_LINEAR = 0x2703;
        public const uint LINEAR_MIPMAP_NEAREST = 0x2701;
        public const uint LINES = 0x0001;
        public const uint LINES_ADJACENCY = 0x000A;
        public const uint LINE_LOOP = 0x0002;
        public const uint LINE_SMOOTH = 0x0B20;
        public const uint LINE_SMOOTH_HINT = 0x0C52;
        public const uint LINE_STRIP = 0x0003;
        public const uint LINE_STRIP_ADJACENCY = 0x000B;
        public const uint LINE_WIDTH = 0x0B21;
        public const uint LINE_WIDTH_GRANULARITY = 0x0B23;
        public const uint LINE_WIDTH_RANGE = 0x0B22;
        public const uint LINK_STATUS = 0x8B82;
        public const uint LOCATION = 0x930E;
        public const uint LOCATION_COMPONENT = 0x934A;
        public const uint LOCATION_INDEX = 0x930F;
        public const uint LOGIC_OP_MODE = 0x0BF0;
        public const uint LOSE_CONTEXT_ON_RESET = 0x8252;
        public const uint LOWER_LEFT = 0x8CA1;
        public const uint LOW_FLOAT = 0x8DF0;
        public const uint LOW_INT = 0x8DF3;
        public const uint MAJOR_VERSION = 0x821B;
        public const uint MANUAL_GENERATE_MIPMAP = 0x8294;
        public const uint MAP_COHERENT_BIT = 0x0080;
        public const uint MAP_FLUSH_EXPLICIT_BIT = 0x0010;
        public const uint MAP_INVALIDATE_BUFFER_BIT = 0x0008;
        public const uint MAP_INVALIDATE_RANGE_BIT = 0x0004;
        public const uint MAP_PERSISTENT_BIT = 0x0040;
        public const uint MAP_READ_BIT = 0x0001;
        public const uint MAP_UNSYNCHRONIZED_BIT = 0x0020;
        public const uint MAP_WRITE_BIT = 0x0002;
        public const uint MATRIX_STRIDE = 0x92FF;
        public const uint MAX = 0x8008;
        public const uint MAX_3D_TEXTURE_SIZE = 0x8073;
        public const uint MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;
        public const uint MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC;
        public const uint MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8;
        public const uint MAX_CLIP_DISTANCES = 0x0D32;
        public const uint MAX_COLOR_ATTACHMENTS = 0x8CDF;
        public const uint MAX_COLOR_TEXTURE_SAMPLES = 0x910E;
        public const uint MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7;
        public const uint MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1;
        public const uint MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA;
        public const uint MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266;
        public const uint MAX_COMBINED_DIMENSIONS = 0x8282;
        public const uint MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;
        public const uint MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;
        public const uint MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF;
        public const uint MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS = 0x8F39;
        public const uint MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39;
        public const uint MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC;
        public const uint MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E;
        public const uint MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F;
        public const uint MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D;
        public const uint MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;
        public const uint MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;
        public const uint MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265;
        public const uint MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264;
        public const uint MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD;
        public const uint MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB;
        public const uint MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262;
        public const uint MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC;
        public const uint MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB;
        public const uint MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263;
        public const uint MAX_COMPUTE_WORK_GROUP_COUNT = 0x91BE;
        public const uint MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB;
        public const uint MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF;
        public const uint MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
        public const uint MAX_CULL_DISTANCES = 0x82F9;
        public const uint MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C;
        public const uint MAX_DEBUG_LOGGED_MESSAGES = 0x9144;
        public const uint MAX_DEBUG_MESSAGE_LENGTH = 0x9143;
        public const uint MAX_DEPTH = 0x8280;
        public const uint MAX_DEPTH_TEXTURE_SAMPLES = 0x910F;
        public const uint MAX_DRAW_BUFFERS = 0x8824;
        public const uint MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC;
        public const uint MAX_ELEMENTS_INDICES = 0x80E9;
        public const uint MAX_ELEMENTS_VERTICES = 0x80E8;
        public const uint MAX_ELEMENT_INDEX = 0x8D6B;
        public const uint MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6;
        public const uint MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0;
        public const uint MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE;
        public const uint MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125;
        public const uint MAX_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5C;
        public const uint MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA;
        public const uint MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;
        public const uint MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49;
        public const uint MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;
        public const uint MAX_FRAMEBUFFER_HEIGHT = 0x9316;
        public const uint MAX_FRAMEBUFFER_LAYERS = 0x9317;
        public const uint MAX_FRAMEBUFFER_SAMPLES = 0x9318;
        public const uint MAX_FRAMEBUFFER_WIDTH = 0x9315;
        public const uint MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5;
        public const uint MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF;
        public const uint MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD;
        public const uint MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123;
        public const uint MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124;
        public const uint MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0;
        public const uint MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A;
        public const uint MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7;
        public const uint MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29;
        public const uint MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1;
        public const uint MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;
        public const uint MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF;
        public const uint MAX_HEIGHT = 0x827F;
        public const uint MAX_IMAGE_SAMPLES = 0x906D;
        public const uint MAX_IMAGE_UNITS = 0x8F38;
        public const uint MAX_INTEGER_SAMPLES = 0x9110;
        public const uint MAX_LABEL_LENGTH = 0x82E8;
        public const uint MAX_LAYERS = 0x8281;
        public const uint MAX_NAME_LENGTH = 0x92F6;
        public const uint MAX_NUM_ACTIVE_VARIABLES = 0x92F7;
        public const uint MAX_NUM_COMPATIBLE_SUBROUTINES = 0x92F8;
        public const uint MAX_PATCH_VERTICES = 0x8E7D;
        public const uint MAX_PROGRAM_TEXEL_OFFSET = 0x8905;
        public const uint MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F;
        public const uint MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;
        public const uint MAX_RENDERBUFFER_SIZE = 0x84E8;
        public const uint MAX_SAMPLES = 0x8D57;
        public const uint MAX_SAMPLE_MASK_WORDS = 0x8E59;
        public const uint MAX_SERVER_WAIT_TIMEOUT = 0x9111;
        public const uint MAX_SHADER_STORAGE_BLOCK_SIZE = 0x90DE;
        public const uint MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD;
        public const uint MAX_SUBROUTINES = 0x8DE7;
        public const uint MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8;
        public const uint MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3;
        public const uint MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD;
        public const uint MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB;
        public const uint MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C;
        public const uint MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83;
        public const uint MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8;
        public const uint MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81;
        public const uint MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85;
        public const uint MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89;
        public const uint MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F;
        public const uint MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4;
        public const uint MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE;
        public const uint MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC;
        public const uint MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D;
        public const uint MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86;
        public const uint MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9;
        public const uint MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82;
        public const uint MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A;
        public const uint MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80;
        public const uint MAX_TESS_GEN_LEVEL = 0x8E7E;
        public const uint MAX_TESS_PATCH_COMPONENTS = 0x8E84;
        public const uint MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;
        public const uint MAX_TEXTURE_IMAGE_UNITS = 0x8872;
        public const uint MAX_TEXTURE_LOD_BIAS = 0x84FD;
        public const uint MAX_TEXTURE_SIZE = 0x0D33;
        public const uint MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70;
        public const uint MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;
        public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;
        public const uint MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;
        public const uint MAX_UNIFORM_BLOCK_SIZE = 0x8A30;
        public const uint MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;
        public const uint MAX_UNIFORM_LOCATIONS = 0x826E;
        public const uint MAX_VARYING_COMPONENTS = 0x8B4B;
        public const uint MAX_VARYING_FLOATS = 0x8B4B;
        public const uint MAX_VARYING_VECTORS = 0x8DFC;
        public const uint MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2;
        public const uint MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC;
        public const uint MAX_VERTEX_ATTRIBS = 0x8869;
        public const uint MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA;
        public const uint MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9;
        public const uint MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;
        public const uint MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA;
        public const uint MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122;
        public const uint MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6;
        public const uint MAX_VERTEX_STREAMS = 0x8E71;
        public const uint MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C;
        public const uint MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;
        public const uint MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A;
        public const uint MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;
        public const uint MAX_VIEWPORTS = 0x825B;
        public const uint MAX_VIEWPORT_DIMS = 0x0D3A;
        public const uint MAX_WIDTH = 0x827E;
        public const uint MEDIUM_FLOAT = 0x8DF1;
        public const uint MEDIUM_INT = 0x8DF4;
        public const uint MIN = 0x8007;
        public const uint MINOR_VERSION = 0x821C;
        public const uint MIN_FRAGMENT_INTERPOLATION_OFFSET = 0x8E5B;
        public const uint MIN_MAP_BUFFER_ALIGNMENT = 0x90BC;
        public const uint MIN_PROGRAM_TEXEL_OFFSET = 0x8904;
        public const uint MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E;
        public const uint MIN_SAMPLE_SHADING_VALUE = 0x8C37;
        public const uint MIPMAP = 0x8293;
        public const uint MIRRORED_REPEAT = 0x8370;
        public const uint MIRROR_CLAMP_TO_EDGE = 0x8743;
        public const uint MULTISAMPLE = 0x809D;
        public const uint NAME_LENGTH = 0x92F9;
        public const uint NAND = 0x150E;
        public const uint NEAREST = 0x2600;
        public const uint NEAREST_MIPMAP_LINEAR = 0x2702;
        public const uint NEAREST_MIPMAP_NEAREST = 0x2700;
        public const uint NEGATIVE_ONE_TO_ONE = 0x935E;
        public const uint NEVER = 0x0200;
        public const uint NICEST = 0x1102;
        public const uint NONE = 0;
        public const uint NOOP = 0x1505;
        public const uint NOR = 0x1508;
        public const uint NOTEQUAL = 0x0205;
        public const uint NO_ERROR = 0;
        public const uint NO_RESET_NOTIFICATION = 0x8261;
        public const uint NUM_ACTIVE_VARIABLES = 0x9304;
        public const uint NUM_COMPATIBLE_SUBROUTINES = 0x8E4A;
        public const uint NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const uint NUM_EXTENSIONS = 0x821D;
        public const uint NUM_PROGRAM_BINARY_FORMATS = 0x87FE;
        public const uint NUM_SAMPLE_COUNTS = 0x9380;
        public const uint NUM_SHADER_BINARY_FORMATS = 0x8DF9;
        public const uint NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9;
        public const uint OBJECT_TYPE = 0x9112;
        public const uint OFFSET = 0x92FC;
        public const uint ONE = 1;
        public const uint ONE_MINUS_CONSTANT_ALPHA = 0x8004;
        public const uint ONE_MINUS_CONSTANT_COLOR = 0x8002;
        public const uint ONE_MINUS_DST_ALPHA = 0x0305;
        public const uint ONE_MINUS_DST_COLOR = 0x0307;
        public const uint ONE_MINUS_SRC1_ALPHA = 0x88FB;
        public const uint ONE_MINUS_SRC1_COLOR = 0x88FA;
        public const uint ONE_MINUS_SRC_ALPHA = 0x0303;
        public const uint ONE_MINUS_SRC_COLOR = 0x0301;
        public const uint OR = 0x1507;
        public const uint OR_INVERTED = 0x150D;
        public const uint OR_REVERSE = 0x150B;
        public const uint OUT_OF_MEMORY = 0x0505;
        public const uint PACK_ALIGNMENT = 0x0D05;
        public const uint PACK_COMPRESSED_BLOCK_DEPTH = 0x912D;
        public const uint PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C;
        public const uint PACK_COMPRESSED_BLOCK_SIZE = 0x912E;
        public const uint PACK_COMPRESSED_BLOCK_WIDTH = 0x912B;
        public const uint PACK_IMAGE_HEIGHT = 0x806C;
        public const uint PACK_LSB_FIRST = 0x0D01;
        public const uint PACK_ROW_LENGTH = 0x0D02;
        public const uint PACK_SKIP_IMAGES = 0x806B;
        public const uint PACK_SKIP_PIXELS = 0x0D04;
        public const uint PACK_SKIP_ROWS = 0x0D03;
        public const uint PACK_SWAP_BYTES = 0x0D00;
        public const uint PATCHES = 0x000E;
        public const uint PATCH_DEFAULT_INNER_LEVEL = 0x8E73;
        public const uint PATCH_DEFAULT_OUTER_LEVEL = 0x8E74;
        public const uint PATCH_VERTICES = 0x8E72;
        public const uint PIXEL_BUFFER_BARRIER_BIT = 0x00000080;
        public const uint PIXEL_PACK_BUFFER = 0x88EB;
        public const uint PIXEL_PACK_BUFFER_BINDING = 0x88ED;
        public const uint PIXEL_UNPACK_BUFFER = 0x88EC;
        public const uint PIXEL_UNPACK_BUFFER_BINDING = 0x88EF;
        public const uint POINT = 0x1B00;
        public const uint POINTS = 0x0000;
        public const uint POINT_FADE_THRESHOLD_SIZE = 0x8128;
        public const uint POINT_SIZE = 0x0B11;
        public const uint POINT_SIZE_GRANULARITY = 0x0B13;
        public const uint POINT_SIZE_RANGE = 0x0B12;
        public const uint POINT_SPRITE_COORD_ORIGIN = 0x8CA0;
        public const uint POLYGON_MODE = 0x0B40;
        public const uint POLYGON_OFFSET_FACTOR = 0x8038;
        public const uint POLYGON_OFFSET_FILL = 0x8037;
        public const uint POLYGON_OFFSET_LINE = 0x2A02;
        public const uint POLYGON_OFFSET_POINT = 0x2A01;
        public const uint POLYGON_OFFSET_UNITS = 0x2A00;
        public const uint POLYGON_SMOOTH = 0x0B41;
        public const uint POLYGON_SMOOTH_HINT = 0x0C53;
        public const uint PRIMITIVES_GENERATED = 0x8C87;
        public const uint PRIMITIVE_RESTART = 0x8F9D;
        public const uint PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69;
        public const uint PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;
        public const uint PRIMITIVE_RESTART_INDEX = 0x8F9E;
        public const uint PROGRAM = 0x82E2;
        public const uint PROGRAM_BINARY_FORMATS = 0x87FF;
        public const uint PROGRAM_BINARY_LENGTH = 0x8741;
        public const uint PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;
        public const uint PROGRAM_INPUT = 0x92E3;
        public const uint PROGRAM_OUTPUT = 0x92E4;
        public const uint PROGRAM_PIPELINE = 0x82E4;
        public const uint PROGRAM_PIPELINE_BINDING = 0x825A;
        public const uint PROGRAM_POINT_SIZE = 0x8642;
        public const uint PROGRAM_SEPARABLE = 0x8258;
        public const uint PROVOKING_VERTEX = 0x8E4F;
        public const uint PROXY_TEXTURE_1D = 0x8063;
        public const uint PROXY_TEXTURE_1D_ARRAY = 0x8C19;
        public const uint PROXY_TEXTURE_2D = 0x8064;
        public const uint PROXY_TEXTURE_2D_ARRAY = 0x8C1B;
        public const uint PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101;
        public const uint PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103;
        public const uint PROXY_TEXTURE_3D = 0x8070;
        public const uint PROXY_TEXTURE_CUBE_MAP = 0x851B;
        public const uint PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B;
        public const uint PROXY_TEXTURE_RECTANGLE = 0x84F7;
        public const uint QUADS = 0x0007;
        public const uint QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION = 0x8E4C;
        public const uint QUERY = 0x82E3;
        public const uint QUERY_BUFFER = 0x9192;
        public const uint QUERY_BUFFER_BARRIER_BIT = 0x00008000;
        public const uint QUERY_BUFFER_BINDING = 0x9193;
        public const uint QUERY_BY_REGION_NO_WAIT = 0x8E16;
        public const uint QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A;
        public const uint QUERY_BY_REGION_WAIT = 0x8E15;
        public const uint QUERY_BY_REGION_WAIT_INVERTED = 0x8E19;
        public const uint QUERY_COUNTER_BITS = 0x8864;
        public const uint QUERY_NO_WAIT = 0x8E14;
        public const uint QUERY_NO_WAIT_INVERTED = 0x8E18;
        public const uint QUERY_RESULT = 0x8866;
        public const uint QUERY_RESULT_AVAILABLE = 0x8867;
        public const uint QUERY_RESULT_NO_WAIT = 0x9194;
        public const uint QUERY_TARGET = 0x82EA;
        public const uint QUERY_WAIT = 0x8E13;
        public const uint QUERY_WAIT_INVERTED = 0x8E17;
        public const uint R11F_G11F_B10F = 0x8C3A;
        public const uint R16 = 0x822A;
        public const uint R16F = 0x822D;
        public const uint R16I = 0x8233;
        public const uint R16UI = 0x8234;
        public const uint R16_SNORM = 0x8F98;
        public const uint R32F = 0x822E;
        public const uint R32I = 0x8235;
        public const uint R32UI = 0x8236;
        public const uint R3_G3_B2 = 0x2A10;
        public const uint R8 = 0x8229;
        public const uint R8I = 0x8231;
        public const uint R8UI = 0x8232;
        public const uint R8_SNORM = 0x8F94;
        public const uint RASTERIZER_DISCARD = 0x8C89;
        public const uint READ_BUFFER = 0x0C02;
        public const uint READ_FRAMEBUFFER = 0x8CA8;
        public const uint READ_FRAMEBUFFER_BINDING = 0x8CAA;
        public const uint READ_ONLY = 0x88B8;
        public const uint READ_PIXELS = 0x828C;
        public const uint READ_PIXELS_FORMAT = 0x828D;
        public const uint READ_PIXELS_TYPE = 0x828E;
        public const uint READ_WRITE = 0x88BA;
        public const uint RED = 0x1903;
        public const uint RED_INTEGER = 0x8D94;
        public const uint REFERENCED_BY_COMPUTE_SHADER = 0x930B;
        public const uint REFERENCED_BY_FRAGMENT_SHADER = 0x930A;
        public const uint REFERENCED_BY_GEOMETRY_SHADER = 0x9309;
        public const uint REFERENCED_BY_TESS_CONTROL_SHADER = 0x9307;
        public const uint REFERENCED_BY_TESS_EVALUATION_SHADER = 0x9308;
        public const uint REFERENCED_BY_VERTEX_SHADER = 0x9306;
        public const uint RENDERBUFFER = 0x8D41;
        public const uint RENDERBUFFER_ALPHA_SIZE = 0x8D53;
        public const uint RENDERBUFFER_BINDING = 0x8CA7;
        public const uint RENDERBUFFER_BLUE_SIZE = 0x8D52;
        public const uint RENDERBUFFER_DEPTH_SIZE = 0x8D54;
        public const uint RENDERBUFFER_GREEN_SIZE = 0x8D51;
        public const uint RENDERBUFFER_HEIGHT = 0x8D43;
        public const uint RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;
        public const uint RENDERBUFFER_RED_SIZE = 0x8D50;
        public const uint RENDERBUFFER_SAMPLES = 0x8CAB;
        public const uint RENDERBUFFER_STENCIL_SIZE = 0x8D55;
        public const uint RENDERBUFFER_WIDTH = 0x8D42;
        public const uint RENDERER = 0x1F01;
        public const uint REPEAT = 0x2901;
        public const uint REPLACE = 0x1E01;
        public const uint RESET_NOTIFICATION_STRATEGY = 0x8256;
        public const uint RG = 0x8227;
        public const uint RG16 = 0x822C;
        public const uint RG16F = 0x822F;
        public const uint RG16I = 0x8239;
        public const uint RG16UI = 0x823A;
        public const uint RG16_SNORM = 0x8F99;
        public const uint RG32F = 0x8230;
        public const uint RG32I = 0x823B;
        public const uint RG32UI = 0x823C;
        public const uint RG8 = 0x822B;
        public const uint RG8I = 0x8237;
        public const uint RG8UI = 0x8238;
        public const uint RG8_SNORM = 0x8F95;
        public const uint RGB = 0x1907;
        public const uint RGB10 = 0x8052;
        public const uint RGB10_A2 = 0x8059;
        public const uint RGB10_A2UI = 0x906F;
        public const uint RGB12 = 0x8053;
        public const uint RGB16 = 0x8054;
        public const uint RGB16F = 0x881B;
        public const uint RGB16I = 0x8D89;
        public const uint RGB16UI = 0x8D77;
        public const uint RGB16_SNORM = 0x8F9A;
        public const uint RGB32F = 0x8815;
        public const uint RGB32I = 0x8D83;
        public const uint RGB32UI = 0x8D71;
        public const uint RGB4 = 0x804F;
        public const uint RGB5 = 0x8050;
        public const uint RGB565 = 0x8D62;
        public const uint RGB5_A1 = 0x8057;
        public const uint RGB8 = 0x8051;
        public const uint RGB8I = 0x8D8F;
        public const uint RGB8UI = 0x8D7D;
        public const uint RGB8_SNORM = 0x8F96;
        public const uint RGB9_E5 = 0x8C3D;
        public const uint RGBA = 0x1908;
        public const uint RGBA12 = 0x805A;
        public const uint RGBA16 = 0x805B;
        public const uint RGBA16F = 0x881A;
        public const uint RGBA16I = 0x8D88;
        public const uint RGBA16UI = 0x8D76;
        public const uint RGBA16_SNORM = 0x8F9B;
        public const uint RGBA2 = 0x8055;
        public const uint RGBA32F = 0x8814;
        public const uint RGBA32I = 0x8D82;
        public const uint RGBA32UI = 0x8D70;
        public const uint RGBA4 = 0x8056;
        public const uint RGBA8 = 0x8058;
        public const uint RGBA8I = 0x8D8E;
        public const uint RGBA8UI = 0x8D7C;
        public const uint RGBA8_SNORM = 0x8F97;
        public const uint RGBA_INTEGER = 0x8D99;
        public const uint RGB_INTEGER = 0x8D98;
        public const uint RG_INTEGER = 0x8228;
        public const uint RIGHT = 0x0407;
        public const uint SAMPLER = 0x82E6;
        public const uint SAMPLER_1D = 0x8B5D;
        public const uint SAMPLER_1D_ARRAY = 0x8DC0;
        public const uint SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;
        public const uint SAMPLER_1D_SHADOW = 0x8B61;
        public const uint SAMPLER_2D = 0x8B5E;
        public const uint SAMPLER_2D_ARRAY = 0x8DC1;
        public const uint SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;
        public const uint SAMPLER_2D_MULTISAMPLE = 0x9108;
        public const uint SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B;
        public const uint SAMPLER_2D_RECT = 0x8B63;
        public const uint SAMPLER_2D_RECT_SHADOW = 0x8B64;
        public const uint SAMPLER_2D_SHADOW = 0x8B62;
        public const uint SAMPLER_3D = 0x8B5F;
        public const uint SAMPLER_BINDING = 0x8919;
        public const uint SAMPLER_BUFFER = 0x8DC2;
        public const uint SAMPLER_CUBE = 0x8B60;
        public const uint SAMPLER_CUBE_MAP_ARRAY = 0x900C;
        public const uint SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D;
        public const uint SAMPLER_CUBE_SHADOW = 0x8DC5;
        public const uint SAMPLES = 0x80A9;
        public const uint SAMPLES_PASSED = 0x8914;
        public const uint SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const uint SAMPLE_ALPHA_TO_ONE = 0x809F;
        public const uint SAMPLE_BUFFERS = 0x80A8;
        public const uint SAMPLE_COVERAGE = 0x80A0;
        public const uint SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const uint SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const uint SAMPLE_MASK = 0x8E51;
        public const uint SAMPLE_MASK_VALUE = 0x8E52;
        public const uint SAMPLE_POSITION = 0x8E50;
        public const uint SAMPLE_SHADING = 0x8C36;
        public const uint SCISSOR_BOX = 0x0C10;
        public const uint SCISSOR_TEST = 0x0C11;
        public const uint SEPARATE_ATTRIBS = 0x8C8D;
        public const uint SET = 0x150F;
        public const uint SHADER = 0x82E1;
        public const uint SHADER_BINARY_FORMATS = 0x8DF8;
        public const uint SHADER_COMPILER = 0x8DFA;
        public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT = 0x00000020;
        public const uint SHADER_IMAGE_ATOMIC = 0x82A6;
        public const uint SHADER_IMAGE_LOAD = 0x82A4;
        public const uint SHADER_IMAGE_STORE = 0x82A5;
        public const uint SHADER_SOURCE_LENGTH = 0x8B88;
        public const uint SHADER_STORAGE_BARRIER_BIT = 0x00002000;
        public const uint SHADER_STORAGE_BLOCK = 0x92E6;
        public const uint SHADER_STORAGE_BUFFER = 0x90D2;
        public const uint SHADER_STORAGE_BUFFER_BINDING = 0x90D3;
        public const uint SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF;
        public const uint SHADER_STORAGE_BUFFER_SIZE = 0x90D5;
        public const uint SHADER_STORAGE_BUFFER_START = 0x90D4;
        public const uint SHADER_TYPE = 0x8B4F;
        public const uint SHADING_LANGUAGE_VERSION = 0x8B8C;
        public const uint SHORT = 0x1402;
        public const uint SIGNALED = 0x9119;
        public const uint SIGNED_NORMALIZED = 0x8F9C;
        public const uint SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC;
        public const uint SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE;
        public const uint SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD;
        public const uint SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF;
        public const uint SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
        public const uint SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
        public const uint SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
        public const uint SMOOTH_POINT_SIZE_RANGE = 0x0B12;
        public const uint SRC1_ALPHA = 0x8589;
        public const uint SRC1_COLOR = 0x88F9;
        public const uint SRC_ALPHA = 0x0302;
        public const uint SRC_ALPHA_SATURATE = 0x0308;
        public const uint SRC_COLOR = 0x0300;
        public const uint SRGB = 0x8C40;
        public const uint SRGB8 = 0x8C41;
        public const uint SRGB8_ALPHA8 = 0x8C43;
        public const uint SRGB_ALPHA = 0x8C42;
        public const uint SRGB_READ = 0x8297;
        public const uint SRGB_WRITE = 0x8298;
        public const uint STACK_OVERFLOW = 0x0503;
        public const uint STACK_UNDERFLOW = 0x0504;
        public const uint STATIC_COPY = 0x88E6;
        public const uint STATIC_DRAW = 0x88E4;
        public const uint STATIC_READ = 0x88E5;
        public const uint STENCIL = 0x1802;
        public const uint STENCIL_ATTACHMENT = 0x8D20;
        public const uint STENCIL_BACK_FAIL = 0x8801;
        public const uint STENCIL_BACK_FUNC = 0x8800;
        public const uint STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802;
        public const uint STENCIL_BACK_PASS_DEPTH_PASS = 0x8803;
        public const uint STENCIL_BACK_REF = 0x8CA3;
        public const uint STENCIL_BACK_VALUE_MASK = 0x8CA4;
        public const uint STENCIL_BACK_WRITEMASK = 0x8CA5;
        public const uint STENCIL_BUFFER_BIT = 0x00000400;
        public const uint STENCIL_CLEAR_VALUE = 0x0B91;
        public const uint STENCIL_COMPONENTS = 0x8285;
        public const uint STENCIL_FAIL = 0x0B94;
        public const uint STENCIL_FUNC = 0x0B92;
        public const uint STENCIL_INDEX = 0x1901;
        public const uint STENCIL_INDEX1 = 0x8D46;
        public const uint STENCIL_INDEX16 = 0x8D49;
        public const uint STENCIL_INDEX4 = 0x8D47;
        public const uint STENCIL_INDEX8 = 0x8D48;
        public const uint STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const uint STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const uint STENCIL_REF = 0x0B97;
        public const uint STENCIL_RENDERABLE = 0x8288;
        public const uint STENCIL_TEST = 0x0B90;
        public const uint STENCIL_VALUE_MASK = 0x0B93;
        public const uint STENCIL_WRITEMASK = 0x0B98;
        public const uint STEREO = 0x0C33;
        public const uint STREAM_COPY = 0x88E2;
        public const uint STREAM_DRAW = 0x88E0;
        public const uint STREAM_READ = 0x88E1;
        public const uint SUBPIXEL_BITS = 0x0D50;
        public const uint SYNC_CONDITION = 0x9113;
        public const uint SYNC_FENCE = 0x9116;
        public const uint SYNC_FLAGS = 0x9115;
        public const uint SYNC_FLUSH_COMMANDS_BIT = 0x00000001;
        public const uint SYNC_GPU_COMMANDS_COMPLETE = 0x9117;
        public const uint SYNC_STATUS = 0x9114;
        public const uint TESS_CONTROL_OUTPUT_VERTICES = 0x8E75;
        public const uint TESS_CONTROL_SHADER = 0x8E88;
        public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;
        public const uint TESS_CONTROL_SUBROUTINE = 0x92E9;
        public const uint TESS_CONTROL_SUBROUTINE_UNIFORM = 0x92EF;
        public const uint TESS_CONTROL_TEXTURE = 0x829C;
        public const uint TESS_EVALUATION_SHADER = 0x8E87;
        public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;
        public const uint TESS_EVALUATION_SUBROUTINE = 0x92EA;
        public const uint TESS_EVALUATION_SUBROUTINE_UNIFORM = 0x92F0;
        public const uint TESS_EVALUATION_TEXTURE = 0x829D;
        public const uint TESS_GEN_MODE = 0x8E76;
        public const uint TESS_GEN_POINT_MODE = 0x8E79;
        public const uint TESS_GEN_SPACING = 0x8E77;
        public const uint TESS_GEN_VERTEX_ORDER = 0x8E78;
        public const uint TEXTURE = 0x1702;
        public const uint TEXTURE0 = 0x84C0;
        public const uint TEXTURE1 = 0x84C1;
        public const uint TEXTURE10 = 0x84CA;
        public const uint TEXTURE11 = 0x84CB;
        public const uint TEXTURE12 = 0x84CC;
        public const uint TEXTURE13 = 0x84CD;
        public const uint TEXTURE14 = 0x84CE;
        public const uint TEXTURE15 = 0x84CF;
        public const uint TEXTURE16 = 0x84D0;
        public const uint TEXTURE17 = 0x84D1;
        public const uint TEXTURE18 = 0x84D2;
        public const uint TEXTURE19 = 0x84D3;
        public const uint TEXTURE2 = 0x84C2;
        public const uint TEXTURE20 = 0x84D4;
        public const uint TEXTURE21 = 0x84D5;
        public const uint TEXTURE22 = 0x84D6;
        public const uint TEXTURE23 = 0x84D7;
        public const uint TEXTURE24 = 0x84D8;
        public const uint TEXTURE25 = 0x84D9;
        public const uint TEXTURE26 = 0x84DA;
        public const uint TEXTURE27 = 0x84DB;
        public const uint TEXTURE28 = 0x84DC;
        public const uint TEXTURE29 = 0x84DD;
        public const uint TEXTURE3 = 0x84C3;
        public const uint TEXTURE30 = 0x84DE;
        public const uint TEXTURE31 = 0x84DF;
        public const uint TEXTURE4 = 0x84C4;
        public const uint TEXTURE5 = 0x84C5;
        public const uint TEXTURE6 = 0x84C6;
        public const uint TEXTURE7 = 0x84C7;
        public const uint TEXTURE8 = 0x84C8;
        public const uint TEXTURE9 = 0x84C9;
        public const uint TEXTURE_1D = 0x0DE0;
        public const uint TEXTURE_1D_ARRAY = 0x8C18;
        public const uint TEXTURE_2D = 0x0DE1;
        public const uint TEXTURE_2D_ARRAY = 0x8C1A;
        public const uint TEXTURE_2D_MULTISAMPLE = 0x9100;
        public const uint TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102;
        public const uint TEXTURE_3D = 0x806F;
        public const uint TEXTURE_ALPHA_SIZE = 0x805F;
        public const uint TEXTURE_ALPHA_TYPE = 0x8C13;
        public const uint TEXTURE_BASE_LEVEL = 0x813C;
        public const uint TEXTURE_BINDING_1D = 0x8068;
        public const uint TEXTURE_BINDING_1D_ARRAY = 0x8C1C;
        public const uint TEXTURE_BINDING_2D = 0x8069;
        public const uint TEXTURE_BINDING_2D_ARRAY = 0x8C1D;
        public const uint TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104;
        public const uint TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105;
        public const uint TEXTURE_BINDING_3D = 0x806A;
        public const uint TEXTURE_BINDING_BUFFER = 0x8C2C;
        public const uint TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const uint TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A;
        public const uint TEXTURE_BINDING_RECTANGLE = 0x84F6;
        public const uint TEXTURE_BLUE_SIZE = 0x805E;
        public const uint TEXTURE_BLUE_TYPE = 0x8C12;
        public const uint TEXTURE_BORDER_COLOR = 0x1004;
        public const uint TEXTURE_BUFFER = 0x8C2A;
        public const uint TEXTURE_BUFFER_BINDING = 0x8C2A;
        public const uint TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;
        public const uint TEXTURE_BUFFER_OFFSET = 0x919D;
        public const uint TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F;
        public const uint TEXTURE_BUFFER_SIZE = 0x919E;
        public const uint TEXTURE_COMPARE_FUNC = 0x884D;
        public const uint TEXTURE_COMPARE_MODE = 0x884C;
        public const uint TEXTURE_COMPRESSED = 0x86A1;
        public const uint TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2;
        public const uint TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3;
        public const uint TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1;
        public const uint TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
        public const uint TEXTURE_COMPRESSION_HINT = 0x84EF;
        public const uint TEXTURE_CUBE_MAP = 0x8513;
        public const uint TEXTURE_CUBE_MAP_ARRAY = 0x9009;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const uint TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const uint TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const uint TEXTURE_CUBE_MAP_SEAMLESS = 0x884F;
        public const uint TEXTURE_DEPTH = 0x8071;
        public const uint TEXTURE_DEPTH_SIZE = 0x884A;
        public const uint TEXTURE_DEPTH_TYPE = 0x8C16;
        public const uint TEXTURE_FETCH_BARRIER_BIT = 0x00000008;
        public const uint TEXTURE_FIXED_SAMPLE_LOCATIONS = 0x9107;
        public const uint TEXTURE_GATHER = 0x82A2;
        public const uint TEXTURE_GATHER_SHADOW = 0x82A3;
        public const uint TEXTURE_GREEN_SIZE = 0x805D;
        public const uint TEXTURE_GREEN_TYPE = 0x8C11;
        public const uint TEXTURE_HEIGHT = 0x1001;
        public const uint TEXTURE_IMAGE_FORMAT = 0x828F;
        public const uint TEXTURE_IMAGE_TYPE = 0x8290;
        public const uint TEXTURE_IMMUTABLE_FORMAT = 0x912F;
        public const uint TEXTURE_IMMUTABLE_LEVELS = 0x82DF;
        public const uint TEXTURE_INTERNAL_FORMAT = 0x1003;
        public const uint TEXTURE_LOD_BIAS = 0x8501;
        public const uint TEXTURE_MAG_FILTER = 0x2800;
        public const uint TEXTURE_MAX_LEVEL = 0x813D;
        public const uint TEXTURE_MAX_LOD = 0x813B;
        public const uint TEXTURE_MIN_FILTER = 0x2801;
        public const uint TEXTURE_MIN_LOD = 0x813A;
        public const uint TEXTURE_RECTANGLE = 0x84F5;
        public const uint TEXTURE_RED_SIZE = 0x805C;
        public const uint TEXTURE_RED_TYPE = 0x8C10;
        public const uint TEXTURE_SAMPLES = 0x9106;
        public const uint TEXTURE_SHADOW = 0x82A1;
        public const uint TEXTURE_SHARED_SIZE = 0x8C3F;
        public const uint TEXTURE_STENCIL_SIZE = 0x88F1;
        public const uint TEXTURE_SWIZZLE_A = 0x8E45;
        public const uint TEXTURE_SWIZZLE_B = 0x8E44;
        public const uint TEXTURE_SWIZZLE_G = 0x8E43;
        public const uint TEXTURE_SWIZZLE_R = 0x8E42;
        public const uint TEXTURE_SWIZZLE_RGBA = 0x8E46;
        public const uint TEXTURE_TARGET = 0x1006;
        public const uint TEXTURE_UPDATE_BARRIER_BIT = 0x00000100;
        public const uint TEXTURE_VIEW = 0x82B5;
        public const uint TEXTURE_VIEW_MIN_LAYER = 0x82DD;
        public const uint TEXTURE_VIEW_MIN_LEVEL = 0x82DB;
        public const uint TEXTURE_VIEW_NUM_LAYERS = 0x82DE;
        public const uint TEXTURE_VIEW_NUM_LEVELS = 0x82DC;
        public const uint TEXTURE_WIDTH = 0x1000;
        public const uint TEXTURE_WRAP_R = 0x8072;
        public const uint TEXTURE_WRAP_S = 0x2802;
        public const uint TEXTURE_WRAP_T = 0x2803;
        public const uint TIMEOUT_EXPIRED = 0x911B;
        public const uint TIMESTAMP = 0x8E28;
        public const uint TIME_ELAPSED = 0x88BF;
        public const uint TOP_LEVEL_ARRAY_SIZE = 0x930C;
        public const uint TOP_LEVEL_ARRAY_STRIDE = 0x930D;
        public const uint TRANSFORM_FEEDBACK = 0x8E22;
        public const uint TRANSFORM_FEEDBACK_ACTIVE = 0x8E24;
        public const uint TRANSFORM_FEEDBACK_BARRIER_BIT = 0x00000800;
        public const uint TRANSFORM_FEEDBACK_BINDING = 0x8E25;
        public const uint TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;
        public const uint TRANSFORM_FEEDBACK_BUFFER_ACTIVE = 0x8E24;
        public const uint TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;
        public const uint TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;
        public const uint TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;
        public const uint TRANSFORM_FEEDBACK_BUFFER_PAUSED = 0x8E23;
        public const uint TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;
        public const uint TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;
        public const uint TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;
        public const uint TRANSFORM_FEEDBACK_PAUSED = 0x8E23;
        public const uint TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;
        public const uint TRANSFORM_FEEDBACK_VARYING = 0x92F4;
        public const uint TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;
        public const uint TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;
        public const uint TRIANGLES = 0x0004;
        public const uint TRIANGLES_ADJACENCY = 0x000C;
        public const uint TRIANGLE_FAN = 0x0006;
        public const uint TRIANGLE_STRIP = 0x0005;
        public const uint TRIANGLE_STRIP_ADJACENCY = 0x000D;
        public const uint TRUE = 1;
        public const uint TYPE = 0x92FA;
        public const uint UNDEFINED_VERTEX = 0x8260;
        public const uint UNIFORM = 0x92E1;
        public const uint UNIFORM_ARRAY_STRIDE = 0x8A3C;
        public const uint UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX = 0x92DA;
        public const uint UNIFORM_BARRIER_BIT = 0x00000004;
        public const uint UNIFORM_BLOCK = 0x92E2;
        public const uint UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;
        public const uint UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;
        public const uint UNIFORM_BLOCK_BINDING = 0x8A3F;
        public const uint UNIFORM_BLOCK_DATA_SIZE = 0x8A40;
        public const uint UNIFORM_BLOCK_INDEX = 0x8A3A;
        public const uint UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER = 0x90EC;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER = 0x84F0;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x84F1;
        public const uint UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;
        public const uint UNIFORM_BUFFER = 0x8A11;
        public const uint UNIFORM_BUFFER_BINDING = 0x8A28;
        public const uint UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;
        public const uint UNIFORM_BUFFER_SIZE = 0x8A2A;
        public const uint UNIFORM_BUFFER_START = 0x8A29;
        public const uint UNIFORM_IS_ROW_MAJOR = 0x8A3E;
        public const uint UNIFORM_MATRIX_STRIDE = 0x8A3D;
        public const uint UNIFORM_NAME_LENGTH = 0x8A39;
        public const uint UNIFORM_OFFSET = 0x8A3B;
        public const uint UNIFORM_SIZE = 0x8A38;
        public const uint UNIFORM_TYPE = 0x8A37;
        public const uint UNKNOWN_CONTEXT_RESET = 0x8255;
        public const uint UNPACK_ALIGNMENT = 0x0CF5;
        public const uint UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129;
        public const uint UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128;
        public const uint UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A;
        public const uint UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127;
        public const uint UNPACK_IMAGE_HEIGHT = 0x806E;
        public const uint UNPACK_LSB_FIRST = 0x0CF1;
        public const uint UNPACK_ROW_LENGTH = 0x0CF2;
        public const uint UNPACK_SKIP_IMAGES = 0x806D;
        public const uint UNPACK_SKIP_PIXELS = 0x0CF4;
        public const uint UNPACK_SKIP_ROWS = 0x0CF3;
        public const uint UNPACK_SWAP_BYTES = 0x0CF0;
        public const uint UNSIGNALED = 0x9118;
        public const uint UNSIGNED_BYTE = 0x1401;
        public const uint UNSIGNED_BYTE_2_3_3_REV = 0x8362;
        public const uint UNSIGNED_BYTE_3_3_2 = 0x8032;
        public const uint UNSIGNED_INT = 0x1405;
        public const uint UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;
        public const uint UNSIGNED_INT_10_10_10_2 = 0x8036;
        public const uint UNSIGNED_INT_24_8 = 0x84FA;
        public const uint UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        public const uint UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;
        public const uint UNSIGNED_INT_8_8_8_8 = 0x8035;
        public const uint UNSIGNED_INT_8_8_8_8_REV = 0x8367;
        public const uint UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB;
        public const uint UNSIGNED_INT_IMAGE_1D = 0x9062;
        public const uint UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068;
        public const uint UNSIGNED_INT_IMAGE_2D = 0x9063;
        public const uint UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069;
        public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B;
        public const uint UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C;
        public const uint UNSIGNED_INT_IMAGE_2D_RECT = 0x9065;
        public const uint UNSIGNED_INT_IMAGE_3D = 0x9064;
        public const uint UNSIGNED_INT_IMAGE_BUFFER = 0x9067;
        public const uint UNSIGNED_INT_IMAGE_CUBE = 0x9066;
        public const uint UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A;
        public const uint UNSIGNED_INT_SAMPLER_1D = 0x8DD1;
        public const uint UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;
        public const uint UNSIGNED_INT_SAMPLER_2D = 0x8DD2;
        public const uint UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;
        public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A;
        public const uint UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D;
        public const uint UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;
        public const uint UNSIGNED_INT_SAMPLER_3D = 0x8DD3;
        public const uint UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;
        public const uint UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;
        public const uint UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F;
        public const uint UNSIGNED_INT_VEC2 = 0x8DC6;
        public const uint UNSIGNED_INT_VEC3 = 0x8DC7;
        public const uint UNSIGNED_INT_VEC4 = 0x8DC8;
        public const uint UNSIGNED_NORMALIZED = 0x8C17;
        public const uint UNSIGNED_SHORT = 0x1403;
        public const uint UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
        public const uint UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const uint UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
        public const uint UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const uint UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const uint UNSIGNED_SHORT_5_6_5_REV = 0x8364;
        public const uint UPPER_LEFT = 0x8CA2;
        public const uint VALIDATE_STATUS = 0x8B83;
        public const uint VENDOR = 0x1F00;
        public const uint VERSION = 0x1F02;
        public const uint VERTEX_ARRAY = 0x8074;
        public const uint VERTEX_ARRAY_BINDING = 0x85B5;
        public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT = 0x00000001;
        public const uint VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;
        public const uint VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE;
        public const uint VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622;
        public const uint VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;
        public const uint VERTEX_ATTRIB_ARRAY_LONG = 0x874E;
        public const uint VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A;
        public const uint VERTEX_ATTRIB_ARRAY_POINTER = 0x8645;
        public const uint VERTEX_ATTRIB_ARRAY_SIZE = 0x8623;
        public const uint VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624;
        public const uint VERTEX_ATTRIB_ARRAY_TYPE = 0x8625;
        public const uint VERTEX_ATTRIB_BINDING = 0x82D4;
        public const uint VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5;
        public const uint VERTEX_BINDING_BUFFER = 0x8F4F;
        public const uint VERTEX_BINDING_DIVISOR = 0x82D6;
        public const uint VERTEX_BINDING_OFFSET = 0x82D7;
        public const uint VERTEX_BINDING_STRIDE = 0x82D8;
        public const uint VERTEX_PROGRAM_POINT_SIZE = 0x8642;
        public const uint VERTEX_SHADER = 0x8B31;
        public const uint VERTEX_SHADER_BIT = 0x00000001;
        public const uint VERTEX_SUBROUTINE = 0x92E8;
        public const uint VERTEX_SUBROUTINE_UNIFORM = 0x92EE;
        public const uint VERTEX_TEXTURE = 0x829B;
        public const uint VIEWPORT = 0x0BA2;
        public const uint VIEWPORT_BOUNDS_RANGE = 0x825D;
        public const uint VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;
        public const uint VIEWPORT_SUBPIXEL_BITS = 0x825C;
        public const uint VIEW_CLASS_128_BITS = 0x82C4;
        public const uint VIEW_CLASS_16_BITS = 0x82CA;
        public const uint VIEW_CLASS_24_BITS = 0x82C9;
        public const uint VIEW_CLASS_32_BITS = 0x82C8;
        public const uint VIEW_CLASS_48_BITS = 0x82C7;
        public const uint VIEW_CLASS_64_BITS = 0x82C6;
        public const uint VIEW_CLASS_8_BITS = 0x82CB;
        public const uint VIEW_CLASS_96_BITS = 0x82C5;
        public const uint VIEW_CLASS_BPTC_FLOAT = 0x82D3;
        public const uint VIEW_CLASS_BPTC_UNORM = 0x82D2;
        public const uint VIEW_CLASS_RGTC1_RED = 0x82D0;
        public const uint VIEW_CLASS_RGTC2_RG = 0x82D1;
        public const uint VIEW_CLASS_S3TC_DXT1_RGB = 0x82CC;
        public const uint VIEW_CLASS_S3TC_DXT1_RGBA = 0x82CD;
        public const uint VIEW_CLASS_S3TC_DXT3_RGBA = 0x82CE;
        public const uint VIEW_CLASS_S3TC_DXT5_RGBA = 0x82CF;
        public const uint VIEW_COMPATIBILITY_CLASS = 0x82B6;
        public const uint WAIT_FAILED = 0x911D;
        public const uint WRITE_ONLY = 0x88B9;
        public const uint XOR = 0x1506;
        public const uint ZERO = 0;
        public const uint ZERO_TO_ONE = 0x935F;
        public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFF;

        [DllImport ("GL", EntryPoint = "glActiveShaderProgram")] public static extern void ActiveShaderProgram (uint pipeline, uint program);

        [DllImport ("GL", EntryPoint = "glActiveTexture")] public static extern void ActiveTexture (uint texture);

        [DllImport ("GL", EntryPoint = "glAttachShader")] public static extern void AttachShader (uint program, uint shader);

        [DllImport ("GL", EntryPoint = "glBeginConditionalRender")] public static extern void BeginConditionalRender (uint id, uint mode);

        [DllImport ("GL", EntryPoint = "glBeginQuery")] public static extern void BeginQuery (uint target, uint id);

        [DllImport ("GL", EntryPoint = "glBeginQueryIndexed")] public static extern void BeginQueryIndexed (uint target, uint index, uint id);

        [DllImport ("GL", EntryPoint = "glBeginTransformFeedback")] public static extern void BeginTransformFeedback (uint primitiveMode);

        [DllImport ("GL", EntryPoint = "glBindAttribLocation")] public static extern void BindAttribLocation (uint program, uint index, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glBindBuffer")] public static extern void BindBuffer (uint target, uint buffer);

        [DllImport ("GL", EntryPoint = "glBindBufferBase")] public static extern void BindBufferBase (uint target, uint index, uint buffer);

        [DllImport ("GL", EntryPoint = "glBindBufferRange")] public static extern void BindBufferRange (uint target, uint index, uint buffer, long offset, long size);

        [DllImport ("GL", EntryPoint = "glBindBuffersBase")] public static extern void BindBuffersBase (uint target, uint first, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] buffers);

        [DllImport ("GL", EntryPoint = "glBindBuffersRange")] public static extern void BindBuffersRange (uint target, uint first, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] buffers, [MarshalAs (UnmanagedType.LPArray)] long[] offsets, [MarshalAs (UnmanagedType.LPArray)] long[] sizes);

        [DllImport ("GL", EntryPoint = "glBindFragDataLocation")] public static extern void BindFragDataLocation (uint program, uint color, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glBindFragDataLocationIndexed")] public static extern void BindFragDataLocationIndexed (uint program, uint colorNumber, uint index, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glBindFramebuffer")] public static extern void BindFramebuffer (uint target, uint framebuffer);

        [DllImport ("GL", EntryPoint = "glBindImageTexture")] public static extern void BindImageTexture (uint unit, uint texture, int level, [MarshalAs (UnmanagedType.I1)] bool layered, int layer, uint access, uint format);

        [DllImport ("GL", EntryPoint = "glBindImageTextures")] public static extern void BindImageTextures (uint first, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] textures);

        [DllImport ("GL", EntryPoint = "glBindProgramPipeline")] public static extern void BindProgramPipeline (uint pipeline);

        [DllImport ("GL", EntryPoint = "glBindRenderbuffer")] public static extern void BindRenderbuffer (uint target, uint renderbuffer);

        [DllImport ("GL", EntryPoint = "glBindSampler")] public static extern void BindSampler (uint unit, uint sampler);

        [DllImport ("GL", EntryPoint = "glBindSamplers")] public static extern void BindSamplers (uint first, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] samplers);

        [DllImport ("GL", EntryPoint = "glBindTexture")] public static extern void BindTexture (uint target, uint texture);

        [DllImport ("GL", EntryPoint = "glBindTextureUnit")] public static extern void BindTextureUnit (uint unit, uint texture);

        [DllImport ("GL", EntryPoint = "glBindTextures")] public static extern void BindTextures (uint first, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] textures);

        [DllImport ("GL", EntryPoint = "glBindTransformFeedback")] public static extern void BindTransformFeedback (uint target, uint id);

        [DllImport ("GL", EntryPoint = "glBindVertexArray")] public static extern void BindVertexArray (uint array);

        [DllImport ("GL", EntryPoint = "glBindVertexBuffer")] public static extern void BindVertexBuffer (uint bindingindex, uint buffer, long offset, int stride);

        [DllImport ("GL", EntryPoint = "glBindVertexBuffers")] public static extern void BindVertexBuffers (uint first, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] buffers, [MarshalAs (UnmanagedType.LPArray)] long[] offsets, [MarshalAs (UnmanagedType.LPArray)] int[] strides);

        [DllImport ("GL", EntryPoint = "glBlendColor")] public static extern void BlendColor (float red, float green, float blue, float alpha);

        [DllImport ("GL", EntryPoint = "glBlendEquation")] public static extern void BlendEquation (uint mode);

        [DllImport ("GL", EntryPoint = "glBlendEquationSeparate")] public static extern void BlendEquationSeparate (uint modeRGB, uint modeAlpha);

        [DllImport ("GL", EntryPoint = "glBlendEquationSeparatei")] public static extern void BlendEquationSeparatei (uint buf, uint modeRGB, uint modeAlpha);

        [DllImport ("GL", EntryPoint = "glBlendEquationi")] public static extern void BlendEquationi (uint buf, uint mode);

        [DllImport ("GL", EntryPoint = "glBlendFunc")] public static extern void BlendFunc (uint sfactor, uint dfactor);

        [DllImport ("GL", EntryPoint = "glBlendFuncSeparate")] public static extern void BlendFuncSeparate (uint sfactorRGB, uint dfactorRGB, uint sfactorAlpha, uint dfactorAlpha);

        [DllImport ("GL", EntryPoint = "glBlendFuncSeparatei")] public static extern void BlendFuncSeparatei (uint buf, uint srcRGB, uint dstRGB, uint srcAlpha, uint dstAlpha);

        [DllImport ("GL", EntryPoint = "glBlendFunci")] public static extern void BlendFunci (uint buf, uint src, uint dst);

        [DllImport ("GL", EntryPoint = "glBlitFramebuffer")] public static extern void BlitFramebuffer (int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

        [DllImport ("GL", EntryPoint = "glBlitNamedFramebuffer")] public static extern void BlitNamedFramebuffer (uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, uint mask, uint filter);

        [DllImport ("GL", EntryPoint = "glBufferData")] public static extern void BufferData (uint target, long size, IntPtr data, uint usage);

        [DllImport ("GL", EntryPoint = "glBufferStorage")] public static extern void BufferStorage (uint target, long size, IntPtr data, uint flags);

        [DllImport ("GL", EntryPoint = "glBufferSubData")] public static extern void BufferSubData (uint target, long offset, long size, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCheckFramebufferStatus")] public static extern uint CheckFramebufferStatus (uint target);

        [DllImport ("GL", EntryPoint = "glCheckNamedFramebufferStatus")] public static extern uint CheckNamedFramebufferStatus (uint framebuffer, uint target);

        [DllImport ("GL", EntryPoint = "glClampColor")] public static extern void ClampColor (uint target, uint clamp);

        [DllImport ("GL", EntryPoint = "glClear")] public static extern void Clear (uint buf);

        [DllImport ("GL", EntryPoint = "glClearBufferData")] public static extern void ClearBufferData (uint target, uint internalformat, uint format, uint type, IntPtr data);

        [DllImport ("GL", EntryPoint = "glClearBufferSubData")] public static extern void ClearBufferSubData (uint target, uint internalformat, long offset, long size, uint format, uint type, IntPtr data);

        [DllImport ("GL", EntryPoint = "glClearBufferfi")] public static extern void ClearBufferfi (uint buffer, int drawbuffer, float depth, int stencil);

        [DllImport ("GL", EntryPoint = "glClearBufferfv")] public static extern void ClearBufferfv (uint buffer, int drawbuffer, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glClearBufferiv")] public static extern void ClearBufferiv (uint buffer, int drawbuffer, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glClearBufferuiv")] public static extern void ClearBufferuiv (uint buffer, int drawbuffer, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glClearColor")] public static extern void ClearColor (float red, float green, float blue, float alpha);

        [DllImport ("GL", EntryPoint = "glClearDepth")] public static extern void ClearDepth (double depth);

        [DllImport ("GL", EntryPoint = "glClearDepthf")] public static extern void ClearDepthf (float d);

        [DllImport ("GL", EntryPoint = "glClearNamedBufferData")] public static extern void ClearNamedBufferData (uint buffer, uint internalformat, uint format, uint type, IntPtr data);

        [DllImport ("GL", EntryPoint = "glClearNamedBufferSubData")] public static extern void ClearNamedBufferSubData (uint buffer, uint internalformat, long offset, long size, uint format, uint type, IntPtr data);

        [DllImport ("GL", EntryPoint = "glClearNamedFramebufferfi")] public static extern void ClearNamedFramebufferfi (uint framebuffer, uint buffer, int drawbuffer, float depth, int stencil);

        [DllImport ("GL", EntryPoint = "glClearNamedFramebufferfv")] public static extern void ClearNamedFramebufferfv (uint framebuffer, uint buffer, int drawbuffer, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glClearNamedFramebufferiv")] public static extern void ClearNamedFramebufferiv (uint framebuffer, uint buffer, int drawbuffer, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glClearNamedFramebufferuiv")] public static extern void ClearNamedFramebufferuiv (uint framebuffer, uint buffer, int drawbuffer, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glClearStencil")] public static extern void ClearStencil (int s);

        [DllImport ("GL", EntryPoint = "glClearTexImage")] public static extern void ClearTexImage (uint texture, int level, uint format, uint type, IntPtr data);

        [DllImport ("GL", EntryPoint = "glClearTexSubImage")] public static extern void ClearTexSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr data);

        [DllImport ("GL", EntryPoint = "glClientWaitSync")] public static extern uint ClientWaitSync (UIntPtr sync, uint flags, ulong timeout);

        [DllImport ("GL", EntryPoint = "glClipControl")] public static extern void ClipControl (uint origin, uint depth);

        [DllImport ("GL", EntryPoint = "glColorMask")] public static extern void ColorMask ([MarshalAs (UnmanagedType.I1)] bool red, [MarshalAs (UnmanagedType.I1)] bool green, [MarshalAs (UnmanagedType.I1)] bool blue, [MarshalAs (UnmanagedType.I1)] bool alpha);

        [DllImport ("GL", EntryPoint = "glColorMaski")] public static extern void ColorMaski (uint index, [MarshalAs (UnmanagedType.I1)] bool r, [MarshalAs (UnmanagedType.I1)] bool g, [MarshalAs (UnmanagedType.I1)] bool b, [MarshalAs (UnmanagedType.I1)] bool a);

        [DllImport ("GL", EntryPoint = "glColorP3ui")] public static extern void ColorP3ui (uint type, uint color);

        [DllImport ("GL", EntryPoint = "glColorP3uiv")] public static extern void ColorP3uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] color);

        [DllImport ("GL", EntryPoint = "glColorP4ui")] public static extern void ColorP4ui (uint type, uint color);

        [DllImport ("GL", EntryPoint = "glColorP4uiv")] public static extern void ColorP4uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] color);

        [DllImport ("GL", EntryPoint = "glCompileShader")] public static extern void CompileShader (uint shader);

        [DllImport ("GL", EntryPoint = "glCompressedTexImage1D")] public static extern void CompressedTexImage1D (uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCompressedTexImage2D")] public static extern void CompressedTexImage2D (uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCompressedTexImage3D")] public static extern void CompressedTexImage3D (uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCompressedTexSubImage1D")] public static extern void CompressedTexSubImage1D (uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCompressedTexSubImage2D")] public static extern void CompressedTexSubImage2D (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCompressedTexSubImage3D")] public static extern void CompressedTexSubImage3D (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCompressedTextureSubImage1D")] public static extern void CompressedTextureSubImage1D (uint texture, int level, int xoffset, int width, uint format, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCompressedTextureSubImage2D")] public static extern void CompressedTextureSubImage2D (uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCompressedTextureSubImage3D")] public static extern void CompressedTextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glCopyBufferSubData")] public static extern void CopyBufferSubData (uint readTarget, uint writeTarget, long readOffset, long writeOffset, long size);

        [DllImport ("GL", EntryPoint = "glCopyImageSubData")] public static extern void CopyImageSubData (uint srcName, uint srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, uint dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

        [DllImport ("GL", EntryPoint = "glCopyNamedBufferSubData")] public static extern void CopyNamedBufferSubData (uint readBuffer, uint writeBuffer, long readOffset, long writeOffset, long size);

        [DllImport ("GL", EntryPoint = "glCopyTexImage1D")] public static extern void CopyTexImage1D (uint target, int level, uint internalformat, int x, int y, int width, int border);

        [DllImport ("GL", EntryPoint = "glCopyTexImage2D")] public static extern void CopyTexImage2D (uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

        [DllImport ("GL", EntryPoint = "glCopyTexSubImage1D")] public static extern void CopyTexSubImage1D (uint target, int level, int xoffset, int x, int y, int width);

        [DllImport ("GL", EntryPoint = "glCopyTexSubImage2D")] public static extern void CopyTexSubImage2D (uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [DllImport ("GL", EntryPoint = "glCopyTexSubImage3D")] public static extern void CopyTexSubImage3D (uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        [DllImport ("GL", EntryPoint = "glCopyTextureSubImage1D")] public static extern void CopyTextureSubImage1D (uint texture, int level, int xoffset, int x, int y, int width);

        [DllImport ("GL", EntryPoint = "glCopyTextureSubImage2D")] public static extern void CopyTextureSubImage2D (uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [DllImport ("GL", EntryPoint = "glCopyTextureSubImage3D")] public static extern void CopyTextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        [DllImport ("GL", EntryPoint = "glCreateBuffers")] public static extern void CreateBuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] buffers);

        [DllImport ("GL", EntryPoint = "glCreateFramebuffers")] public static extern void CreateFramebuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] framebuffers);

        [DllImport ("GL", EntryPoint = "glCreateProgram")] public static extern uint CreateProgram ();

        [DllImport ("GL", EntryPoint = "glCreateProgramPipelines")] public static extern void CreateProgramPipelines (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] pipelines);

        [DllImport ("GL", EntryPoint = "glCreateQueries")] public static extern void CreateQueries (uint target, int n, [MarshalAs (UnmanagedType.LPArray)] uint[] ids);

        [DllImport ("GL", EntryPoint = "glCreateRenderbuffers")] public static extern void CreateRenderbuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] renderbuffers);

        [DllImport ("GL", EntryPoint = "glCreateSamplers")] public static extern void CreateSamplers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] samplers);

        [DllImport ("GL", EntryPoint = "glCreateShader")] public static extern uint CreateShader (uint type);

        [DllImport ("GL", EntryPoint = "glCreateShaderProgramv")] public static extern uint CreateShaderProgramv (uint type, int count, [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] strings);

        [DllImport ("GL", EntryPoint = "glCreateTextures")] public static extern void CreateTextures (uint target, int n, [MarshalAs (UnmanagedType.LPArray)] uint[] textures);

        [DllImport ("GL", EntryPoint = "glCreateTransformFeedbacks")] public static extern void CreateTransformFeedbacks (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] ids);

        [DllImport ("GL", EntryPoint = "glCreateVertexArrays")] public static extern void CreateVertexArrays (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] arrays);

        [DllImport ("GL", EntryPoint = "glCreateBuffers")] public static extern void CreateBuffers (int n, out uint buffers);

        [DllImport ("GL", EntryPoint = "glCreateFramebuffers")] public static extern void CreateFramebuffers (int n, out uint framebuffers);

        [DllImport ("GL", EntryPoint = "glCreateProgramPipelines")] public static extern void CreateProgramPipelines (int n, out uint pipelines);

        [DllImport ("GL", EntryPoint = "glCreateQueries")] public static extern void CreateQueries (uint target, int n, out uint ids);

        [DllImport ("GL", EntryPoint = "glCreateRenderbuffers")] public static extern void CreateRenderbuffers (int n, out uint renderbuffers);

        [DllImport ("GL", EntryPoint = "glCreateSamplers")] public static extern void CreateSamplers (int n, out uint samplers);

        [DllImport ("GL", EntryPoint = "glCreateTextures")] public static extern void CreateTextures (uint target, int n, out uint textures);

        [DllImport ("GL", EntryPoint = "glCreateTransformFeedbacks")] public static extern void CreateTransformFeedbacks (int n, out uint ids);

        [DllImport ("GL", EntryPoint = "glCreateVertexArrays")] public static extern void CreateVertexArrays (int n, out uint arrays);

        [DllImport ("GL", EntryPoint = "glCullFace")] public static extern void CullFace (uint mode);

        [DllImport ("GL", EntryPoint = "glDebugMessageCallback")] public static extern void DebugMessageCallback (IntPtr callback, IntPtr userParam);

        [DllImport ("GL", EntryPoint = "glDebugMessageControl")] public static extern void DebugMessageControl (uint source, uint type, uint severity, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] ids, [MarshalAs (UnmanagedType.I1)] bool enabled);

        [DllImport ("GL", EntryPoint = "glDebugMessageInsert")] public static extern void DebugMessageInsert (uint source, uint type, uint id, uint severity, int length, [MarshalAs (UnmanagedType.LPStr)] string buf);

        [DllImport ("GL", EntryPoint = "glDeleteBuffers")] public static extern void DeleteBuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] buffers);

        [DllImport ("GL", EntryPoint = "glDeleteFramebuffers")] public static extern void DeleteFramebuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] framebuffers);

        [DllImport ("GL", EntryPoint = "glDeleteProgram")] public static extern void DeleteProgram (uint program);

        [DllImport ("GL", EntryPoint = "glDeleteProgramPipelines")] public static extern void DeleteProgramPipelines (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] pipelines);

        [DllImport ("GL", EntryPoint = "glDeleteQueries")] public static extern void DeleteQueries (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] ids);

        [DllImport ("GL", EntryPoint = "glDeleteRenderbuffers")] public static extern void DeleteRenderbuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] renderbuffers);

        [DllImport ("GL", EntryPoint = "glDeleteSamplers")] public static extern void DeleteSamplers (int count, [MarshalAs (UnmanagedType.LPArray)] uint[] samplers);

        [DllImport ("GL", EntryPoint = "glDeleteShader")] public static extern void DeleteShader (uint shader);

        [DllImport ("GL", EntryPoint = "glDeleteSync")] public static extern void DeleteSync (UIntPtr sync);

        [DllImport ("GL", EntryPoint = "glDeleteTextures")] public static extern void DeleteTextures (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] textures);

        [DllImport ("GL", EntryPoint = "glDeleteTransformFeedbacks")] public static extern void DeleteTransformFeedbacks (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] ids);

        [DllImport ("GL", EntryPoint = "glDeleteVertexArrays")] public static extern void DeleteVertexArrays (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] arrays);

        [DllImport ("GL", EntryPoint = "glDepthFunc")] public static extern void DepthFunc (uint func);

        [DllImport ("GL", EntryPoint = "glDepthMask")] public static extern void DepthMask ([MarshalAs (UnmanagedType.I1)] bool flag);

        [DllImport ("GL", EntryPoint = "glDepthRange")] public static extern void DepthRange (double near, double far);

        [DllImport ("GL", EntryPoint = "glDepthRangeArrayv")] public static extern void DepthRangeArrayv (uint first, int count, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glDepthRangeIndexed")] public static extern void DepthRangeIndexed (uint index, double n, double f);

        [DllImport ("GL", EntryPoint = "glDepthRangef")] public static extern void DepthRangef (float n, float f);

        [DllImport ("GL", EntryPoint = "glDetachShader")] public static extern void DetachShader (uint program, uint shader);

        [DllImport ("GL", EntryPoint = "glDisable")] public static extern void Disable (uint cap);

        [DllImport ("GL", EntryPoint = "glDisableVertexArrayAttrib")] public static extern void DisableVertexArrayAttrib (uint vaobj, uint index);

        [DllImport ("GL", EntryPoint = "glDisableVertexAttribArray")] public static extern void DisableVertexAttribArray (uint index);

        [DllImport ("GL", EntryPoint = "glDisablei")] public static extern void Disablei (uint target, uint index);

        [DllImport ("GL", EntryPoint = "glDispatchCompute")] public static extern void DispatchCompute (uint num_groups_x, uint num_groups_y, uint num_groups_z);

        [DllImport ("GL", EntryPoint = "glDispatchComputeIndirect")] public static extern void DispatchComputeIndirect (long indirect);

        [DllImport ("GL", EntryPoint = "glDrawArrays")] public static extern void DrawArrays (uint mode, int first, int count);

        [DllImport ("GL", EntryPoint = "glDrawArraysIndirect")] public static extern void DrawArraysIndirect (uint mode, IntPtr indirect);

        [DllImport ("GL", EntryPoint = "glDrawArraysInstanced")] public static extern void DrawArraysInstanced (uint mode, int first, int count, int instancecount);

        [DllImport ("GL", EntryPoint = "glDrawArraysInstancedBaseInstance")] public static extern void DrawArraysInstancedBaseInstance (uint mode, int first, int count, int instancecount, uint baseinstance);

        [DllImport ("GL", EntryPoint = "glDrawBuffer")] public static extern void DrawBuffer (uint buf);

        [DllImport ("GL", EntryPoint = "glDrawBuffers")] public static extern void DrawBuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] bufs);

        [DllImport ("GL", EntryPoint = "glDrawElements")] public static extern void DrawElements (uint mode, int count, uint type, IntPtr indices);

        [DllImport ("GL", EntryPoint = "glDrawElementsBaseVertex")] public static extern void DrawElementsBaseVertex (uint mode, int count, uint type, IntPtr indices, int basevertex);

        [DllImport ("GL", EntryPoint = "glDrawElementsIndirect")] public static extern void DrawElementsIndirect (uint mode, uint type, IntPtr indirect);

        [DllImport ("GL", EntryPoint = "glDrawElementsInstanced")] public static extern void DrawElementsInstanced (uint mode, int count, uint type, IntPtr indices, int instancecount);

        [DllImport ("GL", EntryPoint = "glDrawElementsInstancedBaseInstance")] public static extern void DrawElementsInstancedBaseInstance (uint mode, int count, uint type, IntPtr indices, int instancecount, uint baseinstance);

        [DllImport ("GL", EntryPoint = "glDrawElementsInstancedBaseVertex")] public static extern void DrawElementsInstancedBaseVertex (uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex);

        [DllImport ("GL", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")] public static extern void DrawElementsInstancedBaseVertexBaseInstance (uint mode, int count, uint type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);

        [DllImport ("GL", EntryPoint = "glDrawRangeElements")] public static extern void DrawRangeElements (uint mode, uint start, uint end, int count, uint type, IntPtr indices);

        [DllImport ("GL", EntryPoint = "glDrawRangeElementsBaseVertex")] public static extern void DrawRangeElementsBaseVertex (uint mode, uint start, uint end, int count, uint type, IntPtr indices, int basevertex);

        [DllImport ("GL", EntryPoint = "glDrawTransformFeedback")] public static extern void DrawTransformFeedback (uint mode, uint id);

        [DllImport ("GL", EntryPoint = "glDrawTransformFeedbackInstanced")] public static extern void DrawTransformFeedbackInstanced (uint mode, uint id, int instancecount);

        [DllImport ("GL", EntryPoint = "glDrawTransformFeedbackStream")] public static extern void DrawTransformFeedbackStream (uint mode, uint id, uint stream);

        [DllImport ("GL", EntryPoint = "glDrawTransformFeedbackStreamInstanced")] public static extern void DrawTransformFeedbackStreamInstanced (uint mode, uint id, uint stream, int instancecount);

        [DllImport ("GL", EntryPoint = "glEnable")] public static extern void Enable (uint cap);

        [DllImport ("GL", EntryPoint = "glEnableVertexArrayAttrib")] public static extern void EnableVertexArrayAttrib (uint vaobj, uint index);

        [DllImport ("GL", EntryPoint = "glEnableVertexAttribArray")] public static extern void EnableVertexAttribArray (uint index);

        [DllImport ("GL", EntryPoint = "glEnablei")] public static extern void Enablei (uint target, uint index);

        [DllImport ("GL", EntryPoint = "glEndConditionalRender")] public static extern void EndConditionalRender ();

        [DllImport ("GL", EntryPoint = "glEndQuery")] public static extern void EndQuery (uint target);

        [DllImport ("GL", EntryPoint = "glEndQueryIndexed")] public static extern void EndQueryIndexed (uint target, uint index);

        [DllImport ("GL", EntryPoint = "glEndTransformFeedback")] public static extern void EndTransformFeedback ();

        [DllImport ("GL", EntryPoint = "glFenceSync")] public static extern UIntPtr FenceSync (uint condition, uint flags);

        [DllImport ("GL", EntryPoint = "glFinish")] public static extern void Finish ();

        [DllImport ("GL", EntryPoint = "glFlush")] public static extern void Flush ();

        [DllImport ("GL", EntryPoint = "glFlushMappedBufferRange")] public static extern void FlushMappedBufferRange (uint target, long offset, long length);

        [DllImport ("GL", EntryPoint = "glFlushMappedNamedBufferRange")] public static extern void FlushMappedNamedBufferRange (uint buffer, long offset, long length);

        [DllImport ("GL", EntryPoint = "glFramebufferParameteri")] public static extern void FramebufferParameteri (uint target, uint pname, int param);

        [DllImport ("GL", EntryPoint = "glFramebufferRenderbuffer")] public static extern void FramebufferRenderbuffer (uint target, uint attachment, uint renderbuffertarget, uint renderbuffer);

        [DllImport ("GL", EntryPoint = "glFramebufferTexture")] public static extern void FramebufferTexture (uint target, uint attachment, uint texture, int level);

        [DllImport ("GL", EntryPoint = "glFramebufferTexture1D")] public static extern void FramebufferTexture1D (uint target, uint attachment, uint textarget, uint texture, int level);

        [DllImport ("GL", EntryPoint = "glFramebufferTexture2D")] public static extern void FramebufferTexture2D (uint target, uint attachment, uint textarget, uint texture, int level);

        [DllImport ("GL", EntryPoint = "glFramebufferTexture3D")] public static extern void FramebufferTexture3D (uint target, uint attachment, uint textarget, uint texture, int level, int zoffset);

        [DllImport ("GL", EntryPoint = "glFramebufferTextureLayer")] public static extern void FramebufferTextureLayer (uint target, uint attachment, uint texture, int level, int layer);

        [DllImport ("GL", EntryPoint = "glFrontFace")] public static extern void FrontFace (uint mode);

        [DllImport ("GL", EntryPoint = "glGenBuffers")] public static extern void GenBuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] buffers);

        [DllImport ("GL", EntryPoint = "glGenFramebuffers")] public static extern void GenFramebuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] framebuffers);

        [DllImport ("GL", EntryPoint = "glGenProgramPipelines")] public static extern void GenProgramPipelines (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] pipelines);

        [DllImport ("GL", EntryPoint = "glGenQueries")] public static extern void GenQueries (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] ids);

        [DllImport ("GL", EntryPoint = "glGenRenderbuffers")] public static extern void GenRenderbuffers (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] renderbuffers);

        [DllImport ("GL", EntryPoint = "glGenSamplers")] public static extern void GenSamplers (int count, [MarshalAs (UnmanagedType.LPArray)] uint[] samplers);

        [DllImport ("GL", EntryPoint = "glGenTextures")] public static extern void GenTextures (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] textures);

        [DllImport ("GL", EntryPoint = "glGenTransformFeedbacks")] public static extern void GenTransformFeedbacks (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] ids);

        [DllImport ("GL", EntryPoint = "glGenVertexArrays")] public static extern void GenVertexArrays (int n, [MarshalAs (UnmanagedType.LPArray)] uint[] arrays);

        [DllImport ("GL", EntryPoint = "glGenerateMipmap")] public static extern void GenerateMipmap (uint target);

        [DllImport ("GL", EntryPoint = "glGenerateTextureMipmap")] public static extern void GenerateTextureMipmap (uint texture);

        [DllImport ("GL", EntryPoint = "glGetActiveAtomicCounterBufferiv")] public static extern void GetActiveAtomicCounterBufferiv (uint program, uint bufferIndex, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetActiveAttrib")] public static extern void GetActiveAttrib (uint program, uint index, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPArray)] int[] size, [MarshalAs (UnmanagedType.LPArray)] uint[] type, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetActiveSubroutineName")] public static extern void GetActiveSubroutineName (uint program, uint shadertype, uint index, int bufsize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetActiveSubroutineUniformName")] public static extern void GetActiveSubroutineUniformName (uint program, uint shadertype, uint index, int bufsize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetActiveSubroutineUniformiv")] public static extern void GetActiveSubroutineUniformiv (uint program, uint shadertype, uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] values);

        [DllImport ("GL", EntryPoint = "glGetActiveUniform")] public static extern void GetActiveUniform (uint program, uint index, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPArray)] int[] size, [MarshalAs (UnmanagedType.LPArray)] uint[] type, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetActiveUniformBlockName")] public static extern void GetActiveUniformBlockName (uint program, uint uniformBlockIndex, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string uniformBlockName);

        [DllImport ("GL", EntryPoint = "glGetActiveUniformBlockiv")] public static extern void GetActiveUniformBlockiv (uint program, uint uniformBlockIndex, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetActiveUniformName")] public static extern void GetActiveUniformName (uint program, uint uniformIndex, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string uniformName);

        [DllImport ("GL", EntryPoint = "glGetActiveUniformsiv")] public static extern void GetActiveUniformsiv (uint program, int uniformCount, [MarshalAs (UnmanagedType.LPArray)] uint[] uniformIndices, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetAttachedShaders")] public static extern void GetAttachedShaders (uint program, int maxCount, [MarshalAs (UnmanagedType.LPArray)] int[] count, [MarshalAs (UnmanagedType.LPArray)] uint[] shaders);

        [DllImport ("GL", EntryPoint = "glGetAttribLocation")] public static extern int GetAttribLocation (uint program, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetBooleani_v")] public static extern void GetBooleani_v (uint target, uint index, [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)] bool data);

        [DllImport ("GL", EntryPoint = "glGetBooleanv")] public static extern void GetBooleanv (uint pname, [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.I1)] bool data);

        [DllImport ("GL", EntryPoint = "glGetBufferParameteri64v")] public static extern void GetBufferParameteri64v (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] long[] args);

        [DllImport ("GL", EntryPoint = "glGetBufferParameteriv")] public static extern void GetBufferParameteriv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetBufferPointerv")] public static extern void GetBufferPointerv (uint target, uint pname, IntPtr* args);

        [DllImport ("GL", EntryPoint = "glGetBufferSubData")] public static extern void GetBufferSubData (uint target, long offset, long size, IntPtr data);

        [DllImport ("GL", EntryPoint = "glGetCompressedTexImage")] public static extern void GetCompressedTexImage (uint target, int level, IntPtr img);

        [DllImport ("GL", EntryPoint = "glGetCompressedTextureImage")] public static extern void GetCompressedTextureImage (uint texture, int level, int bufSize, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glGetCompressedTextureSubImage")] public static extern void GetCompressedTextureSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glGetDebugMessageLog")] public static extern uint GetDebugMessageLog (uint count, int bufSize, [MarshalAs (UnmanagedType.LPArray)] uint[] sources, [MarshalAs (UnmanagedType.LPArray)] uint[] types, [MarshalAs (UnmanagedType.LPArray)] uint[] ids, [MarshalAs (UnmanagedType.LPArray)] uint[] severities, [MarshalAs (UnmanagedType.LPArray)] int[] lengths, [MarshalAs (UnmanagedType.LPStr)] string messageLog);

        [DllImport ("GL", EntryPoint = "glGetDoublei_v")] public static extern void GetDoublei_v (uint target, uint index, [MarshalAs (UnmanagedType.LPArray)] double[] data);

        [DllImport ("GL", EntryPoint = "glGetDoublev")] public static extern void GetDoublev (uint pname, [MarshalAs (UnmanagedType.LPArray)] double[] data);

        [DllImport ("GL", EntryPoint = "glGetError")] public static extern uint GetError ();

        [DllImport ("GL", EntryPoint = "glGetFloati_v")] public static extern void GetFloati_v (uint target, uint index, [MarshalAs (UnmanagedType.LPArray)] float[] data);

        [DllImport ("GL", EntryPoint = "glGetFloatv")] public static extern void GetFloatv (uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] data);

        [DllImport ("GL", EntryPoint = "glGetFragDataIndex")] public static extern int GetFragDataIndex (uint program, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetFragDataLocation")] public static extern int GetFragDataLocation (uint program, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetFramebufferAttachmentParameteriv")] public static extern void GetFramebufferAttachmentParameteriv (uint target, uint attachment, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetFramebufferParameteriv")] public static extern void GetFramebufferParameteriv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetGraphicsResetStatus")] public static extern uint GetGraphicsResetStatus ();

        [DllImport ("GL", EntryPoint = "glGetInteger64i_v")] public static extern void GetInteger64i_v (uint target, uint index, [MarshalAs (UnmanagedType.LPArray)] long[] data);

        [DllImport ("GL", EntryPoint = "glGetInteger64v")] public static extern void GetInteger64v (uint pname, [MarshalAs (UnmanagedType.LPArray)] long[] data);

        [DllImport ("GL", EntryPoint = "glGetIntegeri_v")] public static extern void GetIntegeri_v (uint target, uint index, [MarshalAs (UnmanagedType.LPArray)] int[] data);

        [DllImport ("GL", EntryPoint = "glGetIntegerv")] public static extern void GetIntegerv (uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] data);

        [DllImport ("GL", EntryPoint = "glGetInternalformati64v")] public static extern void GetInternalformati64v (uint target, uint internalformat, uint pname, int bufSize, [MarshalAs (UnmanagedType.LPArray)] long[] args);

        [DllImport ("GL", EntryPoint = "glGetInternalformativ")] public static extern void GetInternalformativ (uint target, uint internalformat, uint pname, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetMultisamplefv")] public static extern void GetMultisamplefv (uint pname, uint index, [MarshalAs (UnmanagedType.LPArray)] float[] val);

        [DllImport ("GL", EntryPoint = "glGetNamedBufferParameteri64v")] public static extern void GetNamedBufferParameteri64v (uint buffer, uint pname, [MarshalAs (UnmanagedType.LPArray)] long[] args);

        [DllImport ("GL", EntryPoint = "glGetNamedBufferParameteriv")] public static extern void GetNamedBufferParameteriv (uint buffer, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetNamedBufferPointerv")] public static extern void GetNamedBufferPointerv (uint buffer, uint pname, IntPtr* args);

        [DllImport ("GL", EntryPoint = "glGetNamedBufferSubData")] public static extern void GetNamedBufferSubData (uint buffer, long offset, long size, IntPtr data);

        [DllImport ("GL", EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")] public static extern void GetNamedFramebufferAttachmentParameteriv (uint framebuffer, uint attachment, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetNamedFramebufferParameteriv")] public static extern void GetNamedFramebufferParameteriv (uint framebuffer, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] param);

        [DllImport ("GL", EntryPoint = "glGetNamedRenderbufferParameteriv")] public static extern void GetNamedRenderbufferParameteriv (uint renderbuffer, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetObjectLabel")] public static extern void GetObjectLabel (uint identifier, uint name, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string label);

        [DllImport ("GL", EntryPoint = "glGetObjectPtrLabel")] public static extern void GetObjectPtrLabel (IntPtr ptr, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string label);

        [DllImport ("GL", EntryPoint = "glGetPointerv")] public static extern void GetPointerv (uint pname, IntPtr* args);

        [DllImport ("GL", EntryPoint = "glGetProgramBinary")] public static extern void GetProgramBinary (uint program, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPArray)] uint[] binaryFormat, IntPtr binary);

        [DllImport ("GL", EntryPoint = "glGetProgramInfoLog")] public static extern void GetProgramInfoLog (uint program, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, IntPtr infoLog);

        [DllImport ("GL", EntryPoint = "glGetProgramInterfaceiv")] public static extern void GetProgramInterfaceiv (uint program, uint programInterface, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetProgramPipelineInfoLog")] public static extern void GetProgramPipelineInfoLog (uint pipeline, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string infoLog);

        [DllImport ("GL", EntryPoint = "glGetProgramPipelineiv")] public static extern void GetProgramPipelineiv (uint pipeline, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetProgramResourceIndex")] public static extern uint GetProgramResourceIndex (uint program, uint programInterface, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetProgramResourceLocation")] public static extern int GetProgramResourceLocation (uint program, uint programInterface, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetProgramResourceLocationIndex")] public static extern int GetProgramResourceLocationIndex (uint program, uint programInterface, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetProgramResourceName")] public static extern void GetProgramResourceName (uint program, uint programInterface, uint index, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetProgramResourceiv")] public static extern void GetProgramResourceiv (uint program, uint programInterface, uint index, int propCount, [MarshalAs (UnmanagedType.LPArray)] uint[] props, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetProgramStageiv")] public static extern void GetProgramStageiv (uint program, uint shadertype, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] values);

        [DllImport ("GL", EntryPoint = "glGetProgramiv")] public static extern void GetProgramiv (uint program, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetProgramiv")] public static extern void GetProgramiv (uint program, uint pname, out int args);

        [DllImport ("GL", EntryPoint = "glGetQueryBufferObjecti64v")] public static extern void GetQueryBufferObjecti64v (uint id, uint buffer, uint pname, long offset);

        [DllImport ("GL", EntryPoint = "glGetQueryBufferObjectiv")] public static extern void GetQueryBufferObjectiv (uint id, uint buffer, uint pname, long offset);

        [DllImport ("GL", EntryPoint = "glGetQueryBufferObjectui64v")] public static extern void GetQueryBufferObjectui64v (uint id, uint buffer, uint pname, long offset);

        [DllImport ("GL", EntryPoint = "glGetQueryBufferObjectuiv")] public static extern void GetQueryBufferObjectuiv (uint id, uint buffer, uint pname, long offset);

        [DllImport ("GL", EntryPoint = "glGetQueryIndexediv")] public static extern void GetQueryIndexediv (uint target, uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetQueryObjecti64v")] public static extern void GetQueryObjecti64v (uint id, uint pname, [MarshalAs (UnmanagedType.LPArray)] long[] args);

        [DllImport ("GL", EntryPoint = "glGetQueryObjectiv")] public static extern void GetQueryObjectiv (uint id, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetQueryObjectui64v")] public static extern void GetQueryObjectui64v (uint id, uint pname, [MarshalAs (UnmanagedType.LPArray)] ulong[] args);

        [DllImport ("GL", EntryPoint = "glGetQueryObjectuiv")] public static extern void GetQueryObjectuiv (uint id, uint pname, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glGetQueryiv")] public static extern void GetQueryiv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetRenderbufferParameteriv")] public static extern void GetRenderbufferParameteriv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetSamplerParameterIiv")] public static extern void GetSamplerParameterIiv (uint sampler, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetSamplerParameterIuiv")] public static extern void GetSamplerParameterIuiv (uint sampler, uint pname, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glGetSamplerParameterfv")] public static extern void GetSamplerParameterfv (uint sampler, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glGetSamplerParameteriv")] public static extern void GetSamplerParameteriv (uint sampler, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetShaderInfoLog")] public static extern void GetShaderInfoLog (uint shader, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string infoLog);

        [DllImport ("GL", EntryPoint = "glGetShaderPrecisionFormat")] public static extern void GetShaderPrecisionFormat (uint shadertype, uint precisiontype, [MarshalAs (UnmanagedType.LPArray)] int[] range, [MarshalAs (UnmanagedType.LPArray)] int[] precision);

        [DllImport ("GL", EntryPoint = "glGetShaderSource")] public static extern void GetShaderSource (uint shader, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPStr)] string source);

        [DllImport ("GL", EntryPoint = "glGetShaderiv")] public static extern void GetShaderiv (uint shader, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [return: MarshalAs (UnmanagedType.LPStr)] [DllImport ("GL", EntryPoint = "glGetString")] public static extern string GetString (uint name);

        [return: MarshalAs (UnmanagedType.LPStr)] [DllImport ("GL", EntryPoint = "glGetStringi")] public static extern string GetStringi (uint name, uint index);

        [DllImport ("GL", EntryPoint = "glGetSubroutineIndex")] public static extern uint GetSubroutineIndex (uint program, uint shadertype, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetSubroutineUniformLocation")] public static extern int GetSubroutineUniformLocation (uint program, uint shadertype, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetSynciv")] public static extern void GetSynciv (UIntPtr sync, uint pname, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPArray)] int[] values);

        [DllImport ("GL", EntryPoint = "glGetTexImage")] public static extern void GetTexImage (uint target, int level, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glGetTexLevelParameterfv")] public static extern void GetTexLevelParameterfv (uint target, int level, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glGetTexLevelParameteriv")] public static extern void GetTexLevelParameteriv (uint target, int level, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetTexParameterIiv")] public static extern void GetTexParameterIiv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetTexParameterIuiv")] public static extern void GetTexParameterIuiv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glGetTexParameterfv")] public static extern void GetTexParameterfv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glGetTexParameteriv")] public static extern void GetTexParameteriv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetTextureImage")] public static extern void GetTextureImage (uint texture, int level, uint format, uint type, int bufSize, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glGetTextureLevelParameterfv")] public static extern void GetTextureLevelParameterfv (uint texture, int level, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glGetTextureLevelParameteriv")] public static extern void GetTextureLevelParameteriv (uint texture, int level, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetTextureParameterIiv")] public static extern void GetTextureParameterIiv (uint texture, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetTextureParameterIuiv")] public static extern void GetTextureParameterIuiv (uint texture, uint pname, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glGetTextureParameterfv")] public static extern void GetTextureParameterfv (uint texture, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glGetTextureParameteriv")] public static extern void GetTextureParameteriv (uint texture, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetTextureSubImage")] public static extern void GetTextureSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int bufSize, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glGetTransformFeedbackVarying")] public static extern void GetTransformFeedbackVarying (uint program, uint index, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] length, [MarshalAs (UnmanagedType.LPArray)] int[] size, [MarshalAs (UnmanagedType.LPArray)] uint[] type, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetTransformFeedbacki64_v")] public static extern void GetTransformFeedbacki64_v (uint xfb, uint pname, uint index, [MarshalAs (UnmanagedType.LPArray)] long[] param);

        [DllImport ("GL", EntryPoint = "glGetTransformFeedbacki_v")] public static extern void GetTransformFeedbacki_v (uint xfb, uint pname, uint index, [MarshalAs (UnmanagedType.LPArray)] int[] param);

        [DllImport ("GL", EntryPoint = "glGetTransformFeedbackiv")] public static extern void GetTransformFeedbackiv (uint xfb, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] param);

        [DllImport ("GL", EntryPoint = "glGetUniformBlockIndex")] public static extern uint GetUniformBlockIndex (uint program, [MarshalAs (UnmanagedType.LPStr)] string uniformBlockName);

        [DllImport ("GL", EntryPoint = "glGetUniformIndices")] public static extern void GetUniformIndices (uint program, int uniformCount, [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] uniformNames, [MarshalAs (UnmanagedType.LPArray)] uint[] uniformIndices);

        [DllImport ("GL", EntryPoint = "glGetUniformLocation")] public static extern int GetUniformLocation (uint program, [MarshalAs (UnmanagedType.LPStr)] string name);

        [DllImport ("GL", EntryPoint = "glGetUniformSubroutineuiv")] public static extern void GetUniformSubroutineuiv (uint shadertype, int location, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glGetUniformdv")] public static extern void GetUniformdv (uint program, int location, [MarshalAs (UnmanagedType.LPArray)] double[] args);

        [DllImport ("GL", EntryPoint = "glGetUniformfv")] public static extern void GetUniformfv (uint program, int location, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glGetUniformiv")] public static extern void GetUniformiv (uint program, int location, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetUniformuiv")] public static extern void GetUniformuiv (uint program, int location, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glGetVertexArrayIndexed64iv")] public static extern void GetVertexArrayIndexed64iv (uint vaobj, uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] long[] param);

        [DllImport ("GL", EntryPoint = "glGetVertexArrayIndexediv")] public static extern void GetVertexArrayIndexediv (uint vaobj, uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] param);

        [DllImport ("GL", EntryPoint = "glGetVertexArrayiv")] public static extern void GetVertexArrayiv (uint vaobj, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] param);

        [DllImport ("GL", EntryPoint = "glGetVertexAttribIiv")] public static extern void GetVertexAttribIiv (uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetVertexAttribIuiv")] public static extern void GetVertexAttribIuiv (uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glGetVertexAttribLdv")] public static extern void GetVertexAttribLdv (uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] double[] args);

        [DllImport ("GL", EntryPoint = "glGetVertexAttribPointerv")] public static extern void GetVertexAttribPointerv (uint index, uint pname, IntPtr* pointer);

        [DllImport ("GL", EntryPoint = "glGetVertexAttribdv")] public static extern void GetVertexAttribdv (uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] double[] args);

        [DllImport ("GL", EntryPoint = "glGetVertexAttribfv")] public static extern void GetVertexAttribfv (uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glGetVertexAttribiv")] public static extern void GetVertexAttribiv (uint index, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetnColorTable")] public static extern void GetnColorTable (uint target, uint format, uint type, int bufSize, IntPtr table);

        [DllImport ("GL", EntryPoint = "glGetnCompressedTexImage")] public static extern void GetnCompressedTexImage (uint target, int lod, int bufSize, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glGetnConvolutionFilter")] public static extern void GetnConvolutionFilter (uint target, uint format, uint type, int bufSize, IntPtr image);

        [DllImport ("GL", EntryPoint = "glGetnHistogram")] public static extern void GetnHistogram (uint target, [MarshalAs (UnmanagedType.I1)] bool reset, uint format, uint type, int bufSize, IntPtr values);

        [DllImport ("GL", EntryPoint = "glGetnMapdv")] public static extern void GetnMapdv (uint target, uint query, int bufSize, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glGetnMapfv")] public static extern void GetnMapfv (uint target, uint query, int bufSize, [MarshalAs (UnmanagedType.LPArray)] float[] v);

        [DllImport ("GL", EntryPoint = "glGetnMapiv")] public static extern void GetnMapiv (uint target, uint query, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glGetnMinmax")] public static extern void GetnMinmax (uint target, [MarshalAs (UnmanagedType.I1)] bool reset, uint format, uint type, int bufSize, IntPtr values);

        [DllImport ("GL", EntryPoint = "glGetnPixelMapfv")] public static extern void GetnPixelMapfv (uint map, int bufSize, [MarshalAs (UnmanagedType.LPArray)] float[] values);

        [DllImport ("GL", EntryPoint = "glGetnPixelMapuiv")] public static extern void GetnPixelMapuiv (uint map, int bufSize, [MarshalAs (UnmanagedType.LPArray)] uint[] values);

        [DllImport ("GL", EntryPoint = "glGetnPixelMapusv")] public static extern void GetnPixelMapusv (uint map, int bufSize, [MarshalAs (UnmanagedType.LPArray)] ushort[] values);

        [DllImport ("GL", EntryPoint = "glGetnPolygonStipple")] public static extern void GetnPolygonStipple (int bufSize, [MarshalAs (UnmanagedType.LPArray)] byte[] pattern);

        [DllImport ("GL", EntryPoint = "glGetnSeparableFilter")] public static extern void GetnSeparableFilter (uint target, uint format, uint type, int rowBufSize, IntPtr row, int columnBufSize, IntPtr column, IntPtr span);

        [DllImport ("GL", EntryPoint = "glGetnTexImage")] public static extern void GetnTexImage (uint target, int level, uint format, uint type, int bufSize, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glGetnUniformdv")] public static extern void GetnUniformdv (uint program, int location, int bufSize, [MarshalAs (UnmanagedType.LPArray)] double[] args);

        [DllImport ("GL", EntryPoint = "glGetnUniformfv")] public static extern void GetnUniformfv (uint program, int location, int bufSize, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glGetnUniformiv")] public static extern void GetnUniformiv (uint program, int location, int bufSize, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glGetnUniformuiv")] public static extern void GetnUniformuiv (uint program, int location, int bufSize, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glHint")] public static extern void Hint (uint target, uint mode);

        [DllImport ("GL", EntryPoint = "glInvalidateBufferData")] public static extern void InvalidateBufferData (uint buffer);

        [DllImport ("GL", EntryPoint = "glInvalidateBufferSubData")] public static extern void InvalidateBufferSubData (uint buffer, long offset, long length);

        [DllImport ("GL", EntryPoint = "glInvalidateFramebuffer")] public static extern void InvalidateFramebuffer (uint target, int numAttachments, [MarshalAs (UnmanagedType.LPArray)] uint[] attachments);

        [DllImport ("GL", EntryPoint = "glInvalidateNamedFramebufferData")] public static extern void InvalidateNamedFramebufferData (uint framebuffer, int numAttachments, [MarshalAs (UnmanagedType.LPArray)] uint[] attachments);

        [DllImport ("GL", EntryPoint = "glInvalidateNamedFramebufferSubData")] public static extern void InvalidateNamedFramebufferSubData (uint framebuffer, int numAttachments, [MarshalAs (UnmanagedType.LPArray)] uint[] attachments, int x, int y, int width, int height);

        [DllImport ("GL", EntryPoint = "glInvalidateSubFramebuffer")] public static extern void InvalidateSubFramebuffer (uint target, int numAttachments, [MarshalAs (UnmanagedType.LPArray)] uint[] attachments, int x, int y, int width, int height);

        [DllImport ("GL", EntryPoint = "glInvalidateTexImage")] public static extern void InvalidateTexImage (uint texture, int level);

        [DllImport ("GL", EntryPoint = "glInvalidateTexSubImage")] public static extern void InvalidateTexSubImage (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsBuffer")] public static extern bool IsBuffer (uint buffer);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsEnabled")] public static extern bool IsEnabled (uint cap);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsEnabledi")] public static extern bool IsEnabledi (uint target, uint index);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsFramebuffer")] public static extern bool IsFramebuffer (uint framebuffer);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsProgram")] public static extern bool IsProgram (uint program);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsProgramPipeline")] public static extern bool IsProgramPipeline (uint pipeline);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsQuery")] public static extern bool IsQuery (uint id);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsRenderbuffer")] public static extern bool IsRenderbuffer (uint renderbuffer);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsSampler")] public static extern bool IsSampler (uint sampler);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsShader")] public static extern bool IsShader (uint shader);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsSync")] public static extern bool IsSync (UIntPtr sync);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsTexture")] public static extern bool IsTexture (uint texture);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsTransformFeedback")] public static extern bool IsTransformFeedback (uint id);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glIsVertexArray")] public static extern bool IsVertexArray (uint array);

        [DllImport ("GL", EntryPoint = "glLineWidth")] public static extern void LineWidth (float width);

        [DllImport ("GL", EntryPoint = "glLinkProgram")] public static extern void LinkProgram (uint program);

        [DllImport ("GL", EntryPoint = "glLogicOp")] public static extern void LogicOp (uint opcode);

        [DllImport ("GL", EntryPoint = "glMapBuffer")] public static extern IntPtr MapBuffer (uint target, uint access);

        [DllImport ("GL", EntryPoint = "glMapBufferRange")] public static extern IntPtr MapBufferRange (uint target, long offset, long length, uint access);

        [DllImport ("GL", EntryPoint = "glMapNamedBuffer")] public static extern IntPtr MapNamedBuffer (uint buffer, uint access);

        [DllImport ("GL", EntryPoint = "glMapNamedBufferRange")] public static extern IntPtr MapNamedBufferRange (uint buffer, long offset, long length, uint access);

        [DllImport ("GL", EntryPoint = "glMemoryBarrier")] public static extern void MemoryBarrier (uint barriers);

        [DllImport ("GL", EntryPoint = "glMemoryBarrierByRegion")] public static extern void MemoryBarrierByRegion (uint barriers);

        [DllImport ("GL", EntryPoint = "glMinSampleShading")] public static extern void MinSampleShading (float value);

        [DllImport ("GL", EntryPoint = "glMultiDrawArrays")] public static extern void MultiDrawArrays (uint mode, [MarshalAs (UnmanagedType.LPArray)] int[] first, [MarshalAs (UnmanagedType.LPArray)] int[] count, int drawcount);

        [DllImport ("GL", EntryPoint = "glMultiDrawArraysIndirect")] public static extern void MultiDrawArraysIndirect (uint mode, IntPtr indirect, int drawcount, int stride);

        [DllImport ("GL", EntryPoint = "glMultiDrawElements")] public static extern void MultiDrawElements (uint mode, [MarshalAs (UnmanagedType.LPArray)] int[] count, uint type, IntPtr* indices, int drawcount);

        [DllImport ("GL", EntryPoint = "glMultiDrawElementsBaseVertex")] public static extern void MultiDrawElementsBaseVertex (uint mode, [MarshalAs (UnmanagedType.LPArray)] int[] count, uint type, IntPtr* indices, int drawcount, [MarshalAs (UnmanagedType.LPArray)] int[] basevertex);

        [DllImport ("GL", EntryPoint = "glMultiDrawElementsIndirect")] public static extern void MultiDrawElementsIndirect (uint mode, uint type, IntPtr indirect, int drawcount, int stride);

        [DllImport ("GL", EntryPoint = "glMultiTexCoordP1ui")] public static extern void MultiTexCoordP1ui (uint texture, uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glMultiTexCoordP1uiv")] public static extern void MultiTexCoordP1uiv (uint texture, uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glMultiTexCoordP2ui")] public static extern void MultiTexCoordP2ui (uint texture, uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glMultiTexCoordP2uiv")] public static extern void MultiTexCoordP2uiv (uint texture, uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glMultiTexCoordP3ui")] public static extern void MultiTexCoordP3ui (uint texture, uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glMultiTexCoordP3uiv")] public static extern void MultiTexCoordP3uiv (uint texture, uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glMultiTexCoordP4ui")] public static extern void MultiTexCoordP4ui (uint texture, uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glMultiTexCoordP4uiv")] public static extern void MultiTexCoordP4uiv (uint texture, uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glNamedBufferData")] public static extern void NamedBufferData (uint buffer, long size, IntPtr data, uint usage);

        [DllImport ("GL", EntryPoint = "glNamedBufferStorage")] public static extern void NamedBufferStorage (uint buffer, long size, IntPtr data, uint flags);

        [DllImport ("GL", EntryPoint = "glNamedBufferSubData")] public static extern void NamedBufferSubData (uint buffer, long offset, long size, IntPtr data);

        [DllImport ("GL", EntryPoint = "glNamedFramebufferDrawBuffer")] public static extern void NamedFramebufferDrawBuffer (uint framebuffer, uint buf);

        [DllImport ("GL", EntryPoint = "glNamedFramebufferDrawBuffers")] public static extern void NamedFramebufferDrawBuffers (uint framebuffer, int n, [MarshalAs (UnmanagedType.LPArray)] uint[] bufs);

        [DllImport ("GL", EntryPoint = "glNamedFramebufferParameteri")] public static extern void NamedFramebufferParameteri (uint framebuffer, uint pname, int param);

        [DllImport ("GL", EntryPoint = "glNamedFramebufferReadBuffer")] public static extern void NamedFramebufferReadBuffer (uint framebuffer, uint src);

        [DllImport ("GL", EntryPoint = "glNamedFramebufferRenderbuffer")] public static extern void NamedFramebufferRenderbuffer (uint framebuffer, uint attachment, uint renderbuffertarget, uint renderbuffer);

        [DllImport ("GL", EntryPoint = "glNamedFramebufferTexture")] public static extern void NamedFramebufferTexture (uint framebuffer, uint attachment, uint texture, int level);

        [DllImport ("GL", EntryPoint = "glNamedFramebufferTextureLayer")] public static extern void NamedFramebufferTextureLayer (uint framebuffer, uint attachment, uint texture, int level, int layer);

        [DllImport ("GL", EntryPoint = "glNamedRenderbufferStorage")] public static extern void NamedRenderbufferStorage (uint renderbuffer, uint internalformat, int width, int height);

        [DllImport ("GL", EntryPoint = "glNamedRenderbufferStorageMultisample")] public static extern void NamedRenderbufferStorageMultisample (uint renderbuffer, int samples, uint internalformat, int width, int height);

        [DllImport ("GL", EntryPoint = "glNormalP3ui")] public static extern void NormalP3ui (uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glNormalP3uiv")] public static extern void NormalP3uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glObjectLabel")] public static extern void ObjectLabel (uint identifier, uint name, int length, [MarshalAs (UnmanagedType.LPStr)] string label);

        [DllImport ("GL", EntryPoint = "glObjectPtrLabel")] public static extern void ObjectPtrLabel (IntPtr ptr, int length, [MarshalAs (UnmanagedType.LPStr)] string label);

        [DllImport ("GL", EntryPoint = "glPatchParameterfv")] public static extern void PatchParameterfv (uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] values);

        [DllImport ("GL", EntryPoint = "glPatchParameteri")] public static extern void PatchParameteri (uint pname, int value);

        [DllImport ("GL", EntryPoint = "glPauseTransformFeedback")] public static extern void PauseTransformFeedback ();

        [DllImport ("GL", EntryPoint = "glPixelStoref")] public static extern void PixelStoref (uint pname, float param);

        [DllImport ("GL", EntryPoint = "glPixelStorei")] public static extern void PixelStorei (uint pname, int param);

        [DllImport ("GL", EntryPoint = "glPointParameterf")] public static extern void PointParameterf (uint pname, float param);

        [DllImport ("GL", EntryPoint = "glPointParameterfv")] public static extern void PointParameterfv (uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glPointParameteri")] public static extern void PointParameteri (uint pname, int param);

        [DllImport ("GL", EntryPoint = "glPointParameteriv")] public static extern void PointParameteriv (uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glPointSize")] public static extern void PointSize (float size);

        [DllImport ("GL", EntryPoint = "glPolygonMode")] public static extern void PolygonMode (uint face, uint mode);

        [DllImport ("GL", EntryPoint = "glPolygonOffset")] public static extern void PolygonOffset (float factor, float units);

        [DllImport ("GL", EntryPoint = "glPopDebugGroup")] public static extern void PopDebugGroup ();

        [DllImport ("GL", EntryPoint = "glPrimitiveRestartIndex")] public static extern void PrimitiveRestartIndex (uint index);

        [DllImport ("GL", EntryPoint = "glProgramBinary")] public static extern void ProgramBinary (uint program, uint binaryFormat, IntPtr binary, int length);

        [DllImport ("GL", EntryPoint = "glProgramParameteri")] public static extern void ProgramParameteri (uint program, uint pname, int value);

        [DllImport ("GL", EntryPoint = "glProgramUniform1d")] public static extern void ProgramUniform1d (uint program, int location, double v0);

        [DllImport ("GL", EntryPoint = "glProgramUniform1dv")] public static extern void ProgramUniform1dv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform1f")] public static extern void ProgramUniform1f (uint program, int location, float v0);

        [DllImport ("GL", EntryPoint = "glProgramUniform1fv")] public static extern void ProgramUniform1fv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform1i")] public static extern void ProgramUniform1i (uint program, int location, int v0);

        [DllImport ("GL", EntryPoint = "glProgramUniform1iv")] public static extern void ProgramUniform1iv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform1ui")] public static extern void ProgramUniform1ui (uint program, int location, uint v0);

        [DllImport ("GL", EntryPoint = "glProgramUniform1uiv")] public static extern void ProgramUniform1uiv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform2d")] public static extern void ProgramUniform2d (uint program, int location, double v0, double v1);

        [DllImport ("GL", EntryPoint = "glProgramUniform2dv")] public static extern void ProgramUniform2dv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform2f")] public static extern void ProgramUniform2f (uint program, int location, float v0, float v1);

        [DllImport ("GL", EntryPoint = "glProgramUniform2fv")] public static extern void ProgramUniform2fv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform2i")] public static extern void ProgramUniform2i (uint program, int location, int v0, int v1);

        [DllImport ("GL", EntryPoint = "glProgramUniform2iv")] public static extern void ProgramUniform2iv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform2ui")] public static extern void ProgramUniform2ui (uint program, int location, uint v0, uint v1);

        [DllImport ("GL", EntryPoint = "glProgramUniform2uiv")] public static extern void ProgramUniform2uiv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform3d")] public static extern void ProgramUniform3d (uint program, int location, double v0, double v1, double v2);

        [DllImport ("GL", EntryPoint = "glProgramUniform3dv")] public static extern void ProgramUniform3dv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform3f")] public static extern void ProgramUniform3f (uint program, int location, float v0, float v1, float v2);

        [DllImport ("GL", EntryPoint = "glProgramUniform3fv")] public static extern void ProgramUniform3fv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform3i")] public static extern void ProgramUniform3i (uint program, int location, int v0, int v1, int v2);

        [DllImport ("GL", EntryPoint = "glProgramUniform3iv")] public static extern void ProgramUniform3iv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform3ui")] public static extern void ProgramUniform3ui (uint program, int location, uint v0, uint v1, uint v2);

        [DllImport ("GL", EntryPoint = "glProgramUniform3uiv")] public static extern void ProgramUniform3uiv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform4d")] public static extern void ProgramUniform4d (uint program, int location, double v0, double v1, double v2, double v3);

        [DllImport ("GL", EntryPoint = "glProgramUniform4dv")] public static extern void ProgramUniform4dv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform4f")] public static extern void ProgramUniform4f (uint program, int location, float v0, float v1, float v2, float v3);

        [DllImport ("GL", EntryPoint = "glProgramUniform4fv")] public static extern void ProgramUniform4fv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform4i")] public static extern void ProgramUniform4i (uint program, int location, int v0, int v1, int v2, int v3);

        [DllImport ("GL", EntryPoint = "glProgramUniform4iv")] public static extern void ProgramUniform4iv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniform4ui")] public static extern void ProgramUniform4ui (uint program, int location, uint v0, uint v1, uint v2, uint v3);

        [DllImport ("GL", EntryPoint = "glProgramUniform4uiv")] public static extern void ProgramUniform4uiv (uint program, int location, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix2dv")] public static extern void ProgramUniformMatrix2dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix2fv")] public static extern void ProgramUniformMatrix2fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix2x3dv")] public static extern void ProgramUniformMatrix2x3dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix2x3fv")] public static extern void ProgramUniformMatrix2x3fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix2x4dv")] public static extern void ProgramUniformMatrix2x4dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix2x4fv")] public static extern void ProgramUniformMatrix2x4fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix3dv")] public static extern void ProgramUniformMatrix3dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix3fv")] public static extern void ProgramUniformMatrix3fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix3x2dv")] public static extern void ProgramUniformMatrix3x2dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix3x2fv")] public static extern void ProgramUniformMatrix3x2fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix3x4dv")] public static extern void ProgramUniformMatrix3x4dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix3x4fv")] public static extern void ProgramUniformMatrix3x4fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix4dv")] public static extern void ProgramUniformMatrix4dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, IntPtr value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix4fv")] public static extern void ProgramUniformMatrix4fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, IntPtr value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix4x2dv")] public static extern void ProgramUniformMatrix4x2dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix4x2fv")] public static extern void ProgramUniformMatrix4x2fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix4x3dv")] public static extern void ProgramUniformMatrix4x3dv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glProgramUniformMatrix4x3fv")] public static extern void ProgramUniformMatrix4x3fv (uint program, int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glProvokingVertex")] public static extern void ProvokingVertex (uint mode);

        [DllImport ("GL", EntryPoint = "glPushDebugGroup")] public static extern void PushDebugGroup (uint source, uint id, int length, [MarshalAs (UnmanagedType.LPStr)] string message);

        [DllImport ("GL", EntryPoint = "glQueryCounter")] public static extern void QueryCounter (uint id, uint target);

        [DllImport ("GL", EntryPoint = "glReadBuffer")] public static extern void ReadBuffer (uint src);

        [DllImport ("GL", EntryPoint = "glReadPixels")] public static extern void ReadPixels (int x, int y, int width, int height, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glReadnPixels")] public static extern void ReadnPixels (int x, int y, int width, int height, uint format, uint type, int bufSize, IntPtr data);

        [DllImport ("GL", EntryPoint = "glReleaseShaderCompiler")] public static extern void ReleaseShaderCompiler ();

        [DllImport ("GL", EntryPoint = "glRenderbufferStorage")] public static extern void RenderbufferStorage (uint target, uint internalformat, int width, int height);

        [DllImport ("GL", EntryPoint = "glRenderbufferStorageMultisample")] public static extern void RenderbufferStorageMultisample (uint target, int samples, uint internalformat, int width, int height);

        [DllImport ("GL", EntryPoint = "glResumeTransformFeedback")] public static extern void ResumeTransformFeedback ();

        [DllImport ("GL", EntryPoint = "glSampleCoverage")] public static extern void SampleCoverage (float value, [MarshalAs (UnmanagedType.I1)] bool invert);

        [DllImport ("GL", EntryPoint = "glSampleMaski")] public static extern void SampleMaski (uint maskNumber, uint mask);

        [DllImport ("GL", EntryPoint = "glSamplerParameterIiv")] public static extern void SamplerParameterIiv (uint sampler, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] param);

        [DllImport ("GL", EntryPoint = "glSamplerParameterIuiv")] public static extern void SamplerParameterIuiv (uint sampler, uint pname, [MarshalAs (UnmanagedType.LPArray)] uint[] param);

        [DllImport ("GL", EntryPoint = "glSamplerParameterf")] public static extern void SamplerParameterf (uint sampler, uint pname, float param);

        [DllImport ("GL", EntryPoint = "glSamplerParameterfv")] public static extern void SamplerParameterfv (uint sampler, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] param);

        [DllImport ("GL", EntryPoint = "glSamplerParameteri")] public static extern void SamplerParameteri (uint sampler, uint pname, int param);

        [DllImport ("GL", EntryPoint = "glSamplerParameteriv")] public static extern void SamplerParameteriv (uint sampler, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] param);

        [DllImport ("GL", EntryPoint = "glScissor")] public static extern void Scissor (int x, int y, int width, int height);

        [DllImport ("GL", EntryPoint = "glScissorArrayv")] public static extern void ScissorArrayv (uint first, int count, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glScissorIndexed")] public static extern void ScissorIndexed (uint index, int left, int bottom, int width, int height);

        [DllImport ("GL", EntryPoint = "glScissorIndexedv")] public static extern void ScissorIndexedv (uint index, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glSecondaryColorP3ui")] public static extern void SecondaryColorP3ui (uint type, uint color);

        [DllImport ("GL", EntryPoint = "glSecondaryColorP3uiv")] public static extern void SecondaryColorP3uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] color);

        [DllImport ("GL", EntryPoint = "glShaderBinary")] public static extern void ShaderBinary (int count, [MarshalAs (UnmanagedType.LPArray)] uint[] shaders, uint binaryformat, IntPtr binary, int length);

        [DllImport ("GL", EntryPoint = "glShaderSource")] public static extern void ShaderSource (uint shader, int count, [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] strings, [MarshalAs (UnmanagedType.LPArray)] int[] length);

        [DllImport ("GL", EntryPoint = "glShaderStorageBlockBinding")] public static extern void ShaderStorageBlockBinding (uint program, uint storageBlockIndex, uint storageBlockBinding);

        [DllImport ("GL", EntryPoint = "glStencilFunc")] public static extern void StencilFunc (uint func, int refval, uint mask);

        [DllImport ("GL", EntryPoint = "glStencilFuncSeparate")] public static extern void StencilFuncSeparate (uint face, uint func, int refval, uint mask);

        [DllImport ("GL", EntryPoint = "glStencilMask")] public static extern void StencilMask (uint mask);

        [DllImport ("GL", EntryPoint = "glStencilMaskSeparate")] public static extern void StencilMaskSeparate (uint face, uint mask);

        [DllImport ("GL", EntryPoint = "glStencilOp")] public static extern void StencilOp (uint fail, uint zfail, uint zpass);

        [DllImport ("GL", EntryPoint = "glStencilOpSeparate")] public static extern void StencilOpSeparate (uint face, uint sfail, uint dpfail, uint dppass);

        [DllImport ("GL", EntryPoint = "glTexBuffer")] public static extern void TexBuffer (uint target, uint internalformat, uint buffer);

        [DllImport ("GL", EntryPoint = "glTexBufferRange")] public static extern void TexBufferRange (uint target, uint internalformat, uint buffer, long offset, long size);

        [DllImport ("GL", EntryPoint = "glTexCoordP1ui")] public static extern void TexCoordP1ui (uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glTexCoordP1uiv")] public static extern void TexCoordP1uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glTexCoordP2ui")] public static extern void TexCoordP2ui (uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glTexCoordP2uiv")] public static extern void TexCoordP2uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glTexCoordP3ui")] public static extern void TexCoordP3ui (uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glTexCoordP3uiv")] public static extern void TexCoordP3uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glTexCoordP4ui")] public static extern void TexCoordP4ui (uint type, uint coords);

        [DllImport ("GL", EntryPoint = "glTexCoordP4uiv")] public static extern void TexCoordP4uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] coords);

        [DllImport ("GL", EntryPoint = "glTexImage1D")] public static extern void TexImage1D (uint target, int level, int internalformat, int width, int border, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTexImage2D")] public static extern void TexImage2D (uint target, int level, int internalformat, int width, int height, int border, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTexImage2DMultisample")] public static extern void TexImage2DMultisample (uint target, int samples, uint internalformat, int width, int height, [MarshalAs (UnmanagedType.I1)] bool fixedsamplelocations);

        [DllImport ("GL", EntryPoint = "glTexImage3D")] public static extern void TexImage3D (uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTexImage3DMultisample")] public static extern void TexImage3DMultisample (uint target, int samples, uint internalformat, int width, int height, int depth, [MarshalAs (UnmanagedType.I1)] bool fixedsamplelocations);

        [DllImport ("GL", EntryPoint = "glTexParameterIiv")] public static extern void TexParameterIiv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glTexParameterIuiv")] public static extern void TexParameterIuiv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glTexParameterf")] public static extern void TexParameterf (uint target, uint pname, float param);

        [DllImport ("GL", EntryPoint = "glTexParameterfv")] public static extern void TexParameterfv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] args);

        [DllImport ("GL", EntryPoint = "glTexParameteri")] public static extern void TexParameteri (uint target, uint pname, int param);

        [DllImport ("GL", EntryPoint = "glTexParameteriv")] public static extern void TexParameteriv (uint target, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glTexStorage1D")] public static extern void TexStorage1D (uint target, int levels, uint internalformat, int width);

        [DllImport ("GL", EntryPoint = "glTexStorage2D")] public static extern void TexStorage2D (uint target, int levels, uint internalformat, int width, int height);

        [DllImport ("GL", EntryPoint = "glTexStorage2DMultisample")] public static extern void TexStorage2DMultisample (uint target, int samples, uint internalformat, int width, int height, [MarshalAs (UnmanagedType.I1)] bool fixedsamplelocations);

        [DllImport ("GL", EntryPoint = "glTexStorage3D")] public static extern void TexStorage3D (uint target, int levels, uint internalformat, int width, int height, int depth);

        [DllImport ("GL", EntryPoint = "glTexStorage3DMultisample")] public static extern void TexStorage3DMultisample (uint target, int samples, uint internalformat, int width, int height, int depth, [MarshalAs (UnmanagedType.I1)] bool fixedsamplelocations);

        [DllImport ("GL", EntryPoint = "glTexSubImage1D")] public static extern void TexSubImage1D (uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTexSubImage2D")] public static extern void TexSubImage2D (uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTexSubImage3D")] public static extern void TexSubImage3D (uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTextureBarrier")] public static extern void TextureBarrier ();

        [DllImport ("GL", EntryPoint = "glTextureBuffer")] public static extern void TextureBuffer (uint texture, uint internalformat, uint buffer);

        [DllImport ("GL", EntryPoint = "glTextureBufferRange")] public static extern void TextureBufferRange (uint texture, uint internalformat, uint buffer, long offset, long size);

        [DllImport ("GL", EntryPoint = "glTextureParameterIiv")] public static extern void TextureParameterIiv (uint texture, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] args);

        [DllImport ("GL", EntryPoint = "glTextureParameterIuiv")] public static extern void TextureParameterIuiv (uint texture, uint pname, [MarshalAs (UnmanagedType.LPArray)] uint[] args);

        [DllImport ("GL", EntryPoint = "glTextureParameterf")] public static extern void TextureParameterf (uint texture, uint pname, float param);

        [DllImport ("GL", EntryPoint = "glTextureParameterfv")] public static extern void TextureParameterfv (uint texture, uint pname, [MarshalAs (UnmanagedType.LPArray)] float[] param);

        [DllImport ("GL", EntryPoint = "glTextureParameteri")] public static extern void TextureParameteri (uint texture, uint pname, int param);

        [DllImport ("GL", EntryPoint = "glTextureParameteriv")] public static extern void TextureParameteriv (uint texture, uint pname, [MarshalAs (UnmanagedType.LPArray)] int[] param);

        [DllImport ("GL", EntryPoint = "glTextureStorage1D")] public static extern void TextureStorage1D (uint texture, int levels, uint internalformat, int width);

        [DllImport ("GL", EntryPoint = "glTextureStorage2D")] public static extern void TextureStorage2D (uint texture, int levels, uint internalformat, int width, int height);

        [DllImport ("GL", EntryPoint = "glTextureStorage2DMultisample")] public static extern void TextureStorage2DMultisample (uint texture, int samples, uint internalformat, int width, int height, [MarshalAs (UnmanagedType.I1)] bool fixedsamplelocations);

        [DllImport ("GL", EntryPoint = "glTextureStorage3D")] public static extern void TextureStorage3D (uint texture, int levels, uint internalformat, int width, int height, int depth);

        [DllImport ("GL", EntryPoint = "glTextureStorage3DMultisample")] public static extern void TextureStorage3DMultisample (uint texture, int samples, uint internalformat, int width, int height, int depth, [MarshalAs (UnmanagedType.I1)] bool fixedsamplelocations);

        [DllImport ("GL", EntryPoint = "glTextureSubImage1D")] public static extern void TextureSubImage1D (uint texture, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTextureSubImage2D")] public static extern void TextureSubImage2D (uint texture, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTextureSubImage3D")] public static extern void TextureSubImage3D (uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels);

        [DllImport ("GL", EntryPoint = "glTextureView")] public static extern void TextureView (uint texture, uint target, uint origtexture, uint internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);

        [DllImport ("GL", EntryPoint = "glTransformFeedbackBufferBase")] public static extern void TransformFeedbackBufferBase (uint xfb, uint index, uint buffer);

        [DllImport ("GL", EntryPoint = "glTransformFeedbackBufferRange")] public static extern void TransformFeedbackBufferRange (uint xfb, uint index, uint buffer, long offset, long size);

        [DllImport ("GL", EntryPoint = "glTransformFeedbackVaryings")] public static extern void TransformFeedbackVaryings (uint program, int count, [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] varyings, uint bufferMode);

        [DllImport ("GL", EntryPoint = "glUniform1d")] public static extern void Uniform1d (int location, double x);

        [DllImport ("GL", EntryPoint = "glUniform1dv")] public static extern void Uniform1dv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniform1f")] public static extern void Uniform1f (int location, float v0);

        [DllImport ("GL", EntryPoint = "glUniform1fv")] public static extern void Uniform1fv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniform1i")] public static extern void Uniform1i (int location, int v0);

        [DllImport ("GL", EntryPoint = "glUniform1iv")] public static extern void Uniform1iv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glUniform1ui")] public static extern void Uniform1ui (int location, uint v0);

        [DllImport ("GL", EntryPoint = "glUniform1uiv")] public static extern void Uniform1uiv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glUniform2d")] public static extern void Uniform2d (int location, double x, double y);

        [DllImport ("GL", EntryPoint = "glUniform2dv")] public static extern void Uniform2dv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniform2f")] public static extern void Uniform2f (int location, float v0, float v1);

        [DllImport ("GL", EntryPoint = "glUniform2fv")] public static extern void Uniform2fv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniform2i")] public static extern void Uniform2i (int location, int v0, int v1);

        [DllImport ("GL", EntryPoint = "glUniform2iv")] public static extern void Uniform2iv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glUniform2ui")] public static extern void Uniform2ui (int location, uint v0, uint v1);

        [DllImport ("GL", EntryPoint = "glUniform2uiv")] public static extern void Uniform2uiv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glUniform3d")] public static extern void Uniform3d (int location, double x, double y, double z);

        [DllImport ("GL", EntryPoint = "glUniform3dv")] public static extern void Uniform3dv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniform3f")] public static extern void Uniform3f (int location, float v0, float v1, float v2);

        [DllImport ("GL", EntryPoint = "glUniform3fv")] public static extern void Uniform3fv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniform3i")] public static extern void Uniform3i (int location, int v0, int v1, int v2);

        [DllImport ("GL", EntryPoint = "glUniform3iv")] public static extern void Uniform3iv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glUniform3ui")] public static extern void Uniform3ui (int location, uint v0, uint v1, uint v2);

        [DllImport ("GL", EntryPoint = "glUniform3uiv")] public static extern void Uniform3uiv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glUniform4d")] public static extern void Uniform4d (int location, double x, double y, double z, double w);

        [DllImport ("GL", EntryPoint = "glUniform4dv")] public static extern void Uniform4dv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniform4f")] public static extern void Uniform4f (int location, float v0, float v1, float v2, float v3);

        [DllImport ("GL", EntryPoint = "glUniform4fv")] public static extern void Uniform4fv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniform4i")] public static extern void Uniform4i (int location, int v0, int v1, int v2, int v3);

        [DllImport ("GL", EntryPoint = "glUniform4iv")] public static extern void Uniform4iv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] int[] value);

        [DllImport ("GL", EntryPoint = "glUniform4ui")] public static extern void Uniform4ui (int location, uint v0, uint v1, uint v2, uint v3);

        [DllImport ("GL", EntryPoint = "glUniform4uiv")] public static extern void Uniform4uiv (int location, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glUniformBlockBinding")] public static extern void UniformBlockBinding (uint program, uint uniformBlockIndex, uint uniformBlockBinding);

        [DllImport ("GL", EntryPoint = "glUniformMatrix2dv")] public static extern void UniformMatrix2dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix2fv")] public static extern void UniformMatrix2fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix2x3dv")] public static extern void UniformMatrix2x3dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix2x3fv")] public static extern void UniformMatrix2x3fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix2x4dv")] public static extern void UniformMatrix2x4dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix2x4fv")] public static extern void UniformMatrix2x4fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix3dv")] public static extern void UniformMatrix3dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix3fv")] public static extern void UniformMatrix3fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix3x2dv")] public static extern void UniformMatrix3x2dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix3x2fv")] public static extern void UniformMatrix3x2fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix3x4dv")] public static extern void UniformMatrix3x4dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix3x4fv")] public static extern void UniformMatrix3x4fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix4dv")] public static extern void UniformMatrix4dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix4fv")] public static extern void UniformMatrix4fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix4x2dv")] public static extern void UniformMatrix4x2dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix4x2fv")] public static extern void UniformMatrix4x2fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix4x3dv")] public static extern void UniformMatrix4x3dv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] double[] value);

        [DllImport ("GL", EntryPoint = "glUniformMatrix4x3fv")] public static extern void UniformMatrix4x3fv (int location, int count, [MarshalAs (UnmanagedType.I1)] bool transpose, [MarshalAs (UnmanagedType.LPArray)] float[] value);

        [DllImport ("GL", EntryPoint = "glUniformSubroutinesuiv")] public static extern void UniformSubroutinesuiv (uint shadertype, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] indices);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glUnmapBuffer")] public static extern bool UnmapBuffer (uint target);

        [return: MarshalAs (UnmanagedType.I1)] [DllImport ("GL", EntryPoint = "glUnmapNamedBuffer")] public static extern bool UnmapNamedBuffer (uint buffer);

        [DllImport ("GL", EntryPoint = "glUseProgram")] public static extern void UseProgram (uint program);

        [DllImport ("GL", EntryPoint = "glUseProgramStages")] public static extern void UseProgramStages (uint pipeline, uint stages, uint program);

        [DllImport ("GL", EntryPoint = "glValidateProgram")] public static extern void ValidateProgram (uint program);

        [DllImport ("GL", EntryPoint = "glValidateProgramPipeline")] public static extern void ValidateProgramPipeline (uint pipeline);

        [DllImport ("GL", EntryPoint = "glVertexArrayAttribBinding")] public static extern void VertexArrayAttribBinding (uint vaobj, uint attribindex, uint bindingindex);

        [DllImport ("GL", EntryPoint = "glVertexArrayAttribFormat")] public static extern void VertexArrayAttribFormat (uint vaobj, uint attribindex, int size, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, uint relativeoffset);

        [DllImport ("GL", EntryPoint = "glVertexArrayAttribIFormat")] public static extern void VertexArrayAttribIFormat (uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport ("GL", EntryPoint = "glVertexArrayAttribLFormat")] public static extern void VertexArrayAttribLFormat (uint vaobj, uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport ("GL", EntryPoint = "glVertexArrayBindingDivisor")] public static extern void VertexArrayBindingDivisor (uint vaobj, uint bindingindex, uint divisor);

        [DllImport ("GL", EntryPoint = "glVertexArrayElementBuffer")] public static extern void VertexArrayElementBuffer (uint vaobj, uint buffer);

        [DllImport ("GL", EntryPoint = "glVertexArrayVertexBuffer")] public static extern void VertexArrayVertexBuffer (uint vaobj, uint bindingindex, uint buffer, long offset, int stride);

        [DllImport ("GL", EntryPoint = "glVertexArrayVertexBuffers")] public static extern void VertexArrayVertexBuffers (uint vaobj, uint first, int count, [MarshalAs (UnmanagedType.LPArray)] uint[] buffers, [MarshalAs (UnmanagedType.LPArray)] long[] offsets, [MarshalAs (UnmanagedType.LPArray)] int[] strides);

        [DllImport ("GL", EntryPoint = "glVertexAttrib1d")] public static extern void VertexAttrib1d (uint index, double x);

        [DllImport ("GL", EntryPoint = "glVertexAttrib1dv")] public static extern void VertexAttrib1dv (uint index, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib1f")] public static extern void VertexAttrib1f (uint index, float x);

        [DllImport ("GL", EntryPoint = "glVertexAttrib1fv")] public static extern void VertexAttrib1fv (uint index, [MarshalAs (UnmanagedType.LPArray)] float[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib1s")] public static extern void VertexAttrib1s (uint index, short x);

        [DllImport ("GL", EntryPoint = "glVertexAttrib1sv")] public static extern void VertexAttrib1sv (uint index, [MarshalAs (UnmanagedType.LPArray)] short[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib2d")] public static extern void VertexAttrib2d (uint index, double x, double y);

        [DllImport ("GL", EntryPoint = "glVertexAttrib2dv")] public static extern void VertexAttrib2dv (uint index, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib2f")] public static extern void VertexAttrib2f (uint index, float x, float y);

        [DllImport ("GL", EntryPoint = "glVertexAttrib2fv")] public static extern void VertexAttrib2fv (uint index, [MarshalAs (UnmanagedType.LPArray)] float[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib2s")] public static extern void VertexAttrib2s (uint index, short x, short y);

        [DllImport ("GL", EntryPoint = "glVertexAttrib2sv")] public static extern void VertexAttrib2sv (uint index, [MarshalAs (UnmanagedType.LPArray)] short[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib3d")] public static extern void VertexAttrib3d (uint index, double x, double y, double z);

        [DllImport ("GL", EntryPoint = "glVertexAttrib3dv")] public static extern void VertexAttrib3dv (uint index, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib3f")] public static extern void VertexAttrib3f (uint index, float x, float y, float z);

        [DllImport ("GL", EntryPoint = "glVertexAttrib3fv")] public static extern void VertexAttrib3fv (uint index, [MarshalAs (UnmanagedType.LPArray)] float[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib3s")] public static extern void VertexAttrib3s (uint index, short x, short y, short z);

        [DllImport ("GL", EntryPoint = "glVertexAttrib3sv")] public static extern void VertexAttrib3sv (uint index, [MarshalAs (UnmanagedType.LPArray)] short[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4Nbv")] public static extern void VertexAttrib4Nbv (uint index, [MarshalAs (UnmanagedType.LPArray)] sbyte[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4Niv")] public static extern void VertexAttrib4Niv (uint index, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4Nsv")] public static extern void VertexAttrib4Nsv (uint index, [MarshalAs (UnmanagedType.LPArray)] short[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4Nub")] public static extern void VertexAttrib4Nub (uint index, byte x, byte y, byte z, byte w);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4Nubv")] public static extern void VertexAttrib4Nubv (uint index, [MarshalAs (UnmanagedType.LPArray)] byte[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4Nuiv")] public static extern void VertexAttrib4Nuiv (uint index, [MarshalAs (UnmanagedType.LPArray)] uint[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4Nusv")] public static extern void VertexAttrib4Nusv (uint index, [MarshalAs (UnmanagedType.LPArray)] ushort[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4bv")] public static extern void VertexAttrib4bv (uint index, [MarshalAs (UnmanagedType.LPArray)] sbyte[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4d")] public static extern void VertexAttrib4d (uint index, double x, double y, double z, double w);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4dv")] public static extern void VertexAttrib4dv (uint index, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4f")] public static extern void VertexAttrib4f (uint index, float x, float y, float z, float w);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4fv")] public static extern void VertexAttrib4fv (uint index, [MarshalAs (UnmanagedType.LPArray)] float[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4iv")] public static extern void VertexAttrib4iv (uint index, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4s")] public static extern void VertexAttrib4s (uint index, short x, short y, short z, short w);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4sv")] public static extern void VertexAttrib4sv (uint index, [MarshalAs (UnmanagedType.LPArray)] short[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4ubv")] public static extern void VertexAttrib4ubv (uint index, [MarshalAs (UnmanagedType.LPArray)] byte[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4uiv")] public static extern void VertexAttrib4uiv (uint index, [MarshalAs (UnmanagedType.LPArray)] uint[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttrib4usv")] public static extern void VertexAttrib4usv (uint index, [MarshalAs (UnmanagedType.LPArray)] ushort[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribBinding")] public static extern void VertexAttribBinding (uint attribindex, uint bindingindex);

        [DllImport ("GL", EntryPoint = "glVertexAttribDivisor")] public static extern void VertexAttribDivisor (uint index, uint divisor);

        [DllImport ("GL", EntryPoint = "glVertexAttribFormat")] public static extern void VertexAttribFormat (uint attribindex, int size, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, uint relativeoffset);

        [DllImport ("GL", EntryPoint = "glVertexAttribI1i")] public static extern void VertexAttribI1i (uint index, int x);

        [DllImport ("GL", EntryPoint = "glVertexAttribI1iv")] public static extern void VertexAttribI1iv (uint index, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI1ui")] public static extern void VertexAttribI1ui (uint index, uint x);

        [DllImport ("GL", EntryPoint = "glVertexAttribI1uiv")] public static extern void VertexAttribI1uiv (uint index, [MarshalAs (UnmanagedType.LPArray)] uint[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI2i")] public static extern void VertexAttribI2i (uint index, int x, int y);

        [DllImport ("GL", EntryPoint = "glVertexAttribI2iv")] public static extern void VertexAttribI2iv (uint index, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI2ui")] public static extern void VertexAttribI2ui (uint index, uint x, uint y);

        [DllImport ("GL", EntryPoint = "glVertexAttribI2uiv")] public static extern void VertexAttribI2uiv (uint index, [MarshalAs (UnmanagedType.LPArray)] uint[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI3i")] public static extern void VertexAttribI3i (uint index, int x, int y, int z);

        [DllImport ("GL", EntryPoint = "glVertexAttribI3iv")] public static extern void VertexAttribI3iv (uint index, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI3ui")] public static extern void VertexAttribI3ui (uint index, uint x, uint y, uint z);

        [DllImport ("GL", EntryPoint = "glVertexAttribI3uiv")] public static extern void VertexAttribI3uiv (uint index, [MarshalAs (UnmanagedType.LPArray)] uint[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI4bv")] public static extern void VertexAttribI4bv (uint index, [MarshalAs (UnmanagedType.LPArray)] sbyte[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI4i")] public static extern void VertexAttribI4i (uint index, int x, int y, int z, int w);

        [DllImport ("GL", EntryPoint = "glVertexAttribI4iv")] public static extern void VertexAttribI4iv (uint index, [MarshalAs (UnmanagedType.LPArray)] int[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI4sv")] public static extern void VertexAttribI4sv (uint index, [MarshalAs (UnmanagedType.LPArray)] short[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI4ubv")] public static extern void VertexAttribI4ubv (uint index, [MarshalAs (UnmanagedType.LPArray)] byte[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI4ui")] public static extern void VertexAttribI4ui (uint index, uint x, uint y, uint z, uint w);

        [DllImport ("GL", EntryPoint = "glVertexAttribI4uiv")] public static extern void VertexAttribI4uiv (uint index, [MarshalAs (UnmanagedType.LPArray)] uint[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribI4usv")] public static extern void VertexAttribI4usv (uint index, [MarshalAs (UnmanagedType.LPArray)] ushort[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribIFormat")] public static extern void VertexAttribIFormat (uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport ("GL", EntryPoint = "glVertexAttribIPointer")] public static extern void VertexAttribIPointer (uint index, int size, uint type, int stride, IntPtr pointer);

        [DllImport ("GL", EntryPoint = "glVertexAttribL1d")] public static extern void VertexAttribL1d (uint index, double x);

        [DllImport ("GL", EntryPoint = "glVertexAttribL1dv")] public static extern void VertexAttribL1dv (uint index, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribL2d")] public static extern void VertexAttribL2d (uint index, double x, double y);

        [DllImport ("GL", EntryPoint = "glVertexAttribL2dv")] public static extern void VertexAttribL2dv (uint index, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribL3d")] public static extern void VertexAttribL3d (uint index, double x, double y, double z);

        [DllImport ("GL", EntryPoint = "glVertexAttribL3dv")] public static extern void VertexAttribL3dv (uint index, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribL4d")] public static extern void VertexAttribL4d (uint index, double x, double y, double z, double w);

        [DllImport ("GL", EntryPoint = "glVertexAttribL4dv")] public static extern void VertexAttribL4dv (uint index, [MarshalAs (UnmanagedType.LPArray)] double[] v);

        [DllImport ("GL", EntryPoint = "glVertexAttribLFormat")] public static extern void VertexAttribLFormat (uint attribindex, int size, uint type, uint relativeoffset);

        [DllImport ("GL", EntryPoint = "glVertexAttribLPointer")] public static extern void VertexAttribLPointer (uint index, int size, uint type, int stride, IntPtr pointer);

        [DllImport ("GL", EntryPoint = "glVertexAttribP1ui")] public static extern void VertexAttribP1ui (uint index, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, uint value);

        [DllImport ("GL", EntryPoint = "glVertexAttribP1uiv")] public static extern void VertexAttribP1uiv (uint index, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glVertexAttribP2ui")] public static extern void VertexAttribP2ui (uint index, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, uint value);

        [DllImport ("GL", EntryPoint = "glVertexAttribP2uiv")] public static extern void VertexAttribP2uiv (uint index, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glVertexAttribP3ui")] public static extern void VertexAttribP3ui (uint index, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, uint value);

        [DllImport ("GL", EntryPoint = "glVertexAttribP3uiv")] public static extern void VertexAttribP3uiv (uint index, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glVertexAttribP4ui")] public static extern void VertexAttribP4ui (uint index, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, uint value);

        [DllImport ("GL", EntryPoint = "glVertexAttribP4uiv")] public static extern void VertexAttribP4uiv (uint index, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glVertexAttribPointer")] public static extern void VertexAttribPointer (uint index, int size, uint type, [MarshalAs (UnmanagedType.I1)] bool normalized, int stride, IntPtr pointer);

        [DllImport ("GL", EntryPoint = "glVertexBindingDivisor")] public static extern void VertexBindingDivisor (uint bindingindex, uint divisor);

        [DllImport ("GL", EntryPoint = "glVertexP2ui")] public static extern void VertexP2ui (uint type, uint value);

        [DllImport ("GL", EntryPoint = "glVertexP2uiv")] public static extern void VertexP2uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glVertexP3ui")] public static extern void VertexP3ui (uint type, uint value);

        [DllImport ("GL", EntryPoint = "glVertexP3uiv")] public static extern void VertexP3uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glVertexP4ui")] public static extern void VertexP4ui (uint type, uint value);

        [DllImport ("GL", EntryPoint = "glVertexP4uiv")] public static extern void VertexP4uiv (uint type, [MarshalAs (UnmanagedType.LPArray)] uint[] value);

        [DllImport ("GL", EntryPoint = "glViewport")] public static extern void Viewport (int x, int y, int width, int height);

        [DllImport ("GL", EntryPoint = "glViewportArrayv")] public static extern void ViewportArrayv (uint first, int count, [MarshalAs (UnmanagedType.LPArray)] float[] v);

        [DllImport ("GL", EntryPoint = "glViewportIndexedf")] public static extern void ViewportIndexedf (uint index, float x, float y, float w, float h);

        [DllImport ("GL", EntryPoint = "glViewportIndexedfv")] public static extern void ViewportIndexedfv (uint index, [MarshalAs (UnmanagedType.LPArray)] float[] v);

        [DllImport ("GL", EntryPoint = "glWaitSync")] public static extern void WaitSync (UIntPtr sync, uint flags, ulong timeout);

        public const uint SHADER_INCLUDE = 0x8DAE;

        [DllImport ("GL", EntryPoint = "glNamedStringARB")] public static extern void NamedString (uint type, int namelen, [MarshalAs (UnmanagedType.LPStr)] string name, int stringlen, [MarshalAs (UnmanagedType.LPStr)] string str);

        [DllImport ("GL", EntryPoint = "glCompileShaderIncludeARB")] public static extern void CompileShaderInclude (uint shared, uint count, [MarshalAs (UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] paths, [MarshalAs (UnmanagedType.LPArray)] int[] lengths);

    public const uint SCALED_RESOLVE_FASTEST = 0x90BA;
    public const uint SCALED_RESOLVE_NICEST = 0x90BB;

    }

}
