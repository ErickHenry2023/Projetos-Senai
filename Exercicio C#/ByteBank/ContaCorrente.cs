using System;

namespace ByteBank
{
    public class ContaCorrente
{
        private int v1;
        private int v2;
        private Cliente cliente2;

        public string _Titular {get;set;}
        public int _Agencia {get; set;}
        public int _Numero {get; set;}
        public double _Saldo {get; set;}


        public double Saldo 
        {
        get {return _Saldo;}
        }


        public ContaCorrente(int Agencia, int Numero, string Titular)
        {
        this._Titular = Titular;
        this._Agencia = Agencia;
        this._Numero = Numero;
        this._Saldo = 0.0;
        }

        public ContaCorrente(int v1, int v2, Cliente cliente2)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.cliente2 = cliente2;
        }

        // Metodos
        public bool Deposito(double valor){
            if(valor >= 0)
            {
                this._Saldo += valor; 
                return true;
            }
            else
            {
                return false;
            }
    }
    
    public bool Saque(double valor){
        if(valor >= 0){

        if(this.Saldo > valor){
            this._Saldo -= valor;
            return true;
        } else {
            return false;
        }
    }
    return false;
}
    
    public bool transferencia(ContaCorrente contaDestino, double valor){           
        if(this.Saque((valor))){
            contaDestino.Deposito(valor);
            return true;
        } else {
            return false;
            }
        }
    }
}
