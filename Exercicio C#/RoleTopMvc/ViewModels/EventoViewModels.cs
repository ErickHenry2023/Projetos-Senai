using System.Collections.Generic;
using RoleTopMvc.Models;

namespace RoleTopMvc.ViewModels
{
    public class EventoViewModels : BaseViewModels
    {
        public List<Servico> Servicos {get; set;}
        public Cliente Cliente {get;set;}
        public string NomeCliente {get; set;}

        public EventoViewModels()                        
        {
            this.Servicos = new List<Servico>();
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}