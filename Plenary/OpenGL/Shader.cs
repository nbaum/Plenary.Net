using Plenary.Interop;

namespace Plenary.OpenGL
{
  
    public class Shader : Named
    {
    
        const string preamble = "#version 450\n#extension GL_ARB_shading_language_include : require\n";

        public Shader (uint type)
        {
            Name = GL.CreateShader (type);
            GL.CheckErrors ();
        }

        public override void Dispose ()
        {
            GL.DeleteShader (Name);
        }

        public Shader Source (string source, string name = "(input)", int line = 1)
        {
            var strings = new[] {
                preamble,
                string.Format("#line {0} \"{1}\"\n", line, name),
                source
            };
            GL.ShaderSource (Name, strings.Length, strings, null);
            GL.CheckErrors ();
            return Compile ();
        }

        public Shader Compile ()
        {
            GL.CompileShaderInclude (Name, 0, null, null);
            GL.CheckErrors ();
            return this;
        }

    }

}
