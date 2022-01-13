using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Probe.Content.detail;
using RealidadEstructurada;



public class RunScript : MonoBehaviour
{  


    
    //This is where we use time to define the amount of pixels in enviroment.
    //This is how we measure the production and syntesis of images 
    //over a screen, this is how we start to enable a reproductive quality.
    public float updateInterval = 0.5F;
    private double lastInterval;
    private int frames;
    private float fps;


    //This is how we produce more concepts, this is how we create ideas around the composition of self.
    //THis is how we create models around the perception of mind.
    //This is how we sintetize definitions, mentalities and movements.
    //This concept make us use sintesis around the model of conception.
    public const bool mensajeEjecutador = true;

    List<float> red;
    List<float> green;
    List<float> blue;
    [SerializeField]
    public int IMG_WIDTH = 1024;
    [SerializeField]
    public int IMG_HEIGHT = 720;
    [SerializeField]
    public int pattern = 3  ;
    [SerializeField]
    public string nameOfFile;
    [SerializeField]
    public GameObject thing;

    Texture2D texture;

    public int count = 0 ;

    private double numeroNuevoOperador;
    
    // Start is called before the first frame update
    void Start()
    {
        
        lastInterval = Time.realtimeSinceStartup;
        frames = 0;



        thinkTheArt(pattern);
        doTheArt();


        float documentoLeida = 100.0f;

        List<float> blue = new List<float>();

        Debug.Log(documentoLeida);

    }

    void OnGUI()
    {
        GUILayout.Label("" + fps.ToString("f2"));
    }

    void thinkTheArt(int type){

        red = new List<float>();
        green = new List<float>();
        blue = new List<float>();

        switch(type){

            case(0):
           
            default:
                for (int i = 0; i < IMG_WIDTH; i++){
                    for(int id = 0; id < IMG_HEIGHT; id++){
                        red.Add(Random.Range(0.0f,1.0f));
                        green.Add(Random.Range(0.0f,1.0f));
                        blue.Add(Random.Range(0.0f,1.0f));
                    }
                }
                break;

            case(1):

                for(int i = 0; i < IMG_WIDTH; i++){
                    for(int id  = 0; id < IMG_HEIGHT; id++){

                        red.Add((float)id/IMG_HEIGHT);
                        green.Add(0);
                        blue.Add(0);
                    }
                }
                break;

            case(2):
                
                for(int i = 0; i < IMG_WIDTH; i++){
                    for(int id = 0 ; id < IMG_HEIGHT; id++){
                        
                        if(i < IMG_WIDTH/2){
                            red.Add((float)0.4);
                            green.Add((float)0.4);
                            blue.Add((float)0.4);
                          
                        }
                        else{
                            red.Add((float)0.9);
                            green.Add((float)0.9);
                            blue.Add((float)0.9);
                            
                        }
                           
                    }
                }
                break;


 
            case(3):

                for(int i = 0; i < IMG_WIDTH; i++){
                    for(int id = 0; id < IMG_HEIGHT; id++){

                        if(id < 10  && i < 8){

                            red.Add(0.2f); 
                            green.Add(0.2f);
                            blue.Add(0.6f);
                        }
                        else{
                            red.Add(0.7f);
                            green.Add(0.8f);
                            blue.Add(0.8f);
                        }
                        
                    }
                }

                break;
 
             case(4):

                for(int i = 0; i < IMG_WIDTH; i++){
                    for(int id = 0; id < IMG_HEIGHT; id++){
                        
                        //Los dos primeros son la superior derecha 
                        //Los dos ultimos son la inferior izquierda
                        if(id <= 20 && i <= 20 && id >= 10 && i >= 10 ){

                            red.Add(0.2f);
                            green.Add(0.2f);
                            blue.Add(0.6f);
                        }

                        else if( id <= 30 && i <= 20 && id >= 20 && i >= 10  ){
                            
                            red.Add(0.2f);
                            green.Add(0.2f);
                            blue.Add(0.6f);

                        }
                        else if( id <= 40 && i <= 20 && id >= 30 && i >= 10  ){
                            
                            red.Add(0.2f);
                            green.Add(0.2f);
                            blue.Add(0.6f);

                        }
                        else if( id <= 50 && i <= 20 && id >= 40 && i >= 10  ){
                            
                            red.Add(0.2f);
                            green.Add(0.2f);
                            blue.Add(0.6f);

                        }
                        else{
                            red.Add(0.7f);
                            green.Add(0.8f);
                            blue.Add(0.8f);
                        }

                    }
                }
                 break;


        }
    }

