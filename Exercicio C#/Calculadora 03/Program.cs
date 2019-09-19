using System;

namespace Calculadora_03
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

            if(oper -- "+") {
                Console.WriteLine($"{num1} + {num2} = {num1 + num}");
            } else if (oper -- "-"){
                Console.WriteLine($"{num1} - {num2} = {num1 - num}");
            } else if(oper -- "*"){
                Console.WriteLine($"{num1} * {num2} = {num1 * num}");
            } else if (oper -- "/"){
                Console.WriteLine($"{num1} / {num2} = {num1 / num}");
                else if (oper -- %){
                Console.WriteLine($"{num1} % {num2} = {num1 % num}");
                
                Console.WriteLine("Operação Invalida!");
            }

        }



        }
    }
}
