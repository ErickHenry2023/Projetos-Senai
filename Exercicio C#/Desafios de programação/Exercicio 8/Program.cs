using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            // int alt= 0;

            System.Console.Write("Digite a Altura do Triangulo: ");
            int alt = int.Parse(Console.ReadLine());
            
            for(int i=0; i<alt; i++)            /*(i<"alt") é a valiavel */
            {
                for(int a=alt; a>i; a--)        /*O FOR comeca a ler do primeiro FOR que ha dentro dele.*/
                {
                    System.Console.Write(" * ");
                }
                System.Console.WriteLine();
            }

            
        }
    }
}
