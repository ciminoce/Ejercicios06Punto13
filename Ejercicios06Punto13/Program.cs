﻿using System;

namespace Ejercicios06Punto13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicios 06 Punto 13";
            int nro;
            bool seguir = true;
            do
            {
                bool hayError = true;
                do
                {
                    Console.Write("Ingrese un número de al menos 3 cifras:");
                    if (!int.TryParse(Console.ReadLine(), out nro))
                    {
                        Console.WriteLine("Nro mal ingresado");
                    }
                    else if (nro < 0)
                    {
                        Console.WriteLine("Debe ingresar un número positivo");
                    }
                    else if (nro < 100)
                    {
                        Console.WriteLine("Debe ingresar un nro de al menos 3 cifras");
                    }
                    else
                    {
                        hayError = false;
                    }

                } while (hayError);

                Console.WriteLine(NroPalindromo(nro) ? $"{nro} es palíndromo" : $"{nro} no es palíndromo");

                Console.Write("Ejecuta otra vez?(S/N):");
                var respuesta = Console.ReadLine();
                if (respuesta.ToUpper()=="N")
                {
                    seguir = false;
                }
            } while (seguir);
            Console.ReadLine();

        }

        private static bool NroPalindromo(int nro)
        {
            int resto, inverso, resultado;
            double division;
            resultado = nro;
            inverso = 0;
            while (resultado!=0)
            {
                resto = resultado % 10;
                division = resultado / 10;
                resultado =(int) Math.Truncate(division);
                inverso = inverso * 10 + resto;
            }

            return nro == inverso;
        }
    }
}
