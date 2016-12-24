using System;
using Plenary.OpenGL;
using Plenary.Primitives;
using Plenary.Interop;

namespace Plenary.SceneGraph {

  public class Filter : IRenderable {

    public Program Program;
    public Uniforms Uniforms;
    public Mesh Mesh;
    public Framebuffer Source, Dest;
    public Texture ColorMap, DepthMap;
    public int Width, Height;

    public Filter (string source, int width, int height) {
      Width = width;
      Height = height;
      Program = new Program("Assets/Shaders/filter.vert", source);
      Uniforms = new Uniforms();
      Mesh = new Rect();
      ColorMap = new Texture(Width, Height, GL.RGBA16F).NearestFilter().BorderClamp();
      DepthMap = new Texture(Width, Height, GL.DEPTH_COMPONENT16);
      Source = new Framebuffer(Width, Height);
      Source.Attach(GL.COLOR_ATTACHMENT0, ColorMap);
      Source.Attach(GL.DEPTH_ATTACHMENT, DepthMap);
      Dest = new Framebuffer(Width, Height);
      Dest.Attach(GL.COLOR_ATTACHMENT0, new Renderbuffer(Width, Height, format: GL.RGBA16F));
      Dest.Attach(GL.DEPTH_ATTACHMENT, new Renderbuffer(Width, Height, format: GL.DEPTH_COMPONENT16));
      Uniforms["colormap"] = ColorMap;
      Uniforms["depthmap"] = DepthMap;
    }

    public void Render (Manager m) {
      Framebuffer.Bound.BlitTo(Source);
      Dest.Bind();
      GL.Disable(GL.DEPTH_TEST);
      GL.Disable(GL.CULL_FACE);
      m.Render(Uniforms);
      m.Render(Program);
      m.Render(Mesh);
    }

    public Filter Uniform (string name, object value) {
      Uniforms[name] = value;
      return this;
    }

  }

}

