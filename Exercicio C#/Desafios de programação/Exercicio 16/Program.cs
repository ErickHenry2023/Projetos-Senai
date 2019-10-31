using System;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso = 0;
            double alt =0;

            System.Console.WriteLine("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a sua altura: ");
            alt = double.Parse(Console.ReadLine());
            
            double imc = peso/ Math.Pow(alt,2);         /* "Math.Pow(alt,2)" é para elevar um numero por 2  */
            System.Console.WriteLine($"O seu IMC é: {Math.Round(imc, 2).ToString()}");         /*arredondar números decimais "{Math.Round(litros, "2").ToString()}"*/

            if(abaixo de < 20){
                System.Console.WriteLine($" O seu pesp é abaixo do peso {<imc} ");
            } else if
            {
                
            }

        }
    }
}
