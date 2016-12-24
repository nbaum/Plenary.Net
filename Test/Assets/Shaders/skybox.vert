#include "/common.glsl"

in vec3 position;

out FragData frag;

void main() {
  frag.eyepos = mat4(mat3(scene.view)) * vec4(position, 1);
  gl_Position = scene.projection * frag.eyepos;
}
