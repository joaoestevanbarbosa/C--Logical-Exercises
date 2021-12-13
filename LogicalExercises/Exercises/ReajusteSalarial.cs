using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{

    //7 – Desenvolva um algoritmo que calcule o reajuste salarial.
    //Se o salário for abaixo de 1.700 o ajuste é de R$300.00, se maior de R$ 200.00.
    //Para finalizar, exiba o novo salário na tela.
    class ReajusteSalarial
    {
        public static void Execute()
        {
            double salario;
            double.TryParse(Console.ReadLine(), out salario);
            Console.WriteLine(Salario(salario));
        }

        private static double Salario(double salario)
        {
            double novoSalario = 0;
            if(novoSalario >= 1700)
            {
                novoSalario = (salario + 200);
            }
            else
            {
                novoSalario = (salario + 300);
            }
            
            return novoSalario;
        }
    }
}
