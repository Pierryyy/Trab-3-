//Inconclusivo
using System;

namespace Trabalho_3
{
    public class exerc11
    {
        public static void PesoIdeal(){
            System.Console.WriteLine("Exercício 11: Tendo como entrada a altura e o sexo (F: Feminino ou M: Masculino) de uma pessoa, escreva um algoritmo que calcule e imprima seu peso ideal, utilizando as seguintes fórmulas:\n - Mulheres: (62.1 * altura) - 44.7;\n - Homens: (72.7 * altura) - 58");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("\nInforme a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            System.Console.Write("Informe o sexo (F = Feminino e M = Masculino): ");
            char sexo = char.Parse(Console.ReadLine().ToUpper());
            //---------------------------------------------------------------------------------

            switch (sexo)
            {
                case 'F':
                    // System.Console.WriteLine("Feminino");
                    // double form1 = 62.1;
                    // double form2 = 44.7;
                    double pesoidealF = (double)62.1 * altura - (double)44.7;
                    pesoidealF = Math.Round(pesoidealF, 2);

                    System.Console.WriteLine("\nO seu peso ideal é: " + pesoidealF + "Kg.");

                    break;
                
                case 'M':
                    // System.Console.WriteLine("Masculino");
                    double pesoidealM = (double)72.7 * altura - (double)58;
                    pesoidealM = Math.Round(pesoidealM, 2);

                    System.Console.WriteLine("\nO seu peso ideal é: " + pesoidealM + "Kg.");
                    break;
            }
            //---------------------------------------------------------------------------------
            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}