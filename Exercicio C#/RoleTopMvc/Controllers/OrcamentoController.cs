using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMvc.Enums;
using RoleTopMvc.Models;
using RoleTopMvc.Repositories;
using RoleTopMvc.ViewModels;

namespace RoleTopMvc.Controllers
{
    public class OrcamentoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository ();
        AgendamentoRepository agendamentoRepository = new AgendamentoRepository ();
        ServicoRepository servicoRepository = new ServicoRepository (); /*Preco dos servico csv */
        TipoEventoRepository tipoEventoRepository = new TipoEventoRepository ();

        public IActionResult Index () {
            EventoViewModels evm = new EventoViewModels ();
            evm.Servicos = servicoRepository.ObterTodos (); /*devolver lista */

            var emailCliente = ObterUsuarioSession();
            if (!string.IsNullOrEmpty (emailCliente)) {
                evm.Cliente = clienteRepository.ObterPor (emailCliente);

            }

            var nomeUsuario = ObterUsuarioNomeSession ();
            if (!string.IsNullOrEmpty (nomeUsuario)) {
                evm.NomeCliente = nomeUsuario;
            }
            
            evm.NomeView = "Orcamento";
            evm.UsuarioEmail = ObterUsuarioSession();
            evm.UsuarioNome = ObterUsuarioNomeSession();
            evm.UsuarioTipo = ObterUsuarioTipoSession();

            // clienteRepository.ObterPor();

            return View (evm);
        }
            /*hacer esta parte */

            public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Orcamento";


            List<Servico> servicos = new List<Servico>();               /*PAREI AQUI */

            string[] nomesServicos = form["tadicionais"].ToString().Split(",");

            foreach (string nomeServico in nomesServicos)
            {
                servicos.Add(new Servico(nomeServico, servicoRepository.ObterPrecoDe(nomeServico)));
            }

            string emailCliente = ObterUsuarioSession();

            Cliente cliente = clienteRepository.ObterPor(emailCliente);

            TipoDeEvento tipoevento = new TipoDeEvento(form["tTEvento"], tipoEventoRepository.ObterPrecoDe(form["tTEvento"]));

            System.Console.WriteLine();
            System.Console.WriteLine(form["tData"]);
            System.Console.WriteLine("********************************************");

            Evento evento = new Evento(
                cliente,
                DateTime.Parse(form["tData"]),
                tipoevento, 
                servicos);

            foreach (var servico in servicos)
            {
                evento.PrecoAdicionais += servico.Preco;
                System.Console.WriteLine();
                System.Console.WriteLine(servico.Preco);
                System.Console.WriteLine();
            }

            evento.PrecoTipoEvento = tipoEventoRepository.ObterPrecoDe(form["tTEvento"]);

            evento.DataPedido = DateTime.Now;


            if (agendamentoRepository.Inserir (evento)) {
                return View ("Sucesso", new RespostaViewModels("Sucesso") {
                    NomeView = "Mensagem",
                    UsuarioNome = ObterUsuarioNomeSession(),
                    UsuarioEmail = ObterUsuarioSession()
                });

            } else {
                return View ("Sucesso", new RespostaViewModels("Erro") {
                    NomeView = "Mensagem",
                    UsuarioNome = ObterUsuarioNomeSession(),
                    UsuarioEmail = ObterUsuarioSession()
                });
        }
    }

        public IActionResult Aprovar (ulong id)
        {
            var pedido = agendamentoRepository.ObterPor(id);

            pedido.Status = (uint) StatusEvento.APROVADO;

            if(agendamentoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModels("Não foi possivel reprovado este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
        public IActionResult Reprovar (ulong id)
        {
            var pedido = agendamentoRepository.ObterPor(id);

            pedido.Status = (uint) StatusEvento.REPROVADO;

                System.Console.WriteLine();
                System.Console.WriteLine(pedido.Status);
                System.Console.WriteLine("*******************************************");

            if(agendamentoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModels("Não foi possivel reprovado este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
        
    }
}