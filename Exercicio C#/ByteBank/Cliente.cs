using System;

namespace ByteBank
{
    public class Cliente
{

    public string Cpf {get; set;}
    public string Nome {get; set;}
    public string Email {get; set;}
    public  string Senha {get; set;}

    //mesmos nome da classe (1)- não tem retorno (2) regras 1,2 p/ criar (o construtor  iniciar as informaçoes //

    // Construtor  INICIO///
    public Cliente(string Nome, string Cpf, string Email){
        this.Nome = Nome;
        this.Cpf = Cpf;
        this.Email = Email;
    }
    // Construtor  FIM///


    // Metodo  bool INICIO//
    public bool TrocaSenha(string senha){
        if ((senha.Length >6) && (senha.Length < 16)){
            this.Senha = senha;
            return true;
        } else {
            return false;
        }
    // Metodo  bool FIM//
    }
}


}