    void doTheArt(){

        texture = new Texture2D (IMG_WIDTH, IMG_HEIGHT, TextureFormat.ARGB32, false);




        float[] redArr = red.ToArray();
        float[] greenArr = green.ToArray();
        float[] blueArr = blue.ToArray();


        for (int i = 0; i < IMG_WIDTH; i++){
            for(int id = 0; id < IMG_HEIGHT; id++){
                texture.SetPixel(i,id,new Color(redArr[i * IMG_HEIGHT + id], greenArr[i * IMG_HEIGHT + id], blueArr[i * IMG_HEIGHT + id]));
            }
        }
        texture.Apply();


        //El Vector2(0.5f,0.5f) es un vector que mapea el la totalidad de la imagen en un punto que sirve como 
        //Punto de composicion de toda la imagen, donde se reunen las interacciones que permiten el movimiento del 
        //punto de abajo.

        thing.GetComponent<Image>().sprite = Sprite.Create(texture, new Rect(0,0,IMG_WIDTH, IMG_HEIGHT), new Vector2(0.5f, 0.5f));
    }


    void recorredor(){

        Dominio variable = new Dominio();

        variable.general.Add(10.0f);

        Debug.Log(variable.general.ToArray());

        Debug.Log(variable.detail);
    }


    void retornoFuncion(){

        int generandoProceso = 1000;

        int[] generandoContenido = new int[10];

        generandoContenido[0] = 10;

        Debug.Log(generandoContenido[0]);

    }
    // Update is called once per frame

    static float executionWhileRunning = 0;
    static bool atendiendoElComportamiento = true;
    public float numeroDesc = 0;



    void Update()
    {

        byte[] bytes = texture.EncodeToPNG();
        if(Input.GetKeyUp(KeyCode.Space)){
           
            File.WriteAllBytes(Application.dataPath + "/" + nameOfFile + ".png",bytes);
            
        }

        //Debug.Log(Application.dataPath + "/" + nameOfFile + ".png");

        //recorredor();

        if(Input.GetKeyUp(KeyCode.Return)){
            
            thinkTheArt(pattern);

            //while(){}
            
            doTheArt();
            
        }

        


        //Es un intervalo de caracter de lectura binario, la direccion de memoria del procesador
        //Es la que le produce a usted el analisis cualitativo que busca.
        //Usted tiene unos extremos que busca diferenciar, en torno a una aproximacion
        //Y esta aproximacion es una direccion de memoria, que significa un punto.
        //un numero es una direccion en memoria
        //y ese numero se puede traducir, de forma analitica, al punto mas extremo
        //El cual sucede cuando puede proveer direcciones, de caracter particular.
        //Una relacion significativa con la totalidad, la cual permiten que yo pueda enfocar el concepto 
        //Al grado mas alto.
        //El concepto al punto mas superior.
        //Ese punto sucede cuando usted proyecta sobre su realidad, la configuracin matematica que conoce.



        if(numeroNuevoOperador < Time.realtimeSinceStartup){
            numeroNuevoOperador = Time.realtimeSinceStartup + 0.05;
            
            thinkTheArt(pattern);

            //while(){}
            
            doTheArt();

            pattern =  Random.Range(1, 5);
            
        }

        if(Input.GetKey(KeyCode.A)){
            pattern = 1;
            print("You pressed the A key");
        }

        if(Input.GetKey(KeyCode.B)){
            pattern = 2;
            print("Your pressing the B key");
        }

        if(Input.GetKey(KeyCode.C)){
            pattern = 4;
            print("Your pressing the B key");
        }



        var milliseconds1 = Time.deltaTime; 

        var definicionDeContenido = milliseconds1.GetType();
        // print("VariableDeContenido");
        // Debug.Log(definicionDeContenido.ToString());
// 
        // Debug.Log(milliseconds1);

        ++frames;
        float timeNow = Time.realtimeSinceStartup;
        // Debug.Log(timeNow);

        if (timeNow > lastInterval + updateInterval)
        {
            fps = (float)(frames / (timeNow - lastInterval));
            frames = 0;
            lastInterval = timeNow;
        }


        /* 

        AprendizajeLenguas variableDeAprendizaje = new AprendizajeLenguas();
        variableDeAprendizaje.expresandoConcepto();
        variableDeAprendizaje.definicionDeRealidad();

        animandoRealidades();

        Despliege composicionDeLista = new Despliege();

        composicionDeLista.ManejoListaDeControl();

        
         */


            

/*         Debug.Log(Estructura.definiendoAction());

        Debug.Log(Estructura.retornoPosicion());
        retornoFuncion();

        
        Debug.Log("Definiendo relacion con la mente");

        count ++;
        Debug.Log(count);

        float valorDeT = Time.deltaTime;


        Debug.Log("Componente Narrativo " + valorDeT.ToString());

        numeroDesc += valorDeT;

        if(numeroDesc > 2){
            Debug.Log("Here in numeroDescri: " + numeroDesc);

            numeroDesc = 0;    
        }
        Debug.Log(numeroDesc);

        testeandoName();
 */    }


