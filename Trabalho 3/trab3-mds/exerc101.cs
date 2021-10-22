using System;

namespace Trabalho_3
{
    public class exerc101
    {
        public static void Maior2(){
            System.Console.WriteLine("Exercício 10.1: Escreva um algoritmo que receba 2 valores. Verifique:\n Qual o maior valor;\n Ou se são iguais");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("Informe o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            System.Console.Write("\nInforme o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            if (valor1 > valor2){
                //Valor1 é maior
                System.Console.WriteLine("O valor1 é o Maior!");
            }
            
            else if (valor1 < valor2){
                //Valor2 é maior
                System.Console.WriteLine("O valor2 é o Maior!");
            }
            
            else{
                //Valores são iguais
                System.Console.WriteLine("Os valores são Iguais!");
            }
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}