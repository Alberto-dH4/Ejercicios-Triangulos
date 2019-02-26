using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int dado1 = 0, dado2 = 0, total = 0, vidas = 3, contadorP = 0, contadorG = 0;
        string continuar = "s", DosDados = "False";

        while (continuar == "s")
        {
            contadorG += 1;
            contadorP += 1;
            if (contadorP == 2)
            {
                contadorP = 0;
                vidas -= 1;
                Console.WriteLine("Pierdes una vida");
                Console.WriteLine("Vidas = " + vidas);
            }
            else if (contadorG == 3)
            {
                contadorG = 0;
                DosDados = "True";
                dado1 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado 1 = " + dado1);
                dado2 = aleatorio.Next(1, 7);
                Console.WriteLine("Dado 2 = " + dado2);
                total += dado1 + dado2;
                Console.WriteLine("Total = " + total);
                if (dado1 == dado2)
                {
                    vidas += 1;
                    Console.WriteLine("Ganas una vida");
                    Console.WriteLine("Vidas = " + vidas);
                }
            }
            if (DosDados == "False")
            {
                dado1 = aleatorio.Next(1, 7);
                total += dado1;
                Console.WriteLine("Dado = " + dado1);
                Console.WriteLine("Total = " + total);
            }

            DosDados = "False";

            if (vidas == 0)
            {
                total = 0;
                Console.WriteLine("Perdiste");
                Console.WriteLine("Total = " + total);
                break;
            }
            else
            {
                Console.WriteLine("¿Quieres continuar? (s/n)");
                continuar = Console.ReadLine();
            }
        }
        Console.WriteLine("Fin del juego");
    }
}

