using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        double temp = 0;
        double km = 0;

        System.Console.Write("Digite o tempo da viagem: ");
        temp = double.Parse(Console.ReadLine());
        
        System.Console.Write("Digite a velocida em km/h: ");
        km = double.Parse(Console.ReadLine());
        
        double litros = temp*km/12; 

        System.Console.WriteLine($"litros de combustível gastos em uma viagem: {Math.Round(litros, 2).ToString()}");  /*arredondar números decimais "{Math.Round(litros, "2").ToString()}"*/

        }
    }
}
