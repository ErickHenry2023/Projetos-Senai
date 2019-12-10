using System;

namespace RoleTopMvc.Models
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public string CPF {get; set;}
        public string Telefone {get; set;}

        public uint TipoUsuario {get; set;}
        
        
        public Cliente()
        {

        }

        public Cliente(string nome, string email, string senha, string cpf, string telefone)
        {
            this.Nome = nome;    
            this.Email = email;
            this.Senha = senha;
            this.CPF = cpf;
            this.Telefone = telefone;
        }
    }
}