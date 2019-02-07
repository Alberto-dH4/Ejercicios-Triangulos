using System;

public class Program
{
    public static void Main()
    {
        //Ingreso de datos
        Console.WriteLine("Por favor ingrese los votos del partido 1");
        int partido1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los votos del partido 2");
        int partido2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los votos en blanco");
        int blancos = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los votos anulados");
        int anulados = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el número total de la población");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el porcentaje de mayores de edad");
        double p = double.Parse(Console.ReadLine()) / 100;


        bool a = (partido1 + partido2 + blancos + anulados) > n;
        bool b = Math.Abs(partido1 - partido2) < ((partido1 + partido2 + blancos + anulados) * 0.1);
        bool c = (partido1 + partido2 + blancos + anulados) < (n * 0.3);
        bool ganador = partido1 > partido2;

        if ((a || b) && c)
        {
            Console.WriteLine("Las votaciones deben ser ejecutadas nuevamente");
        }
        else if (ganador)
        {
            Console.WriteLine("El ganador es el partido 1");
        }
        else Console.WriteLine("El ganador es el partido 2");
    }

}