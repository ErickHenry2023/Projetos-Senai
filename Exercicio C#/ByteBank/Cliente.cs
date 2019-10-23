using System;

namespace ByteBank
{
    public class Cliente
{

    private string _Cpf {get; set;}
    private string _Nome {get; set;}
    private string _Email {get; set;}
    private  string _Senha {get; set;}


    public string Cpf
    {
    get {return _Cpf;}
    set {_Cpf = value;}
    }    

    public string Nome
    {
    get {return _Nome;}
    set {_Nome = value;}
    }

    public string Email
    {
    get {return _Cpf;}
    set {_Email = value;}
    } 

    public string Senha
    {
    get {return _Senha;}
    // set {_Senha = value;}
    } 

    //mesmos nome da classe (1)- não tem retorno (2) regras 1,2 p/ criar (o construtor  iniciar as informaçoes //

    // Construtor  INICIO///
    public Cliente(string Nome, double v, string Cpf, string Email){
        this._Nome = Nome;
        this._Cpf = Cpf;
        this._Email = Email;
    }

        public Cliente(string nome, string cpf, string email)
        {
            _Nome = nome;
            _Cpf = cpf;
            _Email = email;
        }

        // Construtor  FIM///


        // Metodo  bool INICIO//
        public bool TrocaSenha(string senha){
        if ((senha.Length >6) && (senha.Length < 16)){
            this._Senha = senha;
            return true;
        } else {
            return false;
        }
    // Metodo  bool FIM//
    }
}


}