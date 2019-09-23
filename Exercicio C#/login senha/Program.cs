using System;

namespace login_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string admLogin = "admin";
            string admPasswd = "admin";

            Console.Write("Entrar com o usuario: ");
            string login = Console.ReadLine();
            Console.Write("Entrar com a senha: ");
            string passwd = Console.ReadLine();

            if (( login == admLogin) && passwd == admPasswd){
                Console.WriteLine("Bem vindo Admim.");
            } else{
                Console.WriteLine("Olá usuario.");
            }

        }
    }
}
