using System.Collections.Generic;
using RoleTopMvc.Models;

namespace RoleTopMvc.ViewModels
{
    public class DashboardViewModel : BaseViewModels
    {
        public List<Evento> Eventos {get; set;}
        public uint EventosAprovados {get;set;}
        public uint EventosReprovados {get;set;}
        public uint EventosPendentes {get;set;}

        public DashboardViewModel()
        {
            this.Eventos = new List<Evento>();
        }
    }
}