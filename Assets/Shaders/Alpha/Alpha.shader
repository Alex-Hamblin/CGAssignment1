Shader "Custom/Alpha"
{
    Properties
    {
        _MainTex("MainTex",2D) = "White" {}

    }
    SubShader
    {
        Tags { "Queue"="Transparent" }
        

        CGPROGRAM
        
        #pragma surface surf Lambert

        

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;

      

        void surf (Input IN, inout SurfaceOutput o)
        {
            fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
            o.Albedo = c.rgb;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
