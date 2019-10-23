using System;
using ByteBank2.Moldels;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaCorrente1 = new ContaCorrente(1, 1, "EIK");
            ContaCorrente contaCorrente2 = new ContaCorrente(1, 1, "HENRY");

            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);


            ContaEspecial contaEspecial1 = new ContaEspecial(1, 2, "HENRY");
            DepositarConta(contaEspecial1);
            SacarConta(contaEspecial1);

            /*Parei Aqui */

        }
    }
}
