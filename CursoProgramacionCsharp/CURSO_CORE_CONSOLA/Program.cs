using System;

namespace CURSO_CORE_CONSOLA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*https://www.discoduroderoer.es/ejercicios-propuestos-y-resueltos-basicos-en-c-sharp/ */

            #region TIPO DE DATOS POSITIVOS COMO NEGATIVOS
            /* uint numeros = -125; AL PONER LO QUE VIENE SIENDO LA "U" SOLO PERMITE DATOS POSITIVOS 
                                     AL QUITARSELA PERMITE NUMEROS TANTO NEGATIVOS COMO POSITIVOS 
                LO MISMO AL USAR EL ULONG
                 */
            #endregion

            /*1) Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar
                 el valor de la suma de las 3 anteriores. Mostrar por consola.*/

            #region 1) EJERCICIO NUMERO UNO
            //ClaseDatos Sumando = new ClaseDatos();
            //Sumando.SumaNumeros();
            //Console.ReadLine();
            #endregion

            /*2) Pedir por consola un nombre de persona y el nombre de una ciudad (no hace falta que sean reales 
             o comprobarlos) y mostrar por pantalla, el siguiente mensaje «Hola » <nombre> » bienvenido a » <ciudad>*/
            #region 2) EJERCICIO NUMERO DOS
            //ClaseDatos DatosPersonales = new ClaseDatos();
            //DatosPersonales.MostrarDatosPersonales();
            //Console.ReadLine();
            #endregion

            /*3) Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: «Te llamas » <nombre> » y 
                 tienes » <años> » años»*/
            #region 3)EJERCICIO NUMERO TRES
            //ClaseDatos datos = new ClaseDatos();
            //datos.DatosEjecutar();
            //Console.ReadLine(); 
            #endregion

            /*4) Pedir dos números al usuario por teclado y decir que número es el mayor.*/

            #region 4) EJERCICIO NUMERO CUATRO
            //ClaseDatos NumeroMayor = new ClaseDatos();
            //NumeroMayor.NumeroMayor();
            //Console.ReadLine();
            #endregion

            /*5) Pedir el nombre de la semana al usuario y decirle si es fin de semana o no.  En caso de error, indicarlo.*/

            ClaseDatos Semana = new ClaseDatos();
            Semana.DiaSemana();
            Console.ReadLine();




        }
    }
}
