using System;
using System.Collections.Generic;
using RoleTopMvc.Models;
using RoleTopMvc.Enums;

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
        public string TipoEvento {get; set;}  /*alterar aqui p/ que funcione el agendamentorepository */

        public double PrecoTotal {get; set;}
        public uint Status {get; set;}

        public List<Servico> Servicos {get; set;}

        public Evento()
        {
            this.Cliente = new Cliente();
            // this.TipoEvento = new TipoEvento();
            this.Id = 0;
            this.Status = (uint) StatusEvento.PENDENTE;

        }

    }
}