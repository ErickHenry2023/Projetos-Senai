using System;

namespace Aumento
{
    class Program
    {
        static void Main(string[] args)
        {
        
            double sal = 0;
            Console.WriteLine("Digite o salario");
            sal = double.Parse(Console.ReadLine());
           
            
            if(sal <= 500.0){
                Console.WriteLine(sal= sal *1.3);
                Console.WriteLine("Aumento de salario: " + sal);
            } else {
                Console.WriteLine("Não há aumento");
            }
        }
    }
}