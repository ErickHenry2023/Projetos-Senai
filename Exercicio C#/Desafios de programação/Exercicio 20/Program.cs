using System;

namespace Exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int [] vetor = new int [10];
            Random Random  = new Random();
            for(int i = 0;i<vetor.Length;i++) vetor[i] = Random.Next(1000);
            for(int i = 0; i<vetor.Length;i++) if (vetor[i]%2==0) System.Console.WriteLine($"{vetor[i]} Par");
            System.Console.WriteLine();
            for(int i = 0; i<vetor.Length;i++) if (vetor[i]%2==1) System.Console.WriteLine($"{vetor[i]} impar");


            // System.Console.WriteLine(aleatorio.Next(1000));

        }
    }
}
