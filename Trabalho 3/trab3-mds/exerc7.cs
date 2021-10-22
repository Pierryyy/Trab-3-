using System;

namespace Trabalho_3
{
    public class exerc7
    {
        public static void Faturamento(){
            System.Console.WriteLine("\nExercício 7: Uma sorveteria vende três tipos de picolés: os de Frutas custam R$2,50, os Cremosos custam R$ 3,50 e o com Recheados custam R$4,50.\nEscreva um algoritmo que receba a quantidade de picolés vendida de cada tipo e mostre quanto a sorveteria faturou por cada tipo de picolé e no total de vendas");
            Console. ReadKey();
            //---------------------------------------------------------------------------------

            double valorF = 2.50;
            double valorC = 3.50;
            double valorR = 4.50;

            System.Console.Write("\nINFORME QUANTOS PICOLÉS DE FRUTAS VAI QUERER: ");
            int quantF = int.Parse(Console.ReadLine());

            System.Console.Write("INFORME QUANTOS PICOLÉS CREMOSOS VAI QUERER: ");
            int quantC = int.Parse(Console.ReadLine());

            System.Console.Write("INFORME QUANTOS PICOLÉS RECHEADOS VAI QUERER: ");
            int quantR = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            double fatF = valorF * quantF;
            double fatC = valorC * quantC;
            double fatR = valorR * quantR;
            double fatT = fatF + fatC + fatR;
            
            System.Console.WriteLine("\n-------------------------------------");
            System.Console.WriteLine("Houve um faturamento de:");
            System.Console.WriteLine("R$" + fatF + " em vendas de picolés de Frutas;");
            System.Console.WriteLine("R$" + fatC + " em vendas de picolés Cremosos;");
            System.Console.WriteLine("R$" + fatR + " em vendas de picolés Recheados;");

            System.Console.WriteLine("\nE um faturamento Total de R$" + fatT);
            System.Console.WriteLine("------------------------------------");
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}