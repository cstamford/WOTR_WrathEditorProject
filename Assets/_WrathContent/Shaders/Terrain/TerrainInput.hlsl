#ifndef OWLCAT_TERRAIN_INPUT_INCLUDED
#define OWLCAT_TERRAIN_INPUT_INCLUDED



#include "Packages/com.wrath.core/ShaderLibrary/Common.hlsl"
#include "Packages/com.wrath.core/ShaderLibrary/Packing.hlsl"
#include "Packages/com.wrath.core/ShaderLibrary/CommonMaterial.hlsl"


#include "Packages/com.wrath.core/ShaderLibrary/Input.hlsl"
#include "Packages/com.wrath.core/ShaderLibrary/Core.hlsl"
#include "Packages/com.wrath.core/ShaderLibrary/SurfaceInput.hlsl"
#include "Packages/com.wrath.core/ShaderLibrary/Terrain/TerrainLayerData.cs.hlsl"                                           

StructuredBuffer<TerrainLayerData> _TerrainLayerDatas;

TEXTURE2D_ARRAY(_SplatArray); SAMPLER(sampler_SplatArray);

TEXTURE2D_ARRAY(_DiffuseArray); SAMPLER(sampler_DiffuseArray);
TEXTURE2D_ARRAY(_NormalArray);  SAMPLER(sampler_NormalArray);
TEXTURE2D_ARRAY(_MasksArray);   SAMPLER(sampler_MasksArray);

TEXTURE2D(_MainTex);        SAMPLER(sampler_MainTex);
TEXTURE2D(_MetallicTex);    SAMPLER(sampler_MetallicTex);
       

CBUFFER_START(UnityPerMaterial)
float4 _MainTex_ST;
float4 _SplatArray_ST;
float4 _SplatArray_TexelSize;
float4 _DiffuseArray_TexelSize;
float4 _Color;
float _AlphaBlendFactor;
int _ControlTexturesCount;
float _TriplanarTightenFactor;
float4 _TerrainHeightmapRecipSize;
float _TerrainMaxHeight;    
CBUFFER_END

#endif //OWLCAT_TERRAIN_INPUT_INCLUDED
