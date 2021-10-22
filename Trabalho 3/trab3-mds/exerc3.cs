using System;

namespace Trabalho_3
{
    public class exerc3
    {
        public static void Area(){
            System.Console.WriteLine("Exercício 3: Escreva um algoritmo que calcule a área de um quadrado. Mostre na tela");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("Informe o valor do Lado do quadrado: ");
            int lado = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            int area = lado * lado;

            System.Console.WriteLine("\nA área do quadrado em questão é de: " + area + "cm.");
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}