using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            System.Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            
            if (num %2 == 0)            /*pesq sobre el calculo "%2" */
            {
                System.Console.WriteLine("O valor é par");
            }else 
                System.Console.WriteLine("O valor é impar");
        }
    }
}
