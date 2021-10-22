using System;

namespace Trabalho_3
{
    public class exerc14
    {
        public static void Entrada(){
            System.Console.WriteLine("\nExercício 14: Escreva um algoritmo que determine o preço com desconto para entradas de cinema. Mostre a categoria, o desconto e o valor final. Desconto não cumulativo.\n  - Ingresso R$ 25,00.\n  - Estudantes recebem 50% de desconto.\n  - Aposentados recebem 30% de desconto.\n  - Demais clientes pagam o ingresso completo.\n  - Nas quartas, todos recebem 50% de desconto.");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            double ingresso = 50.00;

            System.Console.Write("\nQual o dia em questão? (escreva o nome do dia) ");
            string dia = Console.ReadLine().ToUpper();

            //---------------------------------------------------------------------------------

            System.Console.WriteLine("----------------------------------------");
            switch (dia){
                case "QUARTA":
                    //Caso seja quarta-feira

                    double ingressoDesc = ingresso / 2;
                    System.Console.WriteLine("Seu ingresso ficará: R$" + ingressoDesc);
                    break;
                
                default:
                    //Caso não seja quarta-feira

                    System.Console.Write("Você é Estudante (digite E) ou Aposentado (digite A)?\nCaso não se encaixe em nenhuma opção, digite S: ");
                    char cliente = char.Parse(Console.ReadLine().ToUpper());
                    System.Console.WriteLine("\n");

                    switch (cliente){
                        case 'E':
                            ingressoDesc = ingresso / 2;

                            System.Console.WriteLine("Seu ingresso de Estudante com desconto de 50% ficou: R$" + ingressoDesc);
                            break;
                        
                        case 'A':
                            ingressoDesc = ingresso * 0.7;

                            System.Console.WriteLine("Seu ingresso de Aposentado com desconto de 30% ficou: R$" + ingressoDesc);
                            break;
                        
                        case 'S':
                            System.Console.WriteLine("Seu ingresso terá o valor padrão de: R$" + ingresso);
                            break;
                    }
                    System.Console.WriteLine("----------------------------------------\n");
                    break;
            }
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}