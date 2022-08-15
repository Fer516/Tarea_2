using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios3_LM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el numero de repetciones");
            double repe = double.Parse(Console.ReadLine());

            for (int i = 1; i <= repe; i++)
            {

                Console.WriteLine(i);

                Console.WriteLine("Escriba la altura del triangulo: ");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Escriba el lado  del triangulo: ");
                double A = int.Parse(Console.ReadLine());

                Console.WriteLine("Escriba la base del triangulo: ");
                double B = int.Parse(Console.ReadLine());


                double Area = (B * altura) / 2;
                double Perimetro = A + B;

                Console.Write($"El area del trigulo es de: {Area}cm2 y \n");
                Console.Write($"el perimetro del triangulo es de: {Perimetro}cm2 \n");
                Console.ReadKey();
            }
    }
}
