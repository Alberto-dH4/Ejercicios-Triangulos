using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Triangulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese las variables y,z");
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Cálculo de valores
            double a = Math.Atan(y / z);
            double c = Math.Atan(z / y);
            double t = z / Math.Sin(c);

            //Concersión
            double aGrados = a / (Math.PI / 180.0);
            double cGrados = c / (Math.PI / 180.0);

            //Imprimir salida
            Console.WriteLine("a:" + aGrados);
            Console.WriteLine("c:" + cGrados);
            Console.WriteLine("t:" + t);

        }
    }
}
