using System;
// using Cliente; 

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("ByteBank - Cadastro de Cliente");

            System.Console.WriteLine("NOME:");         //aparece na tela (Adm)
            string nome = Console.ReadLine();           // escreve na tela (Usuario)
            
            System.Console.WriteLine("CPF:");
            string cpf = Console.ReadLine();
            
            System.Console.WriteLine("EMAIL:");
            string email = Console.ReadLine();
            
            Cliente cliente1 = new Cliente(nome,cpf,email);

            bool trocouSenha = false;
            do{
                System.Console.WriteLine("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocaSenha(senha);
                if (trocouSenha){
                    System.Console.WriteLine("Senha alterada com sucesso!");
                } else {
                    System.Console.WriteLine("Senha Invalidade");
                }
            }while(!trocouSenha);
            
            

        }
    }
}
