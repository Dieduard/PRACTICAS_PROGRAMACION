using System;
using System.Collections.Generic;
using System.Text;

namespace CURSO_CORE_CONSOLA
{
    class ClaseDatos
    {
        #region SUMA DE NUMEROS Y MOSTRAR DATOS
        public void SumaNumeros()
        {
            int numUno = 10, numDos = 15, Suma = 0;
            Suma = numUno + numDos;
            Console.WriteLine("La suma de los es: " + Suma);
            Console.ReadLine();
        }
        #endregion

        #region MOSTRAR LOS DATOS PERSONALES NOMBRE Y CIUDAD
        public void MostrarDatosPersonales()
        {
            string nombre, ciudad;
            Console.WriteLine("Ingrese su nombre por favor");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su ciudad por favor");
            ciudad = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Sus datos son Nombre : " + nombre + " Su Ciudad :" + ciudad);
            Console.ReadLine();
        }
        #endregion

        #region MOSTRAR DATOS PERSONALES NOMBRE Y EDAD
        public void DatosPersonalesDos()
        {
            Console.WriteLine("Ingrese el Nombre por favor");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad por favor ");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Su Nombre es : " + nombre + " Su edad es :" + edad);

        }
        #endregion

        #region DETERMINAR EL NUMERO MAYOR
        public void NumeroMayor()
        {
            int NumUno, NumDos;
            Console.WriteLine("Ingrese el primer numero por favor");
            NumUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero por favor");
            NumDos = int.Parse(Console.ReadLine());

            if (NumUno > NumDos)
            {
                Console.WriteLine("El primer numero es MAYOR");
            }
            else
            {
                Console.WriteLine("El segundo numero es MAYOR");
            }
        }
        #endregion

        #region MOSTRAR SI EL DIA INGRESADO ES DIA DE LA SEMANA O FIN DE SEMANA
        public void DiaSemana()
        {
            //switch (dia.ToLower())
            //{

            //    case "lunes":
            //    case "martes":
            //    case "miercoles":
            //    case "jueves":
            //    case "viernes":
            //        Console.WriteLine("No es fin de semana");
            //        break;
            //    case "sabado":
            //    case "domingo":
            //        Console.WriteLine("Es fin de semana");
            //        break;

            //    default:
            //        Console.WriteLine("Ese dia no es correcto");
            //        break;
            //}
            //Console.ReadLine();

            string dia;
            Console.WriteLine("Ingrese el dia de la semana por favor ");
            dia = Console.ReadLine()
;
            if (dia == "lunes" || dia == "martes" || dia == "miercoles" || dia == "jueves" || dia == "viernes")
            {
                Console.WriteLine("Este es un dia de Semana");
            }
            else if (dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine("Este es un FIN de Semana");
            }
            else
            {
                Console.WriteLine("Ingese un dia de la Semana");
            }
        } 
        #endregion


    }
}
