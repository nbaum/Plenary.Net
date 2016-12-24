using Plenary.Interop;
using System.IO;
using Minimod.PrettyPrint;

namespace Plenary.OpenGL
{
    public class NamedString
    {

        public string name;

        public static void ImportDirectory (string path)
        {
            var di = new DirectoryInfo (path);
            foreach (var fi in di.GetFiles ("*.glsl", SearchOption.AllDirectories))
                new NamedString ("/" + fi.Name, fi.OpenText().ReadToEnd());
        }

        public NamedString (string name, string str)
        {
            GL.NamedString (GL.SHADER_INCLUDE, name.Length, name, str.Length, str);
            GL.CheckErrors ();
        }

    }

}
