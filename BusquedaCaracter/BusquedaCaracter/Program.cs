using System;
using System.Collections.Generic;

namespace BusquedaCaracter
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            Console.WriteLine("Escribe una cadena de caracteres");
            cadena = Console.ReadLine();
            Console.WriteLine("Caracter que más se repite '{0}'", maxChar(cadena));
            Console.ReadKey();

        }

        public static char maxChar(string cadena)
        {
            List<Caracter> Caracteres = new List<Caracter>();
            int i, contador = 0, indice = 0;

            for (i = 0; i < cadena.Length - 1; i++)
            {
                Caracter objCaracter = Caracteres.Find(x => x.caracter == cadena[i]);

                if (objCaracter == null)
                {
                    Caracter nuevoCaracter = new Caracter();
                    nuevoCaracter.caracter = cadena[i];
                    nuevoCaracter.contador = 1;

                    Caracteres.Add(nuevoCaracter);
                }
                else
                {
                    objCaracter.contador++;
                }
            }

            contador = Caracteres[0].contador;
            for (i = 1; i < Caracteres.Count; i++)
            {
                if (Caracteres[i].contador > contador)
                {
                    contador = Caracteres[i].contador;
                    indice = i;
                }
            }

            return Caracteres[indice].caracter;
        }
    }

    class Caracter
    {
        public char caracter;
        public int contador;
    }
}

