using System;

namespace Par_e_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int[] vetor = new int[6];
            int par = 0;
            int imp = 0;


            for (int cont = 0; cont < 6; cont++){
                Console.WriteLine($"Digite o {cont+1} número: ");
                vetor[cont] = int.Parse(Console.ReadLine());
            }

            foreach(int num in vetor){
                if (num % 2 == 0){
                    par++;
                } else {
                    imp++;
                }
            }
        
            Console.WriteLine($"Você tem {par} números pares e {imp} números impares");

        }
    }
}
