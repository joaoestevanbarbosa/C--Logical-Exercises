using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class Pitang1
    {
        public static void Execute()
        {
            int[] w = new int[] { 2, 13, 11, 9, 7, 0 };
            int[] z = new int[] { 3, 10, 11, 8, 0, 4 };
            int[] vetor = new int[6] { 1, 2, 3, 4, 5, 6 };
            int x;

            for(int i=1; i< vetor.Length; i++)
            {
                if(w[i] > z[i])
                {
                    x = z[i];
                    z[i] = w[i];
                    w[i] = x; ;
                }
                else
                {
                    w[i] = w[i] * 2;
                    z[i] = z[i] * 3;
                }
            }

            int u = 0;
            int p = 0;
            
            for(int i=1; i<vetor.Length; i++)
            {
                u = u + w[i];
                p = p + z[i];
            }
            string U = u.ToString();
            string P = p.ToString();

            Console.WriteLine(U);
            Console.WriteLine(P);
        }
    }
}
