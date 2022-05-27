using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVA_PRODUCTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Ingrese el precio del Producto poor Favor");
            double precio = double.Parse(Console.ReadLine());

            double iva = precio + precio * 0.13;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" El precio del Producto más Iva es de :" + iva);
            Console.ReadLine();
        }
    }
}
