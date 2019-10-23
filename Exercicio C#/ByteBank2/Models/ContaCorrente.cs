using System;

namespace ByteBank2.Moldels
{
    public class ContaCorrente : ContaBancaria          /* abstrato herdar o metodo saque */
    {
        public ContaCorrente(int Agencia, int NumeroConta, string Titular) : base(Agencia, NumeroConta,Titular)
        {

        }

        public override bool Saque(double Valor)        /*override pesq */
        {
            if(Valor >= 0)
            {
                if(Valor <= this.Saldo)
                {
                    this.Saldo -= Valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}