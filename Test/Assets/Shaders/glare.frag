
uniform vec2 dir;
uniform sampler2D colormap;
uniform sampler2D depthmap;
in vec2 uv0;

out vec4 color;

#define size 32

float vmax (vec3 v) {
  return max(v.x, max(v.y, v.z));
}

void main () {
  color = texture(colormap, uv0);
  float w = 0.01, s = 1.0;
  float d = texture(depthmap, uv0).r;
  for (int i = 0; i < size; ++i) {
    vec2 bscale = dir * i * fwidth(uv0);
    vec4 x = texture(colormap, uv0 + bscale) + texture(colormap, uv0 - bscale);
    w *= 0.9;
    if (max(max(x.r, x.g), x.b) > 1) {
      s += w;
      color += w * x;
    }
  }
  color /= s;
}
