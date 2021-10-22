using System;

namespace Trabalho_3
{
    public class exerc4
    {
        public static void Desconto(){
            System.Console.WriteLine("Exercício 4: Escreva um algoritmo que calcule o desconto de 10% sobre o preço de um produto. Apresente o novo preço na tela");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("Informe aqui o preço do produto em questão (em R$): ");
            double preco = double.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------
            
            double desconto = 0.1;
            double diferenca = preco * desconto;
            double novopreco = preco - diferenca;

            System.Console.WriteLine("\nAplicando o desconto de 10%, o novo preço do produto fica: R$" + novopreco);
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}