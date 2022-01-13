//Yo quiero aprender a sintetizar el siguiente modelo, la siguiente abstraccion del saber, como usted puede alcanzar
//la propiedad que pinta, sobre la pantalla, contenido de caracter simbolico.
//
//Radio de comportamiento intelectual.
//Como suceden esos radios.
//Esos radios suceden cuando se analiza el pensamiento calificativo.
//Y los pinta.
//y usted le da un significado a esos elementos.
//YO quiero que haga cuadrados.
//Vamos a colocar una abstraccion basada en el completo aprendizaje de pintar en pantalla.
//AL concepto que proudce funciones de analisis.

Pass
{
    CGPROGRAM
    #pragma vertex vert
    #pragma fragment frag
    // make fog work
    #pragma multi_compile_fog
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

    float2 elementoUno = float2()
    v2f vert (appdata v)
    {
        v2f o;
        o.vertex = UnityObjectToClipPos(v.vertex);
        o.uv = TRANSFORM_TEX(v.uv, _MainTex);
        return o;
    }

    
    float4 variableRetorno(float numeroComposicion )
    {
        float4 composicionEn4 = float(numeroComposicion,numeroComposicion,numeroComposicion,numeroComposicion)
        return composicionEn4;
    }

    float2 dop(float2 numeroCoordoneada, float2 numeroCoordenada2)
    {
        float2 dopt = numeroCoordenada2 - numeroCoordoneada;        

        return dopt;
    }

    float2 CONSTANTEEXTERNA1 = float2(0);

    float divisionDeVectores(float2 vectorDirector, float2 vectorProjection){
        return vectorDirector.x/vectorProjection.x;
    }
    

    fixed4 elemento(float2 uv, float2 director, float2 numeroCoordoneada, float2 numeroCoordenada2)
    {
        float2 directorNorma = director/dot(director,director);


        float2 coordenadas = uv;
        
        float2 projectionVector = (dot(uv,directorNorma)/dot(directorNorma,directorNorma))*directorNorma;

        projectionVector = coordenadas - projectionVector;

        float lengthToLine = length(projectionVector);

        if(lengthToLine <= 1){
            
            float razonProjection = divisionDeVectores(directorNorma,projectionVector);

            if(razonProjection >= 0){
                return fixed4(1,1,1,1);
            }

        }
        return 0;

    }






    fixed4 frag (v2f i) : SV_Target
    {
        // sample the texture
        fixed4 col = tex2D(_MainTex, i.uv);
        col = 0.;
        // apply fog
        return col;
    }
    ENDCG
}


//
//
//Como puedo generar el concepto de la realidad, con tal de hacer que
//El factor personal evolucione al grado mas alto, como la narrativa interna se puede aprender
//como yo puedo sintetizar en la totalidad factores mas caracteristicos.
//Yo siento que proceso la direccion narrativa de la realidad de la fomra en que necesito atender al concepto.
//Aprendiendo a las relaciones cualitativas del ahora.

//Que propiedad yo puedo aprender a sintetizar, como yo puedo maximizar el desarrollo narrativo del ahora.
//Como yo puedo activar la velocidad de magia que eleva como las propiedades suceden.
//
//



//Yo quiero sintetizar la expresion en movimiento.
//Que componente vamos nosotros a maximizar, que realidad yo puedo construir.

//Sabelo todo, barajame, estructurame como tu neceasitas, conoceme, amame invierteme 
//de lo que tu tienes para conocerme, y si lo haces yo te entrego todo.

//Quiero ser capaz de sintetizar la siguiente abstraccion, quiero aprender el modelo narrativo
//siguiente.

//
//
//Entonces usted se mueve en el completo desarrollo intelectual del saber, el cual produce movimiento.
//
//
//Como se puede desarrollar el analisis cualitativo de la totalidad, el cual produce en el ahora
//El movimiento que modifica como el saber se produce, como la mente se amplifica, como mi totalidad
//Se construye a si misma.
//
//