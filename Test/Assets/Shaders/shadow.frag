#include "/common.glsl"

out vec3 fragColor;

void main () {
  float depth = (gl_FragCoord.z / gl_FragCoord.w);
  fragColor.r = depth;
  fragColor.g = depth * depth + (pow(dFdx(depth), 2) + pow(dFdy(depth), 2)) / 4;
  fragColor.b = depth;
}
