using System;

public class Program
{
    public static void Main()
    {
        //Ingreso de datos
        Console.WriteLine("Ingrese las variables w,t,c°");
        double w = double.Parse(Console.ReadLine());
        double t = double.Parse(Console.ReadLine());
        double cGrados = double.Parse(Console.ReadLine());

        //Conversión de ángulos a radianes
        double c = cGrados * (Math.PI / 180.0);

        //Cálculo de valores
        double z = Math.Sin(c) * t;
        double y = z / (Math.Tan(c));
        double xy = (w * w) - (z * z);
        double x = Math.Sqrt(xy) - y;

        //Imprimir salida
        Console.WriteLine("x:" + x);
    }
}
