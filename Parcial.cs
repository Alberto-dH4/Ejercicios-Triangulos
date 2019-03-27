using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Parcial {

    string[] names;
    double[] data;
    public static int codigo = 1; // 0 Primer simulacro. 1 Segundo simulacro

    public Parcial(string[] _names, double[] _data) {
        data = new double[_data.Length];
        _data.CopyTo(data, 0);
        names = new string[_names.Length];
        _names.CopyTo(names, 0);
    }


    public int PrimerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        int salida = 0 ;
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0;
        for (int i = 0; i < notas.Length; i++){
            total += notas[i];
        }
        double promedio = total / notas.Length;
        for (int i = 0; i < nombres.Length; i++){
            if(notas[i] <= promedio){
                salida++;
            }
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] SegundoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[5];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        double promedio = total / notas.Length;

        for (int a = 0; a < notas.Length - 1; a++)
        {
            for (int i = 0; i < notas.Length - 1; i++)
            {

                if (Math.Abs(promedio - notas[i]) > Math.Abs(promedio - notas[i + 1]))
                {
                    double tmp = notas[i];
                    notas[i] = notas[i + 1];
                    notas[i + 1] = tmp;

                    string tmp2 = nombres[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tmp2;
                }
            }
        }
        for(int i = 0; i < salida.Length; i++){
            salida[i] = nombres[i];
        }
        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] TercerPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        double total = 0;
        int contador = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            total += notas[i];
        }
        double promedio = total / notas.Length;

        for(int i = 0; i < notas.Length; i++){
            if(notas[i] >= promedio){
                contador += 1;
            }
        }
        salida = new string[contador];
        contador = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= promedio)
            {
                salida[contador] = nombres[i];
                contador += 1;
            }
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }

    public string[] CuartoPunto() {
        string[] nombres = new string[names.Length]; names.CopyTo(nombres, 0);
        double[] notas = new double[data.Length]; data.CopyTo(notas, 0);

        string[] salida = new string[0];
        //--------------------------------------------
        //- Abajo de esta línea va su código ---------
        int contador = 0;

        for (int i = 0; i < nombres.Length; i++)
        {
            string palabra = nombres[i];
 
            char letra = palabra[0];

            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                contador += 1;
            }                        
        }

        salida = new string[contador];
        int posicion = 0;

        for (int i = 0; i < nombres.Length; i++)
        {
            string palabra = nombres[i];
            
            char letra = palabra[0];

            if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
            {
                salida[posicion] = palabra;
                posicion += 1;
            }            
        }

        //- Arriba de esta línea va su código --------
        return salida;
    }
}


