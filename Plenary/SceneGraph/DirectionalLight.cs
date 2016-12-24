using System;
using Plenary.Math;
using Plenary.Interop;
using Plenary.OpenGL;

namespace Plenary.SceneGraph {

  public class DirectionalLight : PassRenderer {

    public Mat4f Transform = Mat4f.Eye, Projection = Mat4f.Eye;
    public Vec3f Color;
    public float Intensity;

    public Framebuffer Framebuffer;
    public Texture Shadowmap;
    public Uniforms Uniforms = new Uniforms();

    public int ShadowResolution;

    public DirectionalLight (Mat4f transform, Vec3f color, float intensity, Mat4f projection, int resolution) {
      Transform = transform;
      Color = color;
      Intensity = intensity;
      Projection = projection;
      ShadowResolution = resolution;
      Shadowmap = new Texture(ShadowResolution, ShadowResolution, GL.RG32F);
      Uniforms["scene.lights[0].position"] = Transform.TransformPoint(Vec3f.Zero);
      Uniforms["scene.lights[0].transform"] = Projection * Transform.Inverse;
      Uniforms["scene.lights[0].color"] = new Vec4f(color, Intensity);
      Uniforms["lightmaps[0]"] = Shadowmap;
      Framebuffer = new Framebuffer(ShadowResolution, ShadowResolution);
      Framebuffer.Attach(GL.COLOR_ATTACHMENT0, Shadowmap);
      Framebuffer.Attach(GL.DEPTH_ATTACHMENT, new Renderbuffer(ShadowResolution, ShadowResolution, format: GL.DEPTH_COMPONENT16));
    }

    public override void RenderShadows (Manager m) {
      Framebuffer.Bind();
      GL.Viewport(0, 0, ShadowResolution, ShadowResolution);
      GL.ClearDepth(1);
      GL.ClearColor(1, 1, 1, 1);
      GL.Clear(GL.COLOR_BUFFER_BIT | GL.DEPTH_BUFFER_BIT);
      GL.Enable(GL.DEPTH_TEST);
      GL.Disable(GL.CULL_FACE);
      m.Uniforms["scene.projection"] = Projection;
      m.Uniforms["scene.view"] = Transform.Inverse;
    }

    public override void RenderForward (Manager m) {
      m.Render(Uniforms);
    }

  }

}

