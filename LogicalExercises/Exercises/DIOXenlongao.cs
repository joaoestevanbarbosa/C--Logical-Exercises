using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalExercises.Exercises
{
    class DIOXenlongao
    {
        //Kogu está buscando as esferas do dragão para invocar Xenlongão e pedir para ele reviver seu amigo Kuriri,
        //que infelizmente morreu de novo na última batalha dos guerreiros Zê.

        //Porém Kogu está tendo muita dificuldade para encontrar as esferas, por isso Xenlongão que é seu conhecido há muito
        //tempo, decidiu abrir uma exceção e aceitou ser invocado caso Kogu encontre todas as esferas cujo o número de
        //divisores da quantidade de estrelas da esfera sejam par.

        //Por exemplo se existem sete esferas, Kogu não precisaria encontrar as esferas de uma e quatro estrelas,
        //pois elas tem uma quantidade ímpar de divisores, então ele só precisa pegar 5 esferas para invocar Xenlongão.

        //Como Kogu não é muito bom em contas, ele pediu para você escrever um programa que dado o total de esferas existentes,
        //mostre a quantidade mínima de esferas que ele precisa procurar.

        //Entrada
        //A primeira linha consiste de um inteiro C que representa a quantidade de casos de teste.As linhas subsequentes
        //contém um inteiro N(2 ≤ N ≤ 109) que representa a quantidade de esferas necessárias para invocar Xenlongão.

        //Saída
        //Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar.

        //Exemplo de Entrada 
        //1
        //7

        //Exemplo de Saída
        //5


        public static void Execute()
        {
            Console.Write("Quantidade de testes: ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N-- > 0)
            {
                Console.Write("Quantidade de esferas: ");
                int c = Convert.ToInt32(Console.ReadLine()); 
                int r = (int)Math.Sqrt(c);
                int s = c - r;
                Console.WriteLine("Você precisa de " + s + " esferas para invocar o Xenlongao");

               
                // Podemos achar a quantidade de divisores de um número
                // Com a decomposição em fatores primos;

                // Podemos encontrar a quantidade de divisores pares
                // com uma técnica de soma e multiplicação dos expoentes dos
                // Fatores.

                // Um número é par quando todos os expoentes são ímpares.

                // Então esse número precisa ser um quadrado perfeito Para
                // Que o número de divisores seja par.

                // No final das contas, devemos excluir todos os números
                // Que são quadrados perfeitos. A quantidade de números que são
                // Quadrados pefeitos em um intervalo [1...N] é exatamente
                // a raiz quadrada de N;
            }

        }
    }
    
}
