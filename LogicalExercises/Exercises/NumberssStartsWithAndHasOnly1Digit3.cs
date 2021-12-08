using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class NumberssStartsWithAndHasOnly1Digit3
    {
        public static void Execute()
        {
            var count = 0;
            var n = 1000;

            while(count < 100)
            {
                var _n = n;
                var remain = 0;

                while(_n > 0)
                {
                    remain = _n % 10;
                    _n = _n / 10;

                    if(remain ==3 && _n == 0)
                    {
                        break;
                    }
                }

                if(remain ==3 && _n ==0)
                {
                    count++;
                    Console.WriteLine($"{count}) {n}");
                }

                n++;

            }

        }
    }
}
