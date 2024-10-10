using System;
using System.Collections; // referencia para usar el ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.EJERCICIOS_PRACTICOS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.MOSTRAR MENSAJE EN CONSOLA
            //Console.WriteLine("Hola Mundo");
            //Console.ReadLine(); 
            #endregion

            #region 2.MOSTRAR 20 NUMEROS IMPARES
            //  Mostrar los nùmeros impares entre el 0 y el 20
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine(); 
            #endregion

            #region 3.MOSTRAR 20 NUMEROS PARES
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine(); 
            #endregion

            #region 4.MOSTRAR NUMEROS DEL 20 AL 1 
            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine(); 
            #endregion

            #region 5.MOSTRAR MULTIPLOS DE 3
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadLine(); 
            #endregion

            #region 6.MOSTRAR MULTIPLOS DE 3 Y DE 2
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 3 == 0 || i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read(); 
            #endregion

            #region 7.COMO MOSTRAR LA HORA Y LA FECHA DEL SISTEMA.
            //DateTime fecha = DateTime.Today;
            //Console.WriteLine(fecha);
            //Console.ReadLine(); 
            #endregion

            #region 8.CREACION DE UN ARREGLO
            //int[] numeros = new int[5];
            //numeros[0] = 123456789;
            //Console.WriteLine(numeros[0].ToString());
            //Console.ReadLine(); 
            #endregion

            // TROPA DE HEROES

            #region 9.LLENADO DE UN VECTOR 
            //string[] Vector = new string[10];

            //for (int i = 0; i < Vector.Length; i++)
            //{
            //    Vector[i] = "Mi posicion es : " + i;
            //}

            //for (int xx = 0; xx < Vector.Length; xx++)
            //{
            //    Console.WriteLine(xx);
            //}
            //Console.ReadLine();
            #endregion

            #region 10.DIFERENCIA ENTRE UN VECTOR Y UNA MATRIZ
            //// LA DIFERNCIA VIENE SIENDO QUE UN VECTOR SERIA SOLO UNA LINEA 
            //// Y UNA MATRIZ SERIA MAS UN CONJUNTO DE FILAS Y COLUMNAS COMO EXCEL

            //int[] Declaracion_Vector = new int[3];
            //int[,] Declaracion_Matriz = new int[1, 3];

            //Declaracion_Matriz[0, 0] = 111111;
            //Declaracion_Matriz[0, 1] = 222222;
            //Declaracion_Matriz[0, 2] = 333333;

            //for (int i = 0; i < Declaracion_Matriz.Length; i++)
            //{
            //    Console.WriteLine(Declaracion_Matriz[0, i]);
            //}
            //Console.ReadLine(); 
            #endregion

            #region 11.COMO RELLENAR Y LEER MATRICES

            //int[,] MatrizTB = new int[5, 5];

            //for (int filas = 0; filas < MatrizTB.GetLength(0); filas++) // LEE LAS FILAS AL USAR GETLENGTH 0
            //{
            //    for (int col = 0; col < MatrizTB.GetLength(1); col++) // LEE LAS COLUMNAS AL USAR GETLENGTH 1
            //    {
            //        MatrizTB[filas, col] = ((filas + 3) * (col + 4));
            //    }
            //}

            //for (int filas = 0; filas < MatrizTB.GetLength(0); filas++) // LEE LAS FILAS AL USAR GETLENGTH 0
            //{
            //    for (int col = 0; col < MatrizTB.GetLength(1); col++) // LEE LAS COLUMNAS AL USAR GETLENGTH 1
            //    {
            //        Console.WriteLine("La posicion es :" + filas + "," + col + MatrizTB[filas, col]);
            //    }
            //}
            //Console.ReadLine(); 
            #endregion

            #region 12.COMO LEER UN VECTOR USANDO FOREACH
            //int[] VectorTB = { 322, 485, 555, 6667 };

            //foreach (var Numero in VectorTB) // VAR se ocupa cuando no sabemos el valor de la variables
            //{
            //    Console.WriteLine(Numero.ToString());
            //}
            //Console.ReadLine(); 
            #endregion

            #region 13.COMO HACER y LEER Un ARRAYLIST - ARREGLO DINÁMICO

            //// ARRAYLIST
            //ArrayList lista = new ArrayList();
            //lista.Add("Hola Mundo");
            //lista.Add("Mi nombre es Diego");
            //lista.Add(2022);
            //foreach (var dato in lista)
            //{
            //    Console.WriteLine(dato.ToString());
            //}
            //Console.ReadLine();
            #endregion

            #region 14.COMO HACER y LEER un LIST en C# - LISTA GENÉRICA
            //// La LIST los permite almacenar informacion pero los limita a un solo tipo de datos 
            //// mas no almacenar o usar varios al mismo tiempo.

            //List<int> lista = new List<int>();
            //lista.Add(2020);
            //lista.Add(2021);
            //lista.Add(2022);

            //foreach (var dato in lista)
            //{
            //    Console.WriteLine(dato.ToString());
            //}
            //Console.ReadLine();

            #endregion


        }
    }
}
