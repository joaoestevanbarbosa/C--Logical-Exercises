using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class MenorOuMaiorDe18
    {
        //Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
        //se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos
        //exiba na cor verde “Permissão concedida”.

        public static void Execute()
        {
            Do();
        }

        private static void Do()
        {
            int idade;
            Console.Write("Insira sua idade:");
            string idadeConsole = Console.ReadLine();
            int.TryParse(idadeConsole, out idade);

            if(idade< 18)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Permissão");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Permissão concedida");
            }
        }

        
    }
}
