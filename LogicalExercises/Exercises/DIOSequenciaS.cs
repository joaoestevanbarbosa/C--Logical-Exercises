using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class DIOSequenciaS
    {
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
