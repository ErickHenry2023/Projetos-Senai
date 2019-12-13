using System;
using System.Collections.Generic;
using RoleTopMvc.Models;
using RoleTopMvc.Enums;

namespace RoleTopMvc.Models
{
    public class Evento
    {
        public Cliente Cliente {get;set;}
        public DateTime DataRealizacao {get; set;}
        public TipoDeEvento TipoEvento {get; set;}  /*alterar aqui p/ que funcione el agendamentorepository */
        public List<Servico> Servicos {get; set;}
        public DateTime DataPedido {get; set;}
        public string Adicionais {get; set;}

        public ulong Id {get; set;}
       public double PrecoAdicionais {get; set;}
       public double PrecoTipoEvento {get; set;}
        public uint Status {get; set;}

        public Evento()
        {
            this.Cliente = new Cliente();
            // this.TipoEvento = new TipoEvento();
            this.Id = 0;
            this.Status = (uint) StatusEvento.PENDENTE;
        }

        public Evento (Cliente cliente, DateTime dataRealizacao, TipoDeEvento tipoevento, List<Servico> servicos )
        {
                this.Cliente = cliente;
                this.DataRealizacao = dataRealizacao;
                this.TipoEvento = tipoevento;
                this.Status = (uint) StatusEvento.PENDENTE;
                this.Servicos = servicos;
        } 


    }
}