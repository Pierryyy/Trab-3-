using System;

namespace Trabalho_3
{
    public class exerc6
    {
        public static void Inversao(){
            System.Console.WriteLine("Exercício 6: Escreva um algoritmo que receba 2 valores e inverta os valores informados; valor1 passa a ter o conteúdo de valor2 e valor2 passa a ter o conteúdo de valor1");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("Informe o valor 1: ");
            int valor1 = int.Parse(Console.ReadLine());

            System.Console.Write("\nInforme o valor 2: ");
            int valor2 = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            int aux = valor1;
            valor1 = valor2;
            valor2 = aux;

            System.Console.WriteLine("\nOs valores finais ficaram da seguinte forma \nValor 1: " + valor1 + "\nE valor 2: " + valor2);
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}