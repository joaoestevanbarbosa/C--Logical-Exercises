using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class VaiDarTrabalhoPitang
    {
        public static void Execute ()
        {
            
            int b;
            int a = 0;
            int[] veet = new int[15];        

            for (int z=1; z < veet.Length; z++ )
            {
                b = z + 1;
                veet[z] = b + (3 * z);
                if (z > 0)
                {
                    if(b < veet[z])
                    {
                        a = a + 2;
                    }
                    else
                    {
                        a = a - 1;
                    }
                }
            }

            if (veet[5] > veet [10])
            {
                for(int z=5; z < veet.Length; z++)
                {
                    veet[z] = veet[z] - 2;
                }
            }

            Console.WriteLine(veet[5]);
        }
    }
}
