using System;
using System.Collections.Generic;
using RoleTopMvc.Enums;
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
        public double PrecoTotal {get; set;}
        public uint Status {get; set;}

        public Evento()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (uint) StatusEvento.PENDENTE;
        }
        public List<Servico> Servicos {get; set;}
    }
}