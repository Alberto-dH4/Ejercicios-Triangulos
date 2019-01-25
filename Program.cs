using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Triangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos
            Console.WriteLine("Ingrese las variables t,a");
            double t = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());

            //Conversión de ángulos a radianes
            double a = aGrados * (Math.PI / 180.0);

            //Cálculo de valores
            double y = t * Math.Sin(a);
            double z = y / Math.Tan(a);
            double c = Math.Atan(z / y);

            //Conversión
            double cGrados = c / (Math.PI / 180.0);

            //Imprimir salida
            Console.WriteLine("y:" + y);
            Console.WriteLine("z:" + z);
            Console.WriteLine("c:" + cGrados);

        }
    }
}
