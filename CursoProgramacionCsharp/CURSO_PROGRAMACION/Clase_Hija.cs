using System;
using System.Collections.Generic;
using System.Text;

namespace CURSO_CONSOLA_BASICO
{
    class Clase_Hija : Clase_Padre  // HE AQUI DONDE HEREDO TODO LO DE LA CLASE PADRE A LA CLASE HIJO
    {
        #region METODO PARA REALIZAR LAS OPERACIONES MATEMATICAS 
        public void Operacion()
        {
            Clase_Padre RealizarOperacion = new Clase_Padre();
            Console.WriteLine("********************************************");
            Console.WriteLine("------> QUE OPERACION DESEA REALIZAR <------");
            Console.WriteLine("********************************************");
            Console.WriteLine("Realizar Suma           -------> (1)");
            Console.WriteLine("Realizar Resta          -------> (2)");
            Console.WriteLine("Realizar Multiplicacion -------> (3)");
            Console.WriteLine("Realizar Division       -------> (3)");
            Console.WriteLine("********************************************");
            Console.WriteLine("Ingrese la Opcion a Realizar ");
            int Opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("********************************************");
            switch (Opcion)
            {
                case 1: RealizarOperacion.Suma(); break;
                case 2: RealizarOperacion.Resta(); break;
                case 3: RealizarOperacion.Multiplicacion(); break;
                case 4: RealizarOperacion.Division(); break;
                default: Console.WriteLine("Ese no es un numero :"); break;
            }
            Console.WriteLine("********************************************");
            Console.ReadLine();
        }
        #endregion
    }
}
