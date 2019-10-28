using System;

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nomes = new string[2];                 /* "[2]" quantidade das variaveis */

            
            System.Console.WriteLine("Escreva o 1° nome: ");
            string nome1 = Console.ReadLine();
            
            System.Console.WriteLine("Escreva o 2° nome: ");
            string nome2 = Console.ReadLine();

            Nomes[0] = nome1;                           /* "Nomes" pego a 1° variavel e 2° varivel  */
            Nomes[1] = nome2;

            Array.Sort(Nomes);                         /* "Nomes" a variavel que vai ser utilizado */ 

            foreach(string n in Nomes){     /* "n" nova variavel + "Nomes" 1° variavel*/
                System.Console.WriteLine(n);

            }

        }
    }
}
