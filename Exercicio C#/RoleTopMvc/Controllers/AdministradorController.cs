using System;
using Microsoft.AspNetCore.Mvc;
using RoleTopMvc.Enums;
using RoleTopMvc.Repositories;
using RoleTopMvc.ViewModels;

namespace RoleTopMvc.Controllers
{
    public class AdministradorController : AbstractController
    {
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository();
        public IActionResult Dashboard(){

            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());

            if (!ninguemLogado && 
            (uint) TipoUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession())){

            

            

            var agendamento = agendamentoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();

            foreach(var pedido in agendamento)
            {
                switch(pedido.Status)
                {
                    case (uint) StatusEvento.APROVADO:
                        dashboardViewModel.EventosAprovados++;
                    break;
                        
                    case (uint) StatusEvento.REPROVADO:
                        dashboardViewModel.EventosReprovados++;  /*trocar por evento/agendamento */
                    break;
                    default:
                        dashboardViewModel.EventosPendentes++;      
                        dashboardViewModel.Eventos.Add(pedido);
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