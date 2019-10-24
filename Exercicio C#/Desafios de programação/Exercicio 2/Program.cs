using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            double cen = 0;
            

            System.Console.WriteLine("Digite um graus centígrados");
            cen = double.Parse(Console.ReadLine());
            
            double fah = cen *9;        /*A variavel "fah" guarda o valor do resultado "cen" */
            double fahr = fah / 5;
            double fahre = fahr + 32;


            System.Console.WriteLine("A seu conversão para Fahrenheit sera de: " + fahre);

        }
    }
}
