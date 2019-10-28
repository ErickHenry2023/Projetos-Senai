using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            System.Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());

            if (n %3 ==0)  
            {
                System.Console.WriteLine("É multiplo de 3");
            } else
                System.Console.WriteLine("Não é multiplo de 3");



        }
    }
}
