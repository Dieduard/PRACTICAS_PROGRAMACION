using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.REPASO_CONSOLA_VARIEDAD
{
    class Program
    {
        static void Main(string[] args)
        {
            /*-----------------------------------------------------------------------------*/
            // CURSO DE UDEMY

            #region COMO HACER EL PRIMER HOLA MUNDO
            //// EL HOLA MUNDO
            //Console.WriteLine("Hola Mundo");
            //Console.ReadLine(); 
            #endregion

            #region COMO MOSTRAR MENSAJES EN CONSOLA
            //int Num = 10;
            //int Resul = Num * 5;
            //Console.WriteLine("{0}", Resul);

            //int suma = 8 + 20;
            //Console.WriteLine("8+20 es = " + suma);

            //string cadena = "Hola esta es una cadena";
            //Console.WriteLine(cadena);
            //Console.ReadLine(); 
            #endregion

            #region USO DE OPERADORES UNITARIOS /ARITMETICOS / COMPARACION
            //// OPERADORES 
            //int a = 10;
            //int b = 2;
            //Console.WriteLine("-------------------------------------");
            ////OPERADORES ARITMETICOS/binarios
            //Console.WriteLine("EJEMPLO DE OPERADORES ARITMETICOS");
            //Console.WriteLine("Suma = " + (a + b));
            //Console.WriteLine("Resta = " + (a - b));
            //Console.WriteLine("Multi = " + a * b);
            //Console.WriteLine("Divi = " + a / b);
            //Console.WriteLine("Modulo = " + a % b);
            //Console.WriteLine("-------------------------------------");

            //// OPERADORES UNITARIOS 
            //Console.WriteLine("EJEMPLO DE OPERADORES UNITARIOS");
            //a++; // a= a+1;
            //a--; // a= a1;
            //Console.WriteLine("-------------------------------------");

            //// OPERADORES DE COMPARACION
            //Console.WriteLine("EJEMPLO DE OPERADORES COMPARACION");
            //Console.WriteLine(a > b);
            //Console.WriteLine(a < b);
            //Console.WriteLine(a >= b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);
            //Console.WriteLine("-------------------------------------");
            //Console.ReadLine(); 
            #endregion

            #region USO DE SENTENCIAS CONDICIONALES
            //// USO DE SENTENCIAS CONDICIONALES

            ////USO DEL SENTENCIA IF/ELSE
            //int A = 10, B = 5;
            //if (A > B)
            //{
            //    Console.WriteLine("CORRECTO >> A es mayor que B");
            //}
            //else
            //{
            //    Console.WriteLine("INCORRECTO B es menor que A");
            //}
            ////USO DEL SWITCH
            //Console.WriteLine("--------------------------------------------------");
            //int NumUno, NumDos, opc, suma, resta;
            //Console.WriteLine("Realizar Suma  ------> # 1 ");
            //Console.WriteLine("Realizar Resta ------> # 2 ");
            //Console.WriteLine("Ingrese su opcion");
            //opc = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------------------------");
            //switch (opc)
            //{
            //    case 1:
            //        Console.WriteLine("Ingrese el Primer Numero");
            //        NumUno = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Ingrese el Segundo Numero");
            //        NumDos = int.Parse(Console.ReadLine());

            //        suma = NumUno + NumDos;
            //        Console.WriteLine("La suma de sus Numero es : " + suma);
            //        break;

            //    case 2:
            //        Console.WriteLine("Ingrese el Primer Numero");
            //        NumUno = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Ingrese el Segundo Numero");
            //        NumDos = int.Parse(Console.ReadLine());

            //        resta = NumUno - NumDos;
            //        Console.WriteLine("La resta de sus Numero es : " + resta);
            //        break;

            //    default:
            //        Console.WriteLine("Numero fuera de los limites");
            //        break;
            //}
            //Console.WriteLine("--------------------------------------------------");
            //Console.ReadLine(); 
            #endregion

            // CICLOS DE REPETICION 


            #region CREACION Y USO DE UN VECTOR (ARREGLO)
            //// VECTORES
            //int numx = 0;
            //int[] numeros;
            //numeros = new int[5];

            //numeros[0] = 123;
            //numeros[1] = 345;
            //numeros[2] = 678;
            //numeros[3] = 8910;
            //numeros[4] = 111213;
            //MessageBox.Show(numeros[0].ToString()); 
            #endregion

            #region COMO RECORRER UN ARREGLO DE PRINCIPIO A FIN
            //// VECTORES          
            //int[] numeros;
            //numeros = new int[5];

            //numeros[0] = 123;
            //numeros[1] = 345;
            //numeros[2] = 678;
            //numeros[3] = 8910;
            //numeros[4] = 111213;
            //MessageBox.Show(numeros.Length.ToString());
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    MessageBox.Show(numeros[i].ToString());
            //} 
            #endregion

            #region RECORRER UN ARREGLO CON FOREACH
            //int[] VectorTB = { 342, 452, 456, 875 };
            //foreach (var num in VectorTB)
            //{
            //    MessageBox.Show(num.ToString());
            //} 
            #endregion

            #region CREACION Y USO DE UN ARRAYLIST
            //// ARRAYLIST = VIENE SIENDO UN AREGLO DINAMICO QUE ACEPTA TODO TIPO DE DATO.
            //// LA ARRAYLIST NO SE OCUPA MUCHO ACTUALMENTE COMO ANTES PORQUE HOY ESTA LA OPCION LIST
            //ArrayList Lista = new ArrayList();
            //Lista.Add(123);
            //Lista.Add("Diego");
            //Lista.Add(1.23);
            //foreach (var num in Lista)
            //{
            //    MessageBox.Show(num.ToString());
            //} 
            #endregion

            #region CREACION DE UN LIST Y LA FORMA DE USARLA
            ////LIST VIENE SIENDO EL QUE VIENE SUSTITUYENDO A ARRAYLIST
            //List<int> Lista2 = new List<int>();
            //Lista2.Add(123);
            //Lista2.Add(354);
            //foreach (var num in Lista2)
            //{
            //    MessageBox.Show(num.ToString());
            //}
            #endregion

            

        }
    }
}
