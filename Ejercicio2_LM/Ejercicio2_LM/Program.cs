﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_LM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba 0 para terminar el programa");
            int stop = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Escriba la altura del cilindro: ");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el radio del cilindro: ");
                double R = double.Parse(Console.ReadLine());

                double R2 = (R + altura);
                double Area = (3.14 * 2) * R2;
                double Volumen = 3.14 * (R * 2) * altura;

                Console.Write($"El area del cilindro es de: {Area} cm2 y \n");
                Console.Write($"el perimetro del cilindro es de: {Volumen} cm2 ");

                Console.ReadKey();

            } while (stop == 0);
            Console.ReadKey();
        }
    }
}
