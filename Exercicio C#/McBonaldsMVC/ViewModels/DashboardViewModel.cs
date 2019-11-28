using System.Collections.Generic;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel        /*28/11 Dashboard */
    {
        public List<Pedido> Pedidos {get; set;}
        public uint PedidosAprovados {get;set;}
        public uint PedidosReprovados {get;set;}
        public uint PedidosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Pedidos = new List<Pedido>();
        }
        
    }
}