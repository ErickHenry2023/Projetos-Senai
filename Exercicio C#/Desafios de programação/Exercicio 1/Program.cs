using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas = 0;
            double alt = 0;

            System.Console.WriteLine("Digite um valor para a BASE");
            bas = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite um valor para a ALTURA");
            alt = double.Parse(Console.ReadLine());

            System.Console.WriteLine(""); /*Console.WriteLine("") p/ criar linha em branco */

            double Base = bas * alt;
            System.Console.WriteLine("A base do retângulo é de: " + Base);


            double Perimetro = (bas*2) * (alt*2);
            System.Console.WriteLine("O perimetro do retangulo é de: " + Perimetro);

            double Valoresbh = (bas*bas) + (alt*alt);

            double Diagonal = Math.Sqrt(Valoresbh);
            System.Console.WriteLine("A diagonal do retangulo é de: " + Diagonal);

        }
    }
}
