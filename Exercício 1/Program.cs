using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;

            Console.Write("Digite o número: ");
            Numero = int.Parse(Console.ReadLine());

            if (Numero > 0)
            {
                Console.WriteLine("\nO número é positivo.");
            }

                else if (Numero < 0)
                {
                    Console.WriteLine("\nO número é negativo.");
                }

                    else
                    {
                        Console.WriteLine("\nO número é zero.");
                    }

            Console.Write("\nPressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}
