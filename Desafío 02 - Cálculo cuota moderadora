using System;

public class Program
{
    public static void Main()
    {
        //$ 828,116
        //Ingreso de datos
        Console.WriteLine("Por favor ingrese su salario mensual.");
        double s = double.Parse(Console.ReadLine());
        double smmlv = 828116;

        //Condicionales
        if (s < (smmlv * 2))
        {
            double A = s * 0.117;
            Console.WriteLine("Le corresponde la tarifa A y su valor de cuota moderada es de: " + A);
        }
        else if ((smmlv * 2) <= s && s < (smmlv * 5))
        {
            double B = s * 0.461;
            Console.WriteLine("Le corresponde la tarifa B y su valor de cuota moderada es de: " + B);
        }
        else if (s >= (smmlv * 5))
        {
            double C = s * 1.215;
            Console.WriteLine("Le corresponde la tarifa C y su valor de cuota moderada es de: " + C);
        }
    }
}
