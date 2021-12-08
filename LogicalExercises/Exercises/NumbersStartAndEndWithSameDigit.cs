using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class NumbersStartAndEndWithSameDigit
    {
        public static void Execute()
        {
            // Code in C# to print numbers that starts and ends with the same digit.

            int count = 0;
            int n = 1;

            while (count < 100)
            {
                int last = n % 10;
                int first = 0;
                int _n = n / 10;

                while (_n > 0)
                {
                    first = _n;
                    _n = _n / 10;
                }

                if (first == last)
                {
                    count++;
                    Console.WriteLine($"{count} {n}");
                }

                n++;
            }
        }
    }
}
