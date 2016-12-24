using System;
using System.Runtime.InteropServices;
using Plenary.Interop;
using Plenary.Primitives;
using Plenary.SceneGraph;
using Plenary.OpenGL;
using Plenary.Math;
using Plenary.UI;
using Minimod.PrettyPrint;

namespace Test {
  
  class MainClass {
    
    public static void Main (string[] args) {
      var w = new Window();

//      Set up GL state.
      GL.Enable(GL.SAMPLE_ALPHA_TO_COVERAGE);
//      GL.ClampColor(GL.CLAMP_READ_COLOR, GL.FALSE);
//      GL.ClampColor(0x891A, GL.FALSE);
//      GL.ClampColor(0x891B, GL.FALSE);

      // Initialize scene manager
      var m = new Manager();
      m.Uniforms["scene.model"] = Mat4f.Eye;

      // Build mesh
      var shipmat = new Material(new Program("Assets/Shaders/pbr.frag", "Assets/Shaders/standard.vert"),
                                 new Program("Assets/Shaders/shadow.frag", "Assets/Shaders/standard.vert"));
      var shipuni = new Uniforms();
      shipuni["albedo"] = new Texture("Assets/images/ship/albedo.png");
      shipuni["emission"] = new Texture("Assets/images/ship/emission.png");
      shipuni["ao"] = new Texture("Assets/images/ship/ao0.png");
      shipuni["matprops"] = new Texture("Assets/images/ship/matprops.png");
      var mesh = new Mesh("/home/nathan/src/plenary/assets/meshes/ship.asif");
      var content = new IRenderable[] { shipuni, shipmat, mesh };

      // Create light
      var light = new DirectionalLight(Mat4f.Rotate(0, 45.Deg2Rad(), 0) * Mat4f.Rotate(-45.Deg2Rad(), 0, 0) * Mat4f.Translate(0, 0, 20),
                                       new Vec3f(1, 1, 1), 3,
                                       Mat4f.Ortho(17, 1, 1 / 16, 30), 2048);

      // Create camera
      var camera = new Camera(Mat4f.Translate(0, 0, 14), Mat4f.Perspective(Math.PI / 180 * 60, 1080.0 / 1920, 0.1, 30),
                              new Material(new Program("Assets/Shaders/skybox.frag", "Assets/Shaders/skybox.vert"), null),
                              new Texture ("Assets/images/background.jpg"),
                              new Texture ("Assets/images/irradiance.jpg"),
                              1920, 1080);

      var filter1 = new Filter("Assets/Shaders/glare.frag", camera.Width, camera.Height).Uniform("dir", new Vec2f(1, 1));
      var filter2 = new Filter("Assets/Shaders/glare.frag", camera.Width, camera.Height).Uniform("dir", new Vec2f(1, -1));

      w.Show();
      Vec3f axis = new Vec3f(new System.Random().NextDouble(),
                             new System.Random().NextDouble(),
                             new System.Random().NextDouble()).Normalized;

      for (var t = 0.0; t < 1000000; ++t) {
        m.Tick();
        m.Uniforms["scene.model"] = Mat4f.Rotate(m.Time * 0.1, axis.X, axis.Y, axis.Z);

        m.stage = RenderStage.Shadows;
        m.Render(light);
        m.Render(content);

        m.stage = RenderStage.Forward;
        m.Render(camera);
        m.Render(light);
        m.Render(content);

        m.stage = RenderStage.Filters;
        m.Render(filter1);
        m.Render(filter2);

        Framebuffer.Bound.BlitTo(Framebuffer.Default);
        w.SwapBuffers();
        m.Tock(1 / 30.0);
      }

    }

  }

}
