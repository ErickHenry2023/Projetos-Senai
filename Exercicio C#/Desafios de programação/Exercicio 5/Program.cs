using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        int a = 0;
        int b = 0;
        
        System.Console.WriteLine("digite o primeiro numero: ");
        a = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o segundo valor: ");
        b = int.Parse(Console.ReadLine());

        int aa = a;
        int bb = b;
        
        System.Console.WriteLine("");
        System.Console.WriteLine($"O primeiro numero virou: {bb}");
        System.Console.WriteLine($"O primeiro segundo virou: {aa}");

        }
    }
}
