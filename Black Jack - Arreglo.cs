using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
                    }
                    else
                    {
                        Console.WriteLine("\n¿Desea continuar? (s/n):");
                        respuesta = Console.ReadLine();
                    }
                }
            }
            int max = 0, indice = 0;

            for(int i = 0; i < total.Length; i++)
            {
                
                if(total[i] > max && total[i] <= 21)
                {
                    max = total[i];
                    indice = i;
                    
                }
            }
            Console.WriteLine("Ganó " + nombres[indice] + " con un total de: " + max);
            Console.WriteLine("\nFin Del Juego");
        }
    }
}
