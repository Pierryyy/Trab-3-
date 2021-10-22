using System;

namespace Trabalho_3
{
    public class exerc105
    {
        public static void Crescente3(){
            System.Console.WriteLine("Exercício 10.5: Escreva um algoritmo que receba 3 valores. Mostre os valores em ordem crescente");
            Console.ReadKey();
            //---------------------------------------------------------------------------------
            //Armazenando os valores em um mesmo Array
            System.Console.Write("Informe os 3 valores (separados por espaço): ");
            string[] vet = Console.ReadLine().Split(' ');

            int valor1 = int.Parse(vet[0]);
            int valor2 = int.Parse(vet[1]);
            int valor3 = int.Parse(vet[2]);
            //---------------------------------------------------------------------------------

            if (valor1 > valor2 && valor1 > valor3){
                if (valor2 > valor3){
                    //Ordem crescente correta será: Primeiro, Segundo e Terceiro
                    System.Console.WriteLine("\nOs valores em ordem crescente são: " + valor1 + ", " + valor2 + ", " +  valor3);
                } else{
                    //Ordem crescente correta será: Primeiro, Terceiro e Segundo
                    System.Console.WriteLine("\nOs valores em ordem crescente são: " + valor1 + ", " + valor3 + ", " +  valor2);
                }
            }

            else if (valor2 > valor1 && valor2 > valor3){
                if (valor1 > valor3){
                    //Ordem crescente correta será: Segundo, Primeiro e Terceiro
                    System.Console.WriteLine("\nOs valores em ordem crescente são: " + valor2 + ", " + valor1 + ", " +  valor3);
                } else{
                    //Ordem crescente correta será: Segundo, Terceiro e Primeiro
                    System.Console.WriteLine("\nOs valores em ordem crescente são: " + valor2 + ", " + valor3 + ", " +  valor1);
                }
            }

            else if (valor3 > valor1 && valor3 > valor2){
                if (valor1 > valor2){
                    //Ordem crescente correta será: Terceiro, Primeiro e Segundo
                    System.Console.WriteLine("\nOs valores em ordem crescente são: " + valor3 + ", " + valor1 + ", " +  valor2);
                } else{
                    //Ordem crescente correta será: Terceiro, Segundo e Primeiro
                    System.Console.WriteLine("\nOs valores em ordem crescente são: " + valor3 + ", " + valor2 + ", " +  valor1);
                }
            }

            else{
                //Os valores são todos iguais
                System.Console.WriteLine("\nOs valores são todos iguais!");
            }
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}