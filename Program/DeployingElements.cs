using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace RealidadEstructurada 
{   
    public class AprendizajeLenguas
    {
        
        public string[] generandoApreciaciones = new string[40];

        public void definicionDeRealidad(){
            
            string inside_generandoApreciaciones = "LLEGUEN A MI Matrices";
            for(int i = 0; i < generandoApreciaciones.Length; i++){
                generandoApreciaciones[i] = "MATRICES DOMINIO Y CONTROL" ;
            }
            generandoApreciaciones[0] = inside_generandoApreciaciones;
            for(int i = 0; i < generandoApreciaciones.Length; i++){

                Debug.Log(generandoApreciaciones[i] + "HEREEEEEEEEEEEEEEEEE");   
            }
        }

        public string[] reconociendoExpresiones = new string[49];

        public void expresandoConcepto(){
            for(int i = 0; i < reconociendoExpresiones.Length; i++){
                reconociendoExpresiones[i] = i.ToString();
                Debug.Log("Atendiendo propositos internos" + reconociendoExpresiones[i]);

                Debug.Log("Evolucionando en realidad");
            }
        }
    }

    public class Dominio
    {
        public List<float> general = new List<float>();
        public float attention = 0.0f;
        public int detail = 0;

        void recorreFunciones(int numero){
            this.attention = numero;
        }
    }

    public class Mathematics
    {
        public string propiedades = "";

        Mathematics(string constructorString){
            propiedades = constructorString;
        }


        public string[] contenedorString =  new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };


        public void MatemathicsInString(){
            Debug.Log(contenedorString[0]);
        }


    }



    public class Estructura
    {


        static public string definiendoAction(){
            var apreciacionRealidad = new string[100];
            apreciacionRealidad[0] = "Generando realidad";
            return apreciacionRealidad[0];

        }


        static public string retornoPosicion(){

            int generandoMovimientoDeCodigo = 2999;
            return "retornoPosicion";

        }
    

    }




}




    //Como yo puedo activar el pensamiento de las formas del ahora
    //Como yo puedo analizar accoines de caracter mas especifico
    //Como yo puedo buscar ingredientes en la realidad los cuales permitan
    //Que las formas de mi mente se puedan expresar como yo puedo
    //diferenciar acciones en el saber las cuales permitan que mi todo se piense
    //Como yo puedo vivir en completa armonia con el ahora
    //Que puedo yo formalizar en el saber con tal de vivir 
    //el misterio del ahora.
    //PUed  