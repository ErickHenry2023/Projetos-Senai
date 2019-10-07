using System;
// using Cliente; 

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cadastro de Cliente.    
            System.Console.WriteLine("ByteBank - Cadastro de Cliente");

            System.Console.WriteLine("NOME: ");         //aparece na tela (Adm)
            string nome = Console.ReadLine();           // escreve na tela (Usuario)
            
            System.Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            
            System.Console.WriteLine("EMAIL: ");
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
            System.Console.WriteLine();
            #endregion      //#region #endregion p/ esconder um bloco de codigo//


            #region
            System.Console.WriteLine("ByteBank - Cadastro da Conta");
            System.Console.WriteLine("Entre com a Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com a conta: ");
            int conta = int.Parse(Console.ReadLine());
            // string titular = Console.ReadLine();
            
            ContaCorrente contaCorrente1 = new ContaCorrente(agencia,conta,cliente1);
            double saldo;
            do{
                System.Console.WriteLine("Entre com o saldo: ");
                saldo = double.Parse(Console.ReadLine());
                if (saldo > 0) {
                    contaCorrente.Saldo = saldo;
                } else {
                    System.Console.WriteLine("Valor do saldo deve ser positivo.");
                }
            } while(saldo < 0);
            System.Console.WriteLine();
            #endregion
            
            Cliente cliente2 = new Cliente("Jefferson", "123.456.789-00", "1@gmail.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123,123,cliente2);

            #region  Depósito.
            System.Console.WriteLine("ByteBank - Depósito em Conta");
            System.Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente.Numero}");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.Deposito(Valor);
            System.Console.WriteLine();
            System.Console.WriteLine($"Novo saldo: {contaCorrente1.Saldo}");
            System.Console.WriteLine();
            #endregion
        }
    }
}
