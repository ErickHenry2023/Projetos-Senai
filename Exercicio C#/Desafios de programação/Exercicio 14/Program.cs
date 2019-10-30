using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {

        System.Console.WriteLine("Escreva uma verbo: "); 
        string ver = Console.ReadLine();
        
        ver.ToLower();

        if(ver.EndsWith("ar")) 
        {
            System.Console.WriteLine("Verbo da 1ª- conjugação");

        } else if (ver.EndsWith("er"))
        {
            System.Console.WriteLine("Verbo da 2ª- conjugação");
        }else if (ver.EndsWith("ir"))
        {
            System.Console.WriteLine("Verbo da 3ª- conjugação");

        }   else{
            System.Console.WriteLine("Verbo nao esta no infinitivo");
        }

        }
    }
}
