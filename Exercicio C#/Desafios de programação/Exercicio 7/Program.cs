using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i <10; i= i+2)         /* O (int i="1") é de onde vai comecar, (i <"10") é ate onde ele vai, (i+"2") ele vai saltando*/      
            {
                System.Console.WriteLine(i);
            }

        }
    }
}
