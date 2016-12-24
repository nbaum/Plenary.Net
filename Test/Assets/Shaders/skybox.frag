#include "/common.glsl"

uniform sampler2D environment;

in FragData frag;

out vec4 fragColor;

void main () {
  vec3 color = texture360(environment, normalize(proj(frag.eyepos).xyz)).rgb;
  color = pow(color, vec3(5, 5, 5)) * 2;
  fragColor = vec4(color, 1);
}
