using System;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] Num = new int[3];                 /* "[2]" quantidade das variaveis */

            
            System.Console.WriteLine("Escreva o 1° numero: ");
            int num1 =  int.Parse(Console.ReadLine());          /*Converter para Parse */
            
            System.Console.WriteLine("Escreva o 2° numero: ");
            int num2 = int.Parse(Console.ReadLine());           
            
            System.Console.WriteLine("Escreva o 3° numero: ");
            int num3 = int.Parse(Console.ReadLine());

            Num[0] = num1;                           /* "Num" pego a 1° variavel e 2° varivel  */
            Num[1] = num2;
            Num[2] = num3;

            Array.Sort(Num);                         /* "Num" a variavel que vai ser utilizado */ 
            System.Console.WriteLine("");
            foreach(int n in Num){     /* "n" nova variavel + "Num" 1° variavel*/
                
                
                System.Console.WriteLine(n);

            }
        }
    }
}