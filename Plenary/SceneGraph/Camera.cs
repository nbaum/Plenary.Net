using System;
using Plenary.Math;
using Plenary.Interop;
using Plenary.Primitives;
using Plenary.OpenGL;

namespace Plenary.SceneGraph {

  public class Camera : PassRenderer {

    public Mat4f Transform, Projection, InverseTransform;
    public Uniforms Uniforms = new Uniforms();
    public Framebuffer Framebuffer;
    public Material SkyboxMaterial;
    public Mesh SkyboxMesh;
    public int Width, Height;

    public Camera (Mat4f transform, Mat4f projection, Material skybox, Texture environment, Texture irradiance, int width, int height) {
      Transform = transform;
      InverseTransform = transform.Inverse;
      Projection = projection;
      Width = width;
      Height = height;
      Uniforms["scene.projection"] = Projection;
      Uniforms["scene.view"] = InverseTransform;
      Uniforms["environment"] = environment;
      Uniforms["irradiance"] = irradiance;
      SkyboxMaterial = skybox;
      SkyboxMesh = new Cube();
      Framebuffer = new Framebuffer(Width, Height);
      Framebuffer.Attach(GL.COLOR_ATTACHMENT0, new Renderbuffer(Width, Height, samples: 8, format: GL.RGBA16F));
      Framebuffer.Attach(GL.DEPTH_ATTACHMENT, new Renderbuffer(Width, Height, samples: 8, format: GL.DEPTH_COMPONENT16));
    }

    public override void RenderForward (Manager m) {
      Framebuffer.Bind();
      GL.Viewport(0, 0, Width, Height);
      GL.ClearDepth(1);
      GL.ClearColor(0, 0, 0.1f, 1);
      GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
      m.Render(Uniforms);
      m.Render(SkyboxMaterial);
      GL.Disable(GL.DEPTH_TEST);
      GL.Disable(GL.CULL_FACE);
      m.Render(SkyboxMesh);
      GL.Clear(GL.DEPTH_BUFFER_BIT);
      GL.Enable(GL.DEPTH_TEST);
    }

  }

}

