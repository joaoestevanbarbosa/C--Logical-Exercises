using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class ParOuImpar
    {
        public static void Execute()
        {
            //Exercício 01: Desenvolva um algoritmo que solicite a entrada de um número e calcule se o
            //número é par ou impar.

            Console.WriteLine("Escreva o número para saber se é par ou ímpar");
            string numeroConsole = Console.ReadLine();
            int numeroParse = int.Parse(numeroConsole);

            if(numeroParse % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else 
            {
                Console.WriteLine("Ímpar");
            }

        }
    }
}
