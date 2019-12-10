using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

            // clienteRepository.ObterPor();

            return View (evm);
        }
            /*hacer esta parte */

    //         public IActionResult Registrar (IFormCollection form) {
    //         ViewData["Action"] = "Orcamento";

    //         Evento evento = new Evento ();

    //         // Shake shake = new Shake();
    //         // shake.Nome = form["shake"];
    //         // shake.Preco = 0.0;

    //         // pedido.Shake = shake;

    //         List<Servico> servicos = new List<Servico>();               /*PAREI AQUI */

    //         string[] nomesServicos = form["tadicionais"].ToString().Split(",");

    //         foreach (var nomeservico in nomesServicos)
    //         {
    //             servicos.Add(new Servico(nomeServico, servicoRepositorio.ObterPrecoDe(nomeServico)));
    //         }

    //         Servico servico = new Servico (
    //             nomeServico,
    //             servicoRepository.ObterPrecode (nomeServico));

    //         pedido.Hamburguer = hamburguer;
    //         // hamburguer.Nome = form["hamburguer"];
    //         // hamburguer.Preco = 0.0;

    //         var nomeShake = form["shake"]; /*Para pegar o preço do produto */
    //         Shake shake = new Shake (
    //             nomeShake,
    //             shakeRepository.ObterPrecode (nomeShake));

    //         pedido.Shake = shake;

    //         Cliente cliente = clienteRepo.ObterPor (emailCliente);



    //         pedido.Cliente = cliente;

    //         pedido.DateDoPedido = DateTime.Now;

    //         pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

    //         if (agendamentoRepository.Inserir (pedido)) {
    //             return View ("Sucesso", new RespostaViewModels("Sucesso") {
    //                 NomeView = "Cadastro",
    //                 UsuarioNome = ObterUsuarioNomeSession(),
    //                 UsuarioEmail = ObterUsuarioSession()
    //             });

    //         } else {
    //             return View ("Sucesso", new RespostaViewModels("Erro") {
    //                 NomeView = "Cadastro",
    //                 UsuarioNome = ObterUsuarioNomeSession(),
    //                 UsuarioEmail = ObterUsuarioSession()
    //             });
    //     }
    // }

    //     public IActionResult Aprovar (ulong id)
    //     {
    //         var pedido = agendamentoRepository.ObterPor(id);

    //         pedido.Status = (uint) StatusPedido.APROVADO;

    //         if(agendamentoRepository.Atualizar(pedido))
    //         {
    //             return RedirectToAction("Dashboard", "Administrador");
    //         }
    //         else
    //         {
    //             return View("Erro", new RespostaViewModels("Não foi possivel reprovado este pedido")
    //             {
    //                 NomeView = "Dashboard",
    //                 UsuarioEmail = ObterUsuarioSession(),
    //                 UsuarioNome = ObterUsuarioNomeSession()
    //             });
    //         }

    //     }
    //      public IActionResult Reprovar (ulong id)
    //     {
    //         var pedido = agendamentoRepository.ObterPor(id);

    //         pedido.Status = (uint) StatusPedido.REPROVADO;

    //         if(agendamentoRepository.Atualizar(pedido))
    //         {
    //             return RedirectToAction("Dashboard", "Administrador");
    //         }
    //         else
    //         {
    //             return View("Erro", new RespostaViewModels("Não foi possivel reprovado este pedido")
    //             {
    //                 NomeView = "Dashboard",
    //                 UsuarioEmail = ObterUsuarioSession(),
    //                 UsuarioNome = ObterUsuarioNomeSession()
    //             });
    //         }

    //     }
        
    }
}