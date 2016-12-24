#include "/common.glsl"

uniform sampler2D skybox;
uniform sampler2D irradiance;

vec3 fresnel_factor (vec3 f, float p) {
  return mix(f, vec3(1), pow(1.01 - p, 5.0));
}

float GGX (float r, float NdH) {
  float m = r * r;
  float m2 = m * m;
  float d = (NdH * m2 - NdH) * NdH + 1.0;
  return m2 / (PI * d * d);
}

float schlick (float r, float NdV, float NdL) {
  float k = r * r * 0.5;
  float V = NdV * (1.0 - k) + k;
  float L = NdL * (1.0 - k) + k;
  return 0.25 / (V * L);
}

vec3 cooktorrance(vec3 s, float r, float NdH, float NdV, float NdL)
{
  float D = GGX(r, NdH);
  float G = schlick(r, NdV, NdL);
  float rim = mix(1.0 - r * 0.5 * 0.9, 1.0, NdV);
  return (1.0 / rim) * s * clamp(G, 0.0, 1.0) * D;
}

bool eq (vec3 a, vec3 b) {
  a += 0.1;
  return a.r > b.r && a.g > b.g && a.b > b.b;
}

uniform sampler2D emission, ao, albedo, matprops;

vec4 fragment (in FragData frag) {

  vec3 lightpos = scene.lights[0].position;
  vec3 viewpos = eye2world(vec4(0, 0, 0, 1)).xyz;

  float A = 1.0 / sqrt(length(lightpos - frag.worldpos.xzy));

  vec3 L = normalize(lightpos - frag.worldpos.xyz);
  vec3 V = normalize(viewpos - frag.worldpos.xyz);
  vec3 N = normalize(frag.worldnormal);
  vec3 H = normalize(L + V);

  float NdL = clamp(dot(N, L), 0.0, 1.0);
  float NdV = dot(N, V);
  float HdV = dot(H, V);
  float NdH = dot(N, H);

  float metallic = 0;
  float roughness = 0;
  float rimmness = 0.5;

  vec3 base = texture(albedo, frag.uv0).rgb;
  vec3 emit = pow(texture(emission, frag.uv0).rgb, vec3(2, 2, 2)) * 30;
  vec2 prop = texture(matprops, frag.uv0).xy;

  metallic = prop.x;
  roughness = prop.y;

  vec3 specular = mix(vec3(0.04), base, metallic);
  vec3 specfresnel = fresnel_factor(specular, HdV);
  vec3 light = scene.lights[0].color.rgb * scene.lights[0].color.a;
  light *= SHADOW(lightmaps[0], frag.lightpos0);
  light *= pow(texture(ao, frag.uv0).rgb, vec3(1));

  vec3 reflected = cooktorrance(specfresnel, roughness, NdH, NdV, NdL) * NdL * light;
  vec3 diffuse = (vec3(1) - specfresnel) * NdL * light / PI;

  reflected += texture360(skybox, normalize(reflect(-V, N))).rgb;
  diffuse += texture360(irradiance, N).rgb / PI;
  vec3 result = diffuse * mix(base, vec3(0.0), metallic) + reflected * mix(0.0, 1.0, metallic);
  return vec4(result + emit, 1.0);

}
