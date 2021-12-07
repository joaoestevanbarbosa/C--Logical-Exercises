using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    public class NumberCountDigit
    {
        //Code in C# to count number of times a digit appears in a number.
        public static void Executar()
        {
            Console.WriteLine("Quai número você deseja digitar, de no máximo 10 dígitos?");
            var numberConsole = Console.ReadLine();
            int number;

            while (!Int32.TryParse(numberConsole, out number) || numberConsole.Length > 10 )
                {
                Console.WriteLine("Valor inválido por ter mais de 10 dígitos ou caracter que não é numero");
                Console.WriteLine("Quai número você deseja digitar, de no máximo 10 dígitos?");
                }
            int numberNumber = Int32.Parse(numberConsole);//Numero grande que pretendo passar no console


            Console.WriteLine("Quai dígito você quer contar?");
            var digiterConsole = Console.ReadLine();
            int digiter;

            if (digiterConsole.Length != 1 || !Int32.TryParse(digiterConsole, out digiter)) 
                while (digiterConsole.Length != 1 || !Int32.TryParse(digiterConsole, out digiter))
                {
                Console.WriteLine("Valor inválido por ter mais de 2 dígitos ou caracter que não é numero");
                Console.WriteLine("Quai dígito você quer contar?");
            }
            int digiterDigiter = Int32.Parse(digiterConsole);//Numero grande que pretendo passar no console
         
            int count = 0;


            while (numberNumber > 0)
            {
                if (numberNumber % 10 == digiterDigiter)
                {
                    count++;
                    numberNumber = numberNumber / 10;
                }
            }
            Console.WriteLine($"Seu número possui {count} dígitos de valor igual a {digiterDigiter}");
        }   
    }
}
