using System;

namespace ByteBank2.Moldels
{

    public abstract class ContaBancaria         /*asbtract */
    {

        public string Titular;
        public int Agencia;
        public int NumeroConta;
        public double Saldo;

        public ContaBancaria(int Agencia, int NumeroConta, string Titular)
        {
            this.Agencia = Agencia;
            this.NumeroConta = NumeroConta;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }

        public abstract bool Saque(double Valor);   /*nao pode ter corpo abstract */

        public bool Deposito(double Valor)
        {
            if (Valor >= 0)
            {
                this.Saldo += Valor;
                return true;
            }
            return false;
        }

        public bool Transferencia(ContaBancaria Destino, double Valor)
        {
            if(this.Saque(Valor))
            {
                Destino.Deposito(Valor);
                return true;
            } else
            {
                return false;
            }
        }
    }

}