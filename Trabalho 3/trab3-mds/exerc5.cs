using System;

namespace Trabalho_3
{
    public class exerc5
    {
        public static void Desconto2(){
            System.Console.WriteLine("Exercício 5: Escreva um algoritmo que receba um percentual de desconto e calcule esse desconto sobre o preço do produto, apresentando o valor do desconto e o novo preço do produto");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("Informe o preço atual do produto em questão (em R$): ");
            double preco = double.Parse(Console.ReadLine());

            System.Console.Write("\nAgora, informe o valor do desconto (em %): ");
            double desconto = double.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            double desconto2 = desconto / 100;
            double diferenca = preco * desconto2;
            double novopreco = preco - diferenca;

            System.Console.WriteLine(novopreco);
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}