using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class DIOSucessorPar
    {
        //Para se preparar para os outros problemas, vamos fazer um teste.Dado um número X, 
        //retorne o menor número par maior do que X.

        //Entrada
        //Uma linha contendo um número  0 < X< 107.

        //Saída
        //Uma linha contendo a resposta do problema.

        public static void Execute()
        {
            Console.Write("Digite o número: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine($"{x + 2}");
            }

            else
            {
                Console.WriteLine($"{x + 1}");
            }
        }
    }
}
