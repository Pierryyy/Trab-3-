using System;

namespace Trabalho_3
{
    public class exerc2
    {
        public static void Produto(){
            System.Console.WriteLine("Exercício 2: Escreva um algoritmo que receba 4 valores. Calcule o produto dos dois primeiros e some com o produto dos dois últimos. Mostre na tela");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("Informe o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            System.Console.Write("\nInforme o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            System.Console.Write("\nAgora, informe o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            System.Console.Write("\nInforme o quarto valor: ");
            int valor4 = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            int produto1 = valor1 * valor2;
            int produto2 = valor3 * valor4;
            int produtofinal = produto1 + produto2;

            System.Console.WriteLine("\nO resultado da soma do primeiro produto (valor1 x valor2) com o segundo produto (valor3 x valor4) é: " + produtofinal);
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}