using System;

public class Program
{
    public static void Main()
    {
        //Ingreso de datos
        Console.WriteLine("Ingrese las variables b°,z,y");
        double bGrados = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        //Conversión de ángulos a radianes
        double b = bGrados * (Math.PI / 180.0);

        //Cálculo de valores
        double a = Math.Atan(y / z);
        double x = (Math.Tan(b + a) * z) - y;

        //Imprimir salida
        Console.WriteLine("x:" + x);
    }
}
