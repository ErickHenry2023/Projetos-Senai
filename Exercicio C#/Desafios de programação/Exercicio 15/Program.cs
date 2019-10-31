using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = 0;

            System.Console.WriteLine("Escreva um valor entre 1 a 12"); 
            //  n = int.Parse(Console.ReadLine());
            string opcao = Console.ReadLine();

            switch(opcao){
                case "1":
                System.Console.WriteLine($" O numero 1 é o mes Janeiro: ");
                break;

                case "2":
                System.Console.WriteLine($" O numero 2 é o mes Fevereiro: ");
                break;

                case "3":
                System.Console.WriteLine($" O numero 3 é o mes Março: ");
                break;

                case "4":
                System.Console.WriteLine($" O numero 4 é o mes Abril: ");
                break;

                case "5":
                System.Console.WriteLine($" O numero 5 é o mes Maio: ");
                break;

                case "6":
                System.Console.WriteLine($" O numero 6 é o mes Junho: ");
                break;

                case "7":
                System.Console.WriteLine($" O numero 7 é o mes Julho: ");
                break;

                case "8":
                System.Console.WriteLine($" O numero 8 é o mes Agosto: ");
                break;

                case "9":
                System.Console.WriteLine($" O numero 9 é o mes Setembro: ");
                break;

                case "10":
                System.Console.WriteLine($" O numero 10 é o mes Outubro: ");
                break;

                case "11":
                System.Console.WriteLine($" O numero 11 é o mes Novembro: ");
                break;

                case "12":
                System.Console.WriteLine($" O numero 12 é o mes Dezembro: ");
                break;

                default:
                    Console.WriteLine("Opção inválida");
                        break;

            }
            


        }
    }
}
