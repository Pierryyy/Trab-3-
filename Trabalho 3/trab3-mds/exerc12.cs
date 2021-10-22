using System;

namespace Trabalho_3
{
    public class exerc12
    {
        public static void Triangulo(){
            System.Console.WriteLine("\nExercício 12: Escreva um algoritmo que leia 3 valores representando os 3 lados de um triângulo. Mostre o tipo do triângulo\n\n- Equilátero: 3 lados iguais\n- Isóceles: 2 lados iguais\n- Escaleno: 3 lados diferentes");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("\n\nInforme o primeiro lado: ");
            int lado1 = int.Parse(Console.ReadLine());

            System.Console.Write("Informe o segundo lado: ");
            int lado2 = int.Parse(Console.ReadLine());
            
            System.Console.Write("Informe o terceiro lado: ");
            int lado3 = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3){
                //Todos os lados são iguais
                System.Console.WriteLine("\n\nO triângulo é: EQUILÁTERO!");
            } else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3){
                //A penas dois lados são iguais
                System.Console.WriteLine("\n\nO triângulo é: ISÓSCELES!");
            } else{
                //Nenhum lado é igual
                System.Console.WriteLine("\n\nO triângulo é ESCALENO!");
            }
            //---------------------------------------------------------------------------------
            
            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}