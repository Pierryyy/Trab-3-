using System;

namespace Trabalho_3
{
    public class exerc103
    {
        public static void MaiorMenor3(){
            System.Console.WriteLine("Exercício 10.3: Escreva um algoritmo que receba 3 valores. Verifique:\n Qual o maior valor;\n Qual o menor valor;\n Ou se são iguais.");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("\nInforme o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            
            System.Console.Write("Informe o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            System.Console.Write("Informe o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            if (valor1 > valor2 && valor1 > valor3){
                //Valor1 é o Maior
                System.Console.WriteLine("\n-- O primeiro valor (" + valor1 + ") é o Maior");

                if (valor2 > valor3){
                    //Valor 3 é o Menor
                    System.Console.WriteLine("E o terceiro valor (" + valor3 + ") é o Menor.");
                } else{
                    //Valor 2 é o Menor
                    System.Console.WriteLine("E o segundo valor (" + valor2 + ") é o Menor.");
                }
            }

            else if (valor2 > valor1 && valor2 > valor3){
                //Valor2 é o Maior
                System.Console.WriteLine("\n-- O segundo valor (" + valor2 + ") é o Maior!");

                if (valor1 > valor3){
                    //Valor 3 é o Menor
                    System.Console.WriteLine("E o terceiro valor (" + valor3 + ") é o Menor.");
                } else{
                    //Valor 1 é o Menor
                    System.Console.WriteLine("E o primeiro valor (" + valor1 + ") é o Menor.");
                }
            }

            else if (valor3 > valor1 && valor3 > valor2){
                //Valor3 é o Maior
                System.Console.WriteLine("\n-- O terceiro valor (" + valor3 + ") é o Maior!");

                if (valor2 > valor1){
                    //Valor 1 é o Menor
                    System.Console.WriteLine("E o primeiro valor (" + valor1 + ") é o Menor.");
                } else{
                    //Valor 2 é o Menor
                    System.Console.WriteLine("E o segundo valor (" + valor2 + ") é o Menor.");
                }
            }

            else if (valor1 == valor2 && valor1 == valor3){
                //Os valores são todos iguais
                System.Console.WriteLine("Todos os valores são iguais!");
            }
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}