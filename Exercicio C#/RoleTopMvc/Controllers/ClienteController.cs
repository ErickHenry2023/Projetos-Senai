using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopMvc.Enums;
using RoleTopMvc.Models;
using RoleTopMvc.Repositories;
using RoleTopMvc.ViewModels;

namespace RoleTopMvc.Controllers
{
    public class ClienteController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        private AgendamentoRepository agentamentoRepository = new AgendamentoRepository();
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Footer"] = "";
            ViewData["Nav"] = "";

            return View(new BaseViewModels()
            {
                NomeView = "Cliente",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

            [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("=================");
                System.Console.WriteLine(form["tMail"]);
                System.Console.WriteLine(form["tSenha"]);
                System.Console.WriteLine("=================");

                var usuario = (form["tMail"]);                  /*P/ hacer login del usuario */
                var senha = (form["tSenha"]);

                var cliente = clienteRepository.ObterPor(usuario);

                if (cliente != null)                            /*Comecou daqui 21/11 */
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch (cliente.TipoUsuario)
                            
                        {
                            case (uint) TipoUsuario.CLIENTE:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                            return RedirectToAction("Historico", "Cliente");

                            default:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                            return RedirectToAction("Dashboard", "Administrador");
                        }
                        
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModels("Senha incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModels($"Usuario {usuario} não encontrado"));
                }

                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);     /*p/  tirar o erro "e" */
                return View ("Erro", new RespostaViewModels()
                {
                    NomeView="Login",
                    UsuarioEmail=ObterUsuarioSession(),
                    UsuarioNome= ObterUsuarioNomeSession(),

                });
            }
        }

        public IActionResult Historico ()                                               /*Foi criado 21/11 hacer login */
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var eventosCliente = agentamentoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Eventos = eventosCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Logoff()       /*27/11 */
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();             /*P/ encerrar a sessao */
            return RedirectToAction("Index", "Home");
        }
        }
    }
