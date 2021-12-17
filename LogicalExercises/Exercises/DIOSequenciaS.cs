using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class DIOSequenciaS
    {

        //Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
        //S = 1 + 1/2 + 1/3 + … + 1/100


        public static void Execute()
        {
            double s = 1.0;
            double i = 2.0;

            while (i < 101)
            {

                s += 1 / (i++);

            }

            Console.WriteLine(s.ToString("F")); ;

        }
    }
}
