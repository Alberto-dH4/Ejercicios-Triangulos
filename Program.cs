using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar el numero de jugadores + nombres
            Console.WriteLine("Digite el numero de jugadores");
            int n = int.Parse(Console.ReadLine());

            string[] nombres = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese un nombre");
                nombres[i] = Console.ReadLine();
            }
            // Establecer arrelgo de puntaje + turnos
            int[] total = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Turno de " + nombres[i]);

                Random aleatorio = new Random();
                total[i] = 0;
                int carta1 = aleatorio.Next(1, 11);

                int carta2 = 0;

                total[i] = carta1 + carta2;
                string respuesta = "s";
                Console.Write("Carta: " + carta1);

                while (total[i] < 21 && respuesta == "s")
                {

                    carta2 = aleatorio.Next(1, 11);

                    Console.Write("\nCarta: " + carta2);

                    total[i] += carta2;
                    Console.Write("\nTotal: " + total[i]);
                    if (total[i] == 21)
                    {
                        Console.Write("\nGANASTE ");
                    }
                    else if (total[i] > 21)
                    {
                        Console.Write("\n[PIERDES]");
                        total[i] = 0;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n¿Desea continuar? (s/n):");
                        respuesta = Console.ReadLine();
                    }
                    
                }
            }
            for (int b = 0; b < n - 1; b++) {
                for (int a = 0; a < n - 1; a++)
                {

                    if (total[a] < total[a + 1])
                    {
                        int tmp = total[a];
                        total[a] = total[a + 1];
                        total[a + 1] = tmp;

                        string tmp2 = nombres[a];
                        nombres[a] = nombres[a + 1];
                        nombres[a + 1] = tmp2;
                    }
                }
            }
            for(int a = 0; a < n; a++)
            {
                Console.WriteLine("\n\nPuntaje: " + total[a]);
                Console.WriteLine("Jugador: " + nombres[a]);

            }

            Console.WriteLine("\n[GANADOR] " + nombres[0] + " con un total de: " + total[0]);
            Console.WriteLine("\nFin Del Juego");
        }
    }
}