    public void testeandoName(){
        MyClass creativa = new MyClass(10);

        creativa.escribiendoContenido();

        Debug.Log("Aprendiendo a componer acciones   " + (creativa.variableTesteoDeName).ToString());

        MyClient aprendiendoVerdades = new MyClient();


        Debug.Log(aprendiendoVerdades.retornoString("This is a cadena"));

        string[] GenerandoMuchoMasPoder = new string[10];

        GenerandoMuchoMasPoder[0] = "Here i can use the code in the developement of the mind";

        print(GenerandoMuchoMasPoder[0]);

        
    }

    public void animandoRealidades(){
        print("Como puedo sintetizar accione de caracter codigo");
        //Como puedo sintetizar las siguiente relaciones con el todo
        //Las rutas de la verdad que permiten que mi concepto sea mas pleno
        //Como yo puedo usar los conceptos que me definen con la totalidad.

        print("Como yo puedo trabajar en el desarrollo de un estilo mas alto");

        AprendizajeLenguas creandoAprehensiones = new AprendizajeLenguas();

        creandoAprehensiones.definicionDeRealidad();
        creandoAprehensiones.expresandoConcepto();
        


        print("Que composicion estamos nosotros intentando visualizar en codigo");


    }
}


//Como yo puedo buscar, el concepto que nos define como realidad, el concepto analitico que nos define como realidad el concepto que nos permite 
//Determinar el analisis del ahora como yo puedo buscar el concepto que nos ayuda a diferenciar el analiisis de realidad, el concepto que nos ayuda a determinar
//Propiedades mas especificas el analisis del ahora qeu nos permite diferenciar relaciones del ahora, como yo puedo establecer contenidos mas especificos sobre
//La realidad 





//QUe el codigo que usted pega, es mas voltaje que el hecho pegarlo, sea mas eficiente de lo que la multiplicacion del mismo significa.
//Analizando fundamentos que promueven como el analisis cualitativo de la realidad, hace que nuestro saber
//Alcance la propiedad que buscamos definir, el concepto que queremos atender.


//Quiero aprender a procesar en la realidad, el concepto definitorio que estamos buscando, atendiendo al
//componente que me hace mas mental.
//El componente que me ayuda a pensar en las interacciones con el todo.


//Aprendiendo a modelar las realidades que producen mocion cuando aprendo a pensar en versiones las cuales modelar
