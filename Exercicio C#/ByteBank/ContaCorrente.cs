using System;

namespace ByteBank
{
    public class ContaCorrente
{

    public string Titular {get;set;}
    public int Agencia {get; set;}
    public int Numero {get; set;}
    public double Saldo {get; set;}

    public ContaCorrente(int Agencia, int Numero, string Titular)
    {
        this.Titular = Titular;
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Saldo = 0.0;
        }
    
    // Metodos
    public double deposito(double valor)
    {
        return this.Saldo += valor;   
    }
    
    public bool saque(double valor){
        if(this.Saldo > valor){
            this.Saldo -= valor;
            return true;
        } else {
            return false;
        }
    }
    
    public bool transferencia(ContaCorrente contaDestino, double valor){           
        if(this.saque((valor))){
            contaDestino.deposito(valor);
            return true;
        } else {
            return false;
            }
        }
    }
}
