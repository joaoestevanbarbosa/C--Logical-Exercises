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
            veet[0] = 1;
            veet[1] = 2;
            veet[2] = 3;
            veet[3] = 4;
            veet[4] = 5;
            veet[5] = 6;
            veet[6] = 7;
            veet[7] = 8;
            veet[8] = 9;
            veet[9] = 10;
            veet[10] = 11;
            veet[11] = 12;
            veet[12] = 13;
            veet[13] = 14;
            veet[14] = 15;
           


            for (int z=1; z < veet.Length; z++ )
            {
                b = z + 1;
                veet[z] = b + (3 * z);
                if (z > 0)
                {
                    if(veet[b] < veet[z])
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
        }
    }
}
