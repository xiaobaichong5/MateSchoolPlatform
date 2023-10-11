﻿Shader "Hidden/Scanline"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }

    SubShader
    {
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_instancing

            #include "UnityCG.cginc"
            #include "..\MiskCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID //Insert
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
                UNITY_VERTEX_OUTPUT_STEREO //Insert
            };

            v2f vert (appdata v)
            {
                v2f o;
                UNITY_SETUP_INSTANCE_ID(v); //Insert
                UNITY_INITIALIZE_OUTPUT(v2f, o); //Insert
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o); //Insert

                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
            
            UNITY_DECLARE_SCREENSPACE_TEXTURE(_MainTex);
            float4 _MainTex_ST;
            float4 _Resolution;
            float _Scaler;
            float _Speed;
            float2 _Direction;

            fixed4 frag (v2f i) : SV_Target
            {
                UNITY_SETUP_STEREO_EYE_INDEX_POST_VERTEX(i); //Insert

                float2 screenPos = UnityStereoScreenSpaceUVAdjust(i.uv, _MainTex_ST);
                float pixel = abs(dot(_Direction, screenPos.xy * _Resolution.xy) / (2.0f * _Scaler));

                fixed4 col = FetchTexel;
                col.rgb /= max(col.a, 0.01f);

                col.a *= floor((pixel + _Time.w * _Speed)) % 2;
                col.rgb *= col.a;

                return col;
            }
            ENDCG
        }
    }
}
