using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
           
           string opcao = "";

            Console.Write("Calcula Area");
            Console.Write("1 - Triangulo");
            Console.Write("2 - Quadrado");
            Console.Write("3 - Losango");
            Console.Write("4 - Trapezio");
            Console.Write("5 - Retangulo");
            Console.Write("6 - Circulo");
            Console.Write("Escolha uma opção: ");
             opcao = Console.ReadLine();

            switch(opcao){
                case "1":
                    Console.WriteLine("Area do Triangulo");
                    Console.Write("Entre com a Altura: ");
                    double baseTri = double.Parse(Console.ReadLine());
                    Console.Write("Entrar com a Altura: ");
                    double altTri = double.Parse(Console.ReadLine());
                    double areaTri = (baseTri * altTri) / 2;
                    Console.WriteLine("A area do triangulo é: " + areaTri);
                break;
                
                case "2":
                    Console.WriteLine("Area do Quadrado");
                    Console.Write("Qual o lado do Quadrado? ");
                    double ladoQuad = double.Parse(Console.ReadLine());
                    double areaQuad = ladoQuad * ladoQuad;
                    Console.WriteLine("A area do triangulo é: " + areaQuad);
                break;
           }                 



         }
    }
}

