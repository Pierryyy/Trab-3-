using System;

namespace Trabalho_3
{
    public class exerc13
    {
        public static void Cadastro(){
            System.Console.WriteLine("Exercício 13: Escreva um algoritmo que construa um menu de cadastro com as opções abaixo\n\nC) Cadastrar\nR) Buscar\nU) Alterar\nD) Excluir");
            Console.ReadKey();
            //---------------------------------------------------------------------------------

            // System.Console.WriteLine("\n------------------------------\nSELECIONE\nC) Cadastrar\nR) Buscar\nU) Alterar\nD) Excluir\n------------------------------");

            System.Console.Write("\n------------------------------\nSELECIONE (Digite 0 para sair): ");
            char opcao = char.Parse(Console.ReadLine().ToUpper());
            //---------------------------------------------------------------------------------

            System.Console.WriteLine("------------------------------\n");
            switch (opcao)
            {
                case 'C':
                    System.Console.WriteLine("Você selecionou a opção de CADASTRAR (C)!");
                    break;
                
                case 'R':
                    System.Console.WriteLine("Você selecionou a opção de BUSCAR (R)!");
                    break;
                
                case 'U':
                    System.Console.WriteLine("Você selecionou a opção de ALTERAR (U)!");
                    break;
                
                case 'D':
                    System.Console.WriteLine("Você selecionou a opção de EXCLUIR (D)!");
                    break;
                
                case '0':
                    System.Console.WriteLine("\n\nCANCELANDO. . .");
                    Console.ReadKey();
                    break;
            }
            //---------------------------------------------------------------------------------
            
            System.Console.WriteLine("\n\n\nAté o próximo exercício!");
            System.Console.WriteLine("----------------------------------------");
            Console.ReadKey();            
        }
    }
}