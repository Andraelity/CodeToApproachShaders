#include <iostream>
#include <vector>
#include <string>
#include <fstream>
//GEnera la velocidad que usted quiere.
//Como se genera esta velocidad.
using namespace std;


class Abstracta{

public:
vector<string> elementVisualizer;
int posicion_numerica = 0;
string name = "";

Abstracta(string nick){

    this->name = nick;

}

void preguntas() {

ifstream inFile;
inFile.open("lectura.txt");
string myText;
int count = 0;
while (getline (inFile, myText)) {
// Output the text from the file
// for(int i = ((this->elementVisualizer).size()); i > 0; --i){
// }

cout << endl << endl;
cout << "#############"+ to_string(count) + "##############" << endl ;

this->elementVisualizer.push_back(myText);

cout << (this->elementVisualizer)[0] << endl;

// cout << "Que es lo que yo quiero ahora mismo" + "Como yo puedo determinar relaciones mas abstractas" << endl;

// cout << "Aprendiendo a setear el trabajo del saber a un punto mas alto" << endl; 

cout << myText << endl;
count++;
}
    
inFile.close();

}
};

class Character{
    public:
        string name = "";
        string wordMemory;

        Character(string setName){
            this->name = setName;
        }

        void setMemoryLocation(Character* setMemory){
            cout << "Usted esta en este punto" << endl;
            cout<< setMemory << endl;
            cout << typeid(setMemory).name() << endl;
            auto variableControl = setMemory;

            cout << variableControl << endl;
            //cout << typeid(&setMemory) << endl;
            //cout << typename(&setMemory) << endl;
            //cout << typedef(&setMemory) << endl;
            //this->wordMemory = &setMemory;
        }
        
        void getMemoryLocation(){
   //         return this-wordMemory;
        }

};



class D2{
    public:
        vector<int> twoD;

        D2(int x, int y){                
            (this->twoD).push_back(x);
            (this->twoD).push_back(y);
            
        }


        void print2D(){
            cout << "Estas escribiendo esto " << endl;
            cout << (this->twoD).at(0)  + " " + (this->twoD).at(1)<< endl;
        }

        vector<int> retornoVector(){
            return this->twoD;
        }
};



int main(){

    auto numeroFocalizador = new Abstracta("Dominio");

    numeroFocalizador->preguntas();

    cout << endl << endl;

    auto variableContexto = &numeroFocalizador;

    auto variableContexto2 = *numeroFocalizador;


    auto cambio = new vector<int>();
    for(auto i = 0; i < 50; i++){
        cambio->push_back(i);
    }


    for (auto i = 0; i < cambio->size(); i++){
        cout << (cambio->at(i)) << endl;
    }


    D2* probandoClase2D = new D2(300,300);

    cout << endl << endl; 
    cout << "Here in the voltaje" << endl;

    probandoClase2D->print2D();

    auto generandoConcepto = probandoClase2D->retornoVector();
    vector<int> generandoConcepto4 = probandoClase2D->retornoVector();

    cout << endl << endl;
    cout << generandoConcepto4.at(0) << endl;
    cout << endl << endl;

    vector<int>&& generandoConcepto2 = probandoClase2D->retornoVector();

    

    cout << generandoConcepto2.at(0) << endl;

    cout << endl << endl;
    cout << generandoConcepto.at(0) << endl;
    
    auto generandoConcepto3 = probandoClase2D->retornoVector();
    cout << generandoConcepto3.at(0) << endl;


    cout<< endl << endl;


    //De sintetizar el siguiente modelo, cual es el comportamiento que buscamos aprender aqui.
    //Que valor yo quiero promover en el siguiente momento.


    cout << variableContexto << endl;
    cout <<  typeid(variableContexto2).name() << endl;
    cout << endl << endl;
    
    for(int i = 0; i < numeroFocalizador->elementVisualizer.size(); i++){
        cout << numeroFocalizador->elementVisualizer[i] << endl;
        cout << &numeroFocalizador->elementVisualizer[i] << endl;
    }

    delete numeroFocalizador;

    Character* probandoClasses = new Character("SeteoDeNombre");

    probandoClasses->setMemoryLocation(probandoClasses);

    probandoClasses->getMemoryLocation();




    cout << endl << endl;

    vector<vector<int>> contenedor;

    for(int i = 0; i < 50 ; i++){

        contenedor.push_back((new D2(30+i,30+i))->retornoVector());
    }

    for (int i = 0 ; i < contenedor.size(); i++){
        cout << contenedor[i][0] << " " << contenedor[i][1] << endl;
    }

    int dominio = 999;

    if (dominio)
    
    //Yo quiero esas coordenadas procesadas en un contexto mas especifico un contexto mas determinante.


    //Tienes que aprender a ganarte la matematica y la analitica que te llevan a inevitablemente alcanzar 

    //El suceso en cuestion.

    //No hay otra, tiene que moverse en la solucion.
    //No puede andar lejos de la solucion.

    //Me falta lo que no se como conseguir.

    //Como yo puedo graficar puntos dentro de ese editor y con ello programar el conteto

    //Eso es sacar graficas en el editor, y con ello manejar los pixeles que producen el formato que yo quiero visualizar y con ello 
    //el bucle que yo quiero sinteitzar.
    //Saqueme codigo a todo momento, despliege sobre la realidad el analisis que yo estoy buscando, como yo puedo analizar.
    //Como yo puedo producir las realidades que definen como el saber se produce.
    // Que clase de propiedad se puede armonizar.

    //Porque hay hay una documentacion, sobre el diseño en supercomputadora.
    //Porque ese es el que usan los tesos.


    //Por que usted es de codigo matematico.
    //No hay nada mas voltaje.
    //En un momento se hace muy voltaje.


    //Diseñando propiedades a razon de toda la mente
    //How to detail the continual evolution of the self, how to apprehend the qualities of the now, 
    //How to create the particularities that we want to achieve, how to sense the emotion we want
    //To make real, how to achieve a new perception
    //How to learn about the ideas
    //How to create a emotion
    //How to believe in the qualities
    //How to experience the continual creation of the now
    //Believing in the true emotions.
    //Sensing how to explain the actions

    //Learning how to experience complete motion
    //Believing in the probabilities.
    //Learning about the concepts.
    //Aprendiendo a maximizar las relaciones de poder 
    //Que promueven como la realidad se experimenta como 
    //El saber se produce, como el comportamiento
    //Se activa como la realidad se puede procesar
    //Que tipo de interaccion yo puedo formular en el ahora
    //Como yo promuevo el factor que detalla toda mi mente.
    return 0;
}