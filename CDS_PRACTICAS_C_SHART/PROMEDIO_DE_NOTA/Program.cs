using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROMEDIO_DE_NOTA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ingrese el Nombre del Alumno");
            string nombre = Console.ReadLine();

            Console.WriteLine(" Ingrese la nota # 1 del Alumno");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese la nota # 2 del Alumno");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingrese la nota # 3 Alumno");
            double nota3 = double.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3; 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" La NOTA del Alumno " + nombre + " es :" + promedio);
            Console.ReadLine();
        }
    }
}
