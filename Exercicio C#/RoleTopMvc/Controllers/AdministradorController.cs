using System;
using RoleTopMvc.ViewModels;

namespace RoleTopMvc.Controllers
{
    public class AdministradorController
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

        private IActionResult View(string v, RespostaViewModels respostaViewModels)
        {
            throw new NotImplementedException();
        }
    }
}