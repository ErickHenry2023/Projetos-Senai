using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Entre com a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a primeira nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a primeira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Entre com a primeira nota: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4; 

            Console.WriteLine("Sua média é " + media);

            if(media > 7.0){
                Console.WriteLine("Parabéns você passou!");
            } else {
                Console.WriteLine("Você reprovou");
            }
        }
    }
}

