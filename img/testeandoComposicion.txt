using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Probe.Content.detail
{
    public class MyClass
    {
        public int variableTesteoDeName = 0;

        public MyClass(int writeTesteoDeName)
        {
            this.variableTesteoDeName = writeTesteoDeName;
        }

        public void escribiendoContenido(){
            Debug.Log("Here in the contexto i want to manipulate");
        }
    }
    
    
    public class MyClient
    {
        public string[] atendiendoComposiciones = new string[10];

        public string retornoString(string CadenaDeTexto){
            atendiendoComposiciones[0] = CadenaDeTexto;
            return atendiendoComposiciones[0];
        }
    }


    public class Despliege
    {
        public List<float> listaDeControl = new List<float>();

        public void ManejoListaDeControl(){

            for(int i = 0 ; i < 100; i++){
                listaDeControl.Add((float)i/50);
                Debug.Log(listaDeControl[i]);
            }

            float[] composicionDeFloat = listaDeControl.ToArray();

            Debug.Log("Generando Relaciones de composiciones" + composicionDeFloat.Length.ToString());


            for(int i = 0; i < 100; i++){
                Debug.Log("Here in lista = " + listaDeControl[i].ToString());
            }

        }
    }


    public class EntendiendoRecomposicion
    {

        public int definiendoAbstracciones(){
            return 10;
        }

        public int generandoRealidad(){
            return 10;
        }
    }

}


// Como yo puedo procesar acciones mas especificas, como yo puedo 
//Estar relaciones con el todo, como yo puedo buscar el saber que me
//Me permite armonizar con la totalidad las interacciones que definen 
//Como el saber se crea como el proyecto interno se aprecia
//Que puedo usar con tal de valorar el comportamiento que me permite pensar
//En el desarrollo del ahora el movimiento que me permite maximizar los detalles
//De la realidad al punto mas alto aprendiendo como el comportamiento se asimila
//Como la totalidad se maximiza, como yo puedo analizar el producto teorico del ahora
//emprendiedo con ello rutas mas claras.