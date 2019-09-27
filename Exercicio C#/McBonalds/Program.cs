using System;

namespace McBonalds
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Jose", "55 55 5555-5555", "jose@email.com");

            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Telefone: " + cliente1.Telefone);
            Console.WriteLine("Email: " + cliente1.Email);

        }
    }
}
