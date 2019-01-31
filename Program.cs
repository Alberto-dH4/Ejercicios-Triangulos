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
            Console.WriteLine("Le corresponde la tarifa A");
        }
        else if ((smmlv * 2) <= s && s < (smmlv * 4))
        {
            Console.WriteLine("Le corresponde la tarifa B");
        }
        else if (s >= (smmlv * 4))
        {
            Console.WriteLine("Le corresponde la tarifa c");
        }
    }
}
