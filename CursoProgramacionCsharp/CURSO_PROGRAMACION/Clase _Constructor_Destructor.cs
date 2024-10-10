using System;
using System.Collections.Generic;
using System.Text;

namespace CURSO_CONSOLA_BASICO
{
    class Clase__Constructor_Destructor
    {
        #region AQUI TENEMOS NUESTRAS VARIABLES A USAR
        public string Marca, Modelo, Color; // --> Esta es la declaracion de las Variables 
        public int Anio;
        #endregion

        #region AQUI TENEMOS NUESTRO METODO CONSTRUCTOR 
        public Clase__Constructor_Destructor() // --> Este seria nuestro metodo Constructor
        {
            Marca = "Honda";  // --> Aqui Inicializamos o damos valores a las Variables
            Modelo = "Civic";
            Color = "Negro";
            Anio = 2018;
        }
        #endregion

        #region METODO DESTRUCTOR DE LOS RECURSOS CONSOLA
        ~Clase__Constructor_Destructor()
        {
            System.Diagnostics.Trace.WriteLine("Se destruyeron los recursos hechos en la  Consola");
        }
        #endregion

        #region METODO PARA MOSTRAR LOS DATOS DE LA VARIABLES
        public void Mostrar_Informacion_Metodo_Constructor()
        {
            Console.WriteLine("La marca de tu carro es :" + Marca);
            Console.WriteLine("El modelo de tu carro es :" + Modelo);
            Console.WriteLine("El color de tu carro es :" + Color);
            Console.WriteLine("El Año de tu carro es :" + Anio);
            Console.ReadLine();
        }
        #endregion
    }
}
