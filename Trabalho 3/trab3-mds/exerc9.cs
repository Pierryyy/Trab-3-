using System;

namespace Trabalho_3
{
    public class exerc9
    {
        public static void PIZ(){
            System.Console.WriteLine("Exercicio 9: Escreva um algoritmo que receba um valor.\nMostre se o valor informado é:\n Par, Ímpar ou Zero");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            System.Console.Write("Informe o valor: ");
            int v1 = int.Parse(Console.ReadLine());
            //---------------------------------------------------------------------------------

            if (v1 % 2 == 0 && v1 != 0){
                //O valor é Par
                System.Console.WriteLine("O valor é PAR!");
            }
            
            else if (v1 % 2 != 0){
                //O valor é Ímpar
                System.Console.WriteLine("O valor é ÍMPAR!");
            }
            
            else if (v1 == 0){
                //O valor é Zero
                System.Console.WriteLine("O valor é ZERO!");
            }
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}