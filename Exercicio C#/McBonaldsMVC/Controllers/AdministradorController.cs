using McBonaldsMVC.Enums;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers              /*28/11 p/ dashborad */
{
    public class AdministradorController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        public IActionResult Dashboard(){

            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && 
            (uint) TipoUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())){

            

            

            var pedidos = pedidoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            foreach(var pedido in pedidos)
            {
                switch(pedido.Status)
                {
                    case (uint) StatusPedido.APROVADO:
                        dashboardViewModel.PedidosAprovados++;
                    break;
                        
                    case (uint) StatusPedido.REPROVADO:
                        dashboardViewModel.PedidosReprovados++;
                    break;
                    default:
                        dashboardViewModel.PedidosPendentes++;      
                        dashboardViewModel.Pedidos.Add(pedido);
                    break;

                }
            }

            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();


            return View(dashboardViewModel);
            }
            else
            {
                return View ("Erro", new RespostaViewModels(){
                    NomeView = "Dashboard",
                    Mensagem = "Voce nao tem permissao para acessar o Dashboard"
                });
            }
        }
    }
}