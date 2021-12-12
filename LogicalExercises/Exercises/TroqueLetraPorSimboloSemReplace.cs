using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class TroqueLetraPorSimboloSemReplace
    {

        //6 – Desenvolva um algoritmo que solicite a entrada de uma frase, após isto troque todas as letras A ou a por &,
        //porém não utilize o método Replace().          
           
        public static void Execute()
        {
            Console.Write("Escreva a frase: ");
            string fraseConsole = Console.ReadLine();
            Console.WriteLine(Alterar(fraseConsole));
        }

        private static string Alterar(string fraseConsole)
        {
            if (fraseConsole.Trim().Length > 0) //trim juta todas as letras e tira o espaço
            {
                int total = fraseConsole.Length;
                int i = 0;
                var stringBuilder = new StringBuilder(fraseConsole);
                
                while (i < total)
                {
                    if(stringBuilder[i] == 'a')
                    {
                        stringBuilder[i] = '&';
                    }
                    if (stringBuilder[i] == 'A')
                    {
                        stringBuilder[i] = '&';
                    }
                    i++;
                }

                fraseConsole = stringBuilder.ToString();
                return fraseConsole;
            }
            else
            {
                return null;
            }
        }
    }
}
