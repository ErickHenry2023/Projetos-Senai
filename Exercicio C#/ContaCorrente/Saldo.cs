using System;

namespace ContaCorrente
{
    public class SaldoNaConta
{

    public string Titular {get;set;}
    public int Agencia {get; set;}
    public int Numero {get; set;}
    public double Saldo {get; set;}

    public SaldoNaConta(string Titular, int Agencia, int Numero){
        this.Titular = Titular;
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Saldo = 0;
    }












}


}