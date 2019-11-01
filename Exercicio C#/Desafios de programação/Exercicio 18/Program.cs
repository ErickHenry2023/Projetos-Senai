using System;

namespace Exercicio18 {
    class Program {
        static void Main (string[] args) {
            int n = 0;

            System.Console.WriteLine ("Digite um numero: ");
            n = int.Parse (Console.ReadLine ());


            for (int i = 0; i < n; i++) {                       
                if (i % 2 == 1) {
                    System.Console.WriteLine ($"{i} é impar");
                }

                

            }
        }
    }
}