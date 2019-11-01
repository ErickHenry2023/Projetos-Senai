using System;

namespace Exercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Arrays = vetor  */
            /*Coleções = lista */

            int n = 0;
            System.Console.WriteLine("Digite um tamanho do vetor");
            n = int.Parse(Console.ReadLine());

            int [] vetor = new int[n];              /* "new int[n] aqui fica a variavel"*/
            
            // vetor[0] = 20;
            // vetor[1] = 444;
            // System.Console.WriteLine($"{vetor[0]} primeiro; {vetor[1]} segundo");

            for(int i=0; i <n; i++){
                System.Console.WriteLine($"Insira um valor no indice: {i+1}°");
                vetor[i] = int.Parse(Console.ReadLine());
            }
                System.Console.WriteLine(" ");
                

            for(int i=0; i <n; i++){
                System.Console.WriteLine($"{i+1} - {vetor[i]}");        /* "{i+1} posicao do indice"   "{vetor[i]} guarda o conteudo do index=indece" */

            }

        }
    }
}
