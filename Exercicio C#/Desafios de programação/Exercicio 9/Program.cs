using System;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso = 0;

            System.Console.Write("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("");
            
            System.Console.WriteLine("Escolha um planeta para saber qual seria o seu peso lá: ");
            System.Console.WriteLine("1 - Mercúrio");
            System.Console.WriteLine("2 - Vênus");
            System.Console.WriteLine("3 - Marte");
            System.Console.WriteLine("4 - Júpiter");
            System.Console.WriteLine("5 - Saturno");
            System.Console.WriteLine("6 - Urano");
            string opcao = Console.ReadLine();      /*declarar o variavel */
            
            switch(opcao){
                case "1":
                    double Pmercurio = (peso * 0.37);
                    System.Console.Write("O seu peso no planeta Mercúrio seria de: " + Pmercurio);
                break;

                case "2":
                    double Pvenus = (peso * 0.88);
                    System.Console.Write("O seu peso no planeta Vênus seria de: " + Pvenus);
                break;

                case "3":
                    double Pmarte = (peso * 0.38);
                    System.Console.Write("O seu peso no planeta Marte seria de: " + Pmarte);
                break;

                case "4":
                    double Pjupiter = (peso * 2.64);
                    System.Console.Write("O seu peso no planeta Júpiter seria de: " + Pjupiter);
                break;

                case "5":
                    double Psaturno = (peso * 1.15);
                    System.Console.Write("O seu peso no planeta Saturno seria de: " + Psaturno);
                break;

                case "6":
                    double Purano = (peso * 1.17);
                    System.Console.Write("O seu peso no planeta Urano seria de: " + Purano);
                break;

                default:
                    Console.WriteLine("Opção inválida");
                        break;
            }




        }
    }
}
