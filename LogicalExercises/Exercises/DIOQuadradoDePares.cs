using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class DIOQuadradoDePares
    {

         //Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.

         //Entrada
         //A entrada contém um valor inteiro N (5 < N< 2000).

        //Saída
        //Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.

        //Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés de 1000000
        //o que ocasionará resposta errada.Neste caso, configure a precisão adequadamente para que isso não ocorra.

        //Entrada: 6    Saída: 2^2 = 4; 4^2 = 16; 6^2 = 36;

        public static void Execute()
        {
            Console.Write("Escreva o número: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int b = i * i;
                    Console.WriteLine($"{i}^2 = {b}");
                }
            }
        }
    }
}
