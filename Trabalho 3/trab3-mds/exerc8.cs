using System;

namespace Trabalho_3
{
    public class exerc8
    {
        public static void SaldoDevedor(){
            System.Console.WriteLine("\n\nExercício 8: Considerando que, para um consórcio, sabe-se o número total de prestações, a quantidade de prestações pagas e o valor da prestação (fixa), escreva um algoritmo que mostre o saldo devedor do cliente");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            double valor = 500.00;

            System.Console.Write("\nInforme a quantidade total de prestações: ");
            int prest = int.Parse(Console.ReadLine());

            System.Console.Write("Informe quantas foram pagas: ");
            int pagas = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            int prestRest = prest - pagas;
            double valorTotal = valor * prestRest;

            System.Console.WriteLine("\nRestam ainda " + prestRest + " prestações restantes, com valor total de R$" + valorTotal);
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}