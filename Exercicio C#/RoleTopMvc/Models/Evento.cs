using System;
using System.Collections.Generic;
using RoleTopMvc.Models;

namespace RoleTopMvc.Models
{
    public class Evento
    {
        public ulong Id {get; set;}

        public Cliente Cliente {get;set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Telefone {get; set;}
        public DateTime Data {get; set;}
        public string TipoEvento {get; set;}

        public List<Servico> Servicos {get; set;}
    }
}