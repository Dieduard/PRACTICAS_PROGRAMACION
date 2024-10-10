using System;
using System.Collections.Generic;
using System.Text;

namespace CURSO_CONSOLA_BASICO
{
    class Clase_Instancias
    {
        private int NumUno, NumDos, Suma;
        public void MiClaseCurso()
        {
            #region APRENDIENDO A CREAR UNA CLASE Y INSTANCEARLA CON EL PROYECTO MAIN ()
            Console.WriteLine("Ingrese el Primer Numero");
            NumUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo Numero");
            NumDos = int.Parse(Console.ReadLine());

            Suma = NumUno + NumDos;
            Console.WriteLine("El Resultado de la Suma es : " + Suma);
            Console.ReadLine();
            #endregion
        }
    }
}
