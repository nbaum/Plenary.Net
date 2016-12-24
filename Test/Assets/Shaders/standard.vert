#include "/common.glsl"

in vec3 position;
in vec3 normal;
in vec2 uv0;
in vec3 tangent0;
in vec3 binormal0;
in vec4 color0;
in vec4 alpha0;

out FragData frag;

void main() {
  frag.localpos = vec4(position, 1);
  frag.localnormal = normal;
  frag.uv0 = uv0;
  frag.uv0.y = 1 - frag.uv0.y;
  frag.tangent0 = tangent0;
  frag.binormal0 = binormal0;
  frag.color0 = color0;
  frag.worldnormal = normalize(mat3(scene.model) * frag.localnormal);
  frag.worldpos = scene.model * frag.localpos;
  frag.eyepos = scene.view * frag.worldpos;
  frag.lightpos0 = scene.lights[0].transform * frag.worldpos;
  frag.lightpos0.xyz = frag.lightpos0.xyz / 2 + 0.5;
  gl_Position = scene.projection * frag.eyepos;
}
