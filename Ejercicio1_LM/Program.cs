using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_LM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Selecion una opcion para convertir: 1-Segundos o 2-Minutos");
            double conver = double.Parse(Console.ReadLine());

            if(conver == 1)
            {
                Console.Write("Escriba la cantidad de horas: ");
                double hora = double.Parse(Console.ReadLine());
                double convertrm = (hora * 60);

                Console.Write($"En {hora} horas, hay {convertrm} minutos");
                Console.ReadKey();
            }
            else{
                Console.Write("Escriba la cantidad de horas: ");
                double hora = double.Parse(Console.ReadLine());
                double convertirs = hora * 360;

                Console.Write($"En {hora} horas, hay {convertirs} minutos");
                Console.ReadKey();
            }
        }
    }
}
