Shader "Unlit/ElementoCodigo"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        

    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"



            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                return o;
            }

            
#define MAX_STEPS 100
#define MAX_DIST 100
#define SURF_DIST 1e-3

            float GetDist(float3 p)
            {
                float d = length(p) - 0.5;
                return d;
            }

            float raymarching(float3 ro, float3 rd)
            {
                float dO = 0;
                float dS;
                for(int i = 0; i < MAX_STEPS; i++){
                    float3 p = ro + dO * rd;
                    
                    //Esto mide la longitud de
                    dS = GetDist(p);
                    dO += dS;   
                    //el intervalo de cambio de 
                    //
                    if(dS < SURF_DIST || dO > MAX_DIST) break;
                }
                return dO;
            }


            float2 dop(float2 numeroCoordoneada, float2 numeroCoordenada2)
            {
                float2 dopt = numeroCoordenada2 - numeroCoordoneada;        

                return dopt;
            }

            float2 CONSTANTEEXTERNA1 = float2(0,0);

            float divisionDeVectores(float2 vectorDirector, float2 vectorProjection){
                return vectorDirector.x/vectorProjection.x;
            }


            //This is your scale, this is how your able to produce a meaning, around the concept of mind
            //How your idea is fullfiled with motion.
            //With complexity.

            

            fixed4 elemento(float2 uv, float2 director, float2 numeroCoordoneada, float2 numeroCoordenada2)
            {
                float2 directorNorma = director/length(director);


                float2 coordenadas = uv;

                float2 Toproject = coordenadas - numeroCoordoneada;

                float2 projectionVector = (dot(Toproject,directorNorma)/dot(directorNorma,directorNorma))*directorNorma;

                projectionVector = projectionVector - Toproject;

                float lengthToLine = length(projectionVector);

                if(lengthToLine <= 0.01){

                    float razonProjection = divisionDeVectores(directorNorma,projectionVector);

                    if(razonProjection >= 0){
                        return fixed4(1,1,1,1);
                    }

                }
                return 0;

            }



            float ejecucionCuadro(float2 uv){

                if(uv.x >= 0.1 && uv.y >= 0.1 && uv.x <= 0.5 && uv.y <= 0.5){
                    return 0.5;    
                }

                return 0.5 + 1.0;
            }

            float traduccion(float toTranslate)
            {
                return toTranslate * -1;
            }


            float VARIABLE_CONTENDEDORA = float(0.0);

            fixed4 frag (v2f i) : SV_Target
            {   
                
                

                if(VARIABLE_CONTENDEDORA == 100000)
                {
                    VARIABLE_CONTENDEDORA = 0;
                }

                float2 uv = i.uv -1;
                float3 ro = float3(0,0,-4);
                float3 rd = normalize(float3(uv.x, uv.y, 1));

                if(uv.x == 0.0 && uv.y == 0.0)
                {
                    VARIABLE_CONTENDEDORA++;
                }


                float d = 101.;
                d = raymarching(ro,rd);

                //  if(d < MAX_DIST){
                //      float3 p = ro + rd * d;
                //      float3 n = GetNormal(p);
                //      col.rgb = n;
                //  }


                fixed4 col = 0;
                float numeroV = uv.x;
                if( d < MAX_DIST){
                    col.rgb = float3(0.5,0.1,0.5);  
                }

                // col.rgb = rd;

                float numeroAbstractoX = 0.5;
                float numeroAbstractoY = 0.5;

                
                // if(uv.x < (0.0 + (1/2.46)*traduccion(numeroAbstractoX))  &&   uv.y < (0.0 + traduccion(numeroAbstractoY)) && uv.x > (-0.02 + (1/2.46)*traduccion(numeroAbstractoX)) && uv.y > (-0.07 + traduccion(numeroAbstractoY)) ){
                    // col.rgb = float3(0.1,0.2,0.5);  
                // }

                if(uv.x < (0.0 + traduccion(numeroAbstractoX))  &&   uv.y < (0.0 + traduccion(numeroAbstractoY)) &&
                     uv.x > (-0.02 + traduccion(numeroAbstractoX)) && uv.y > (-0.07 + traduccion(numeroAbstractoY)) ){
                    col.rgb = float3(0.1,0.9,0.5);  
                }


                if(uv.x < 1 && uv.y < 1 && uv.x > 0.9 && uv.y > 0.9){
                    col.r = 1;
                    col.g = 0.5;
                }

                


                float2 punto1 = float2(traduccion(0.5),traduccion(0.5));
                float2 punto2 = float2(traduccion(1.0),traduccion(1.0));

                if(uv.x < traduccion(0.0) && uv.y < traduccion(0.0) && uv.x > traduccion(0.1) && uv.y > traduccion(0.1)){
                    col = fixed4(0.5,0.5,0.5,1);           
                }   


                float2 punto1Ejemplo = float2(0.01,0.01);
                float2 punto2Ejemplo = float2(0.5,0.01);

                float2 diferenciaVectores = punto2Ejemplo-punto1Ejemplo;
                //col =   elemento(uv, diferenciaVectores, punto1Ejemplo, punto2Ejemplo);
                
                //How i can explain this numbers to the world
                //How i can attend the motion of the mind
                //How my thinking could be improved.

                //How i can became one with the all.
                //How!!

                    
                if(uv.x < (traduccion(numeroAbstractoX))  &&   uv.y < (traduccion(numeroAbstractoY)) &&
                     uv.x > (-0.02 + traduccion(numeroAbstractoX)) && uv.y > (-0.07 + traduccion(numeroAbstractoY)) ){
                    col.rgb = float3(0.1,0.9,0.5);  
                }
                
                if(ejecucionCuadro(uv) < 1.0 ){
                    col = fixed4(0.5,0.5,0.5,0.5);
                }

                return col;
	        
            }
            ENDCG
            
        }
    }
}
