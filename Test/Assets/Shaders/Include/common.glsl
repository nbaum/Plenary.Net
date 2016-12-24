#define PI 3.1415926535897932384626433832795

struct Light {
  vec3 position;
  mat4 transform;
  vec4 color;
};

struct Scene {
  float framenum;
  mat4 projection, view, model;
  Light lights[8];
};

uniform Scene scene;

vec3 model2world(vec3 v) { return mat3(scene.model) * v; }
vec3 world2model(vec3 v) { return inverse(mat3(scene.model)) * v; }

vec3 model2eye(vec3 v) { return mat3(scene.view) * mat3(scene.model) * v; }
vec3 world2eye(vec3 v) { return mat3(scene.model) * v; }

vec3 eye2model(vec3 v) { return inverse(mat3(scene.view) * mat3(scene.model)) * v; }
vec3 eye2world(vec3 v) { return inverse(mat3(scene.view)) * v; }

vec4 eye2world(vec4 v) { return inverse(scene.view) * v; }

vec4 proj (vec4 v) {
  return vec4(v.xyz / v.w, 1);
}

struct FragData {
  vec4 localpos;
  vec4 worldpos;
  vec4 eyepos;
  vec3 localnormal;
  vec3 worldnormal;
  vec2 uv0;
  vec3 tangent0;
  vec3 binormal0;
  vec4 color0;
  vec4 lightpos0;
};

uniform sampler2D lightmaps[8];

vec4 texture360(sampler2D tex, vec3 dir) {
  vec2 uv;
  uv.x = -atan(dir.x, dir.z) / PI * 0.5;
  uv.y = -acos(dir.y / length(dir)) / PI;
  return texture(tex, uv);
}
