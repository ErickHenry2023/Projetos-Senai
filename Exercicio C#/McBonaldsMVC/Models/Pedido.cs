using System;

namespace McBonaldsMVC.Models
{
    public class Pedido                                 /*Metamorfose= se le E um */
                                                        /*Com a classe se le TEM UM */
    {
        public Cliente Cliente {get;set;}

        public DateTime DateDoPedido {get; set;}

        public Hamburguer Hamburguer {get; set;}

        public Shake Shake {get; set;}

        public double PrecoTotal {get; set;}

    }
}