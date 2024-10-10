using System;
using System.Collections.Generic;
using System.Text;

namespace CURSO_CONSOLA_BASICO
{
    class Clase_Padre
    {
        #region METODO QUE TIENE LA OPERACION SUMA
        // METODO DE LA SUMA 
        public void Suma()
        {
            Console.WriteLine("Ingrese el primer numero x favor");
            double NumUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero x favor");
            double NumDos = double.Parse(Console.ReadLine());

            double Suma = NumUno + NumDos;
            Console.WriteLine("********************************************");
            Console.WriteLine("El resultado de la suma es de :" + Suma);
            Console.WriteLine("********************************************");
            Console.ReadLine();
        }
        #endregion

        #region METODO QUE TIENE LA OPERACION RESTAR
        // METODO DE LA RESTA
        public void Resta()
        {
            Console.WriteLine("Ingrese el primer numero x favor");
            double NumUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero x favor");
            double NumDos = double.Parse(Console.ReadLine());

            double Resta = NumUno - NumDos;
            Console.WriteLine("********************************************");
            Console.WriteLine("El resultado de la resta es de :" + Resta);
            Console.WriteLine("********************************************");
            Console.ReadLine();
        }
        #endregion

        #region METODO QUE TIENE LA OPERACION MULTIPLICACION
        // METODO DE LA MULTIPLICACION
        public void Multiplicacion()
        {
            Console.WriteLine("Ingrese el primer numero x favor");
            double NumUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero x favor");
            double NumDos = double.Parse(Console.ReadLine());

            double Multiplicacion = NumUno * NumDos;
            Console.WriteLine("********************************************");
            Console.WriteLine("El resultado de la multiplicacion es de :" + Multiplicacion);
            Console.WriteLine("********************************************");
            Console.ReadLine();
        }
        #endregion

        #region METODO QUE TIENE LA OPERACION DIVISION
        // METODO DE LA DIVISION
        public void Division()
        {
            Console.WriteLine("Ingrese el primer numero x favor");
            double NumUno = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero x favor");
            double NumDos = double.Parse(Console.ReadLine());

            double Division = NumUno / NumDos;
            Console.WriteLine("********************************************");
            Console.WriteLine("El resultado de la division es de :" + Division);
            Console.WriteLine("********************************************");
            Console.ReadLine();
        }
        #endregion
    }
}
