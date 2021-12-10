using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class Calculadora
    {
        //Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor,
        //exiba o resultado na tela.

        public static void Execute()
        {
            double num1;
            double num2; 
            double resultado = 0;
            char operacao;


            Console.WriteLine("Entre com a operação: ");
            Console.WriteLine("+ Adição:");
            Console.WriteLine("- Subtração:");
            Console.WriteLine("* Multiplicação:");
            Console.WriteLine("/ Divisão:");

            Console.WriteLine();

            Console.Write("Operacao:");

            char.TryParse(Console.ReadLine(), out operacao);

            Console.WriteLine();
            Console.Write("Informe o 1o valor:");
            double.TryParse(Console.ReadLine(), out num1);


            Console.WriteLine();
            Console.Write("Informe o 2o valor:");
            double.TryParse(Console.ReadLine(), out num2);

            switch(operacao)
            {
                case '+':
                    resultado = Adicao(num1, num2);
                    break;

                case '-':
                    resultado = Subtracao(num1, num2);
                    break;

                case '*':
                    resultado = Multiplicacao(num1, num2);
                    break;

                case '/':
                    resultado = Divisao(num1, num2);
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(resultado);
        }

        private static Double Adicao(double num1, double num2)
        {
            return num1 + num2;
        }

        private static Double Subtracao(double num1, double num2)
        {
            return num1 - num2;
        }

        private static Double Multiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }

        private static Double Divisao(double num1, double num2)
        {
            return num1 / num2;
        }



    }
}
