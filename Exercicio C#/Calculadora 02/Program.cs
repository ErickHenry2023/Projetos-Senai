using System;

namespace Calculadora_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;
            

            Console.Write("Digite o 1° número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2° número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Qual o operador desejado? ");
            oper = Console.ReadLine();

            switch(oper){
                case "+":
                    Console.Write($"{num1} + {num2} = {num1 + num2}");
                    break;
                
                case "-":
                    Console.Write($"{num1} - {num2} = {num1 - num2}");
                    break;

                case "*":
                    Console.Write($"{num1} * {num2} = {num1 * num2}");
                    break;
                
                case "/":
                    Console.Write($"{num1} / {num2} = {num1 / num2}");
                    break;

                case "%":
                    Console.Write($"{num1} % {num2} = {num1 % num2}");
                    break;

                    default:
                        Console.WriteLine("Operação Invalida !");
                    break;

             }

        }
    }
}
