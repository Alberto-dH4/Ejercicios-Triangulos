using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Triangulo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese las variables c,z");
            double cGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            //Conversión de ángulos a radianes
            double c = cGrados * (Math.PI / 180.0);

            //Cálculo de valores
            double y = z / Math.Tan(c);
            double t = z / Math.Sin(c);
            double a = Math.Atan(y / z);

            //Conversión
            double aGrados = a / (Math.PI / 180.0);

            //Imprimir salida
            Console.WriteLine("y:" + y);
            Console.WriteLine("t:" + t);
            Console.WriteLine("a:" + aGrados);

        }
    }
}
