using System;

public class Program
{
    public static void Main()
    {
        Random aleatorio = new Random();
        int total = 0;
        int carta1 = aleatorio.Next(1, 11);

        int carta2 = 0;

        total = carta1 + carta2;
        string respuesta = "s";
        Console.Write("Carta: " + carta1);

        while (total < 21 && respuesta == "s")
        {

            carta2 = aleatorio.Next(1, 11);

            Console.Write("\nCarta: " + carta2);

            total += carta2;
            Console.Write("\nTotal: " + total);
            if (total == 21)
            {
                Console.Write("Has Ganado ");
            }
            else if (total > 21)
            {
                Console.Write("Has perdido ");
            }
            else
            {
                Console.WriteLine("\n¿Desea continuar? (s/n):");
                respuesta = Console.ReadLine();
            }
        }
        Console.WriteLine("Fin Del Juego");
    }
}
