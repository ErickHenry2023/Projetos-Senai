using System;
using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Models
{
    public class Pedido                                 /*Metamorfose= se le E um */
                                                        /*Com a classe se le TEM UM */
    {
        public ulong Id {get;set;}          /*28/11 dashorod */
        public Cliente Cliente {get;set;}

        public DateTime DateDoPedido {get; set;}

        public Hamburguer Hamburguer {get; set;}

        public Shake Shake {get; set;}

        public double PrecoTotal {get; set;}

        public uint Status {get; set;}
        public Pedido()
        {
            this.Cliente = new Cliente();
            this.Hamburguer = new Hamburguer();
            this.Shake = new Shake();
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;    // Pendente
        }
    }
}