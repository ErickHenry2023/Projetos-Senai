using System;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        
        System.Console.WriteLine("Digite o 1º valor triângulo: ");
        num1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o 2º valor triângulo: ");
        num2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite o 3º valor triângulo: ");
        num3 = int.Parse(Console.ReadLine());

        if(num1==num2| num1==num3| num2==num3)
        {
            System.Console.WriteLine("O triangulo e equilatero");
        } 
        else if (num1!=num2| num2==num3| num3!=num1)
        {
            System.Console.WriteLine("O triangulo e isoceles");
        } 
        else if (num1!=num2| num2!=num3| num3!=num1)
        {
            System.Console.WriteLine("O triangulo e escaleno");
        }
        else if (num1!=num2 && num2!= num3 && num2 !=num3)
        {
            System.Console.WriteLine("E um triangulo qualquer");
        }
                
        }
    }
}
