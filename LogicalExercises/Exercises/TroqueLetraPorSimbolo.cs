using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class TroqueLetraPorSimbolo
    {
        //Desenvolva um algoritmo que solicite a entrada de uma frase,
        //após isto troque todas as letras A ou a por &.
        public static void Execute()
        {
            string palavraConsole = Console.ReadLine();
            string palavraNova = palavraConsole.Replace("a", "&").Replace("A", "&");
            Console.WriteLine(palavraNova);
        }
        

        

    }
}
