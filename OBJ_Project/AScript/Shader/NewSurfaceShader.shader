Shader "Transparent/NewSurfaceShader"
{
    Properties
    {
        _Color("Main Color", Color) = (1,1,1,1)
        _MainTex("Base (RGB)", 2D) = "white" {}
        _Cutoff("Alpha cutoff", Range(0,1)) = 1
        _NearDistance("NearDistance", Float) = 20
        _FarDistance("FarDistance", Float) = 30
        _CutTex("Cutout (A)", 2D) = "white" {}
        _ScreenWidth("Screen Width", Float) = 500
        _ScreenHeight("Screen Height", Float) = 500
    }
 
    SubShader
    {
        Tags{ "Queue" = "AlphaTest" "IgnoreProjector" = "True" "RenderType" = "TransparentCutout" }
        LOD 200
        Cull Off
 
        CGPROGRAM
 
        #pragma surface surf Lambert alphatest:_Cutoff
 
        sampler2D _MainTex : TEXCOORD0;
        sampler2D _CutTex: TEXCOORD1;
        fixed4 _Color;
        float _ScreenWidth;
        float _ScreenHeight;
        float _FarDistance;
        float _NearDistance;
 
        struct Input
        {
            float2 uv_MainTex;
            float2 screenPos;
            half3 worldNormal;
            float3 viewDir;
            float3 worldPos;
        };
 
        void surf(Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
 
            float2 pos = IN.screenPos;
            half u = pos.x * _ScreenWidth / 1024;//size of cutoff texture
            half v = pos.y * _ScreenHeight / 1024;//size of cutoff texture
            float ca = tex2D(_CutTex, float2(u, v)).a;
 
            //dist
            float2 v1 = IN.worldPos.xz;
            float2 v2 = _WorldSpaceCameraPos.xz;
            float dist = distance(v1, v2);
 
            if (dist < _NearDistance)
                ca = 1;
            else
            {
                if (dist > _FarDistance)
                    ca = 0;
                else
                    ca = ca + (_FarDistance - dist) / (_FarDistance - _NearDistance);
            }
 
            //back side must be transparent always
            float n = dot(IN.viewDir, IN.worldNormal);
 
            if (n < 0)
                ca = 0;
            //
            o.Albedo.rgb = c.rgb;
            o.Alpha = ca;
        }
 
        ENDCG
    }
 
    Fallback "Transparent/Cutout/VertexLit"
}