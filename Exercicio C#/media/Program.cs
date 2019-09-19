using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            // string oper;

            Console.WriteLine("Digite o 1º número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 3º número");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 4º número");
            num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} + {num3} + {num4} = {num1} + {num2} + {num3} + {num4/4}");

        }
    }
}
