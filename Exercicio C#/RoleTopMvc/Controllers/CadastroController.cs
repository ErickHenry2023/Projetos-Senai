using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
using RoleTopMvc.Enums;
using RoleTopMvc.Models;
using RoleTopMvc.Repositories;
using RoleTopMvc.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoleTopMvc.Controllers
{
    public class CadastroController : AbstractController
    {

        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            ViewData["Footer"] = "";
            ViewData["Nav"] = "";

            return View(new BaseViewModels()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioTipo = ObterUsuarioTipoSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)         /*Para retornar uma TELA "IActionResult" (IFormCollection "(ctrl+.)"*/
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["data-nascimento"]);

            ViewData["Action"] = "Cadastro";

            try
            {
                System.Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                System.Console.WriteLine(form["tMail"]);
                System.Console.WriteLine();

                Cliente cliente = new Cliente(form ["tName"], form["tMail"],  form["tSenha"], form["tCPF/CNPJ"], form["tTel"]);
                cliente.TipoUsuario = (uint) TipoUsuario.CLIENTE;

                clienteRepository.Inserir(cliente);
                return View("Sucesso", new RespostaViewModels()
                {
                    NomeView = "Cadasto",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession ()
                });

            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);     /*p/  tirar o erro "e" */
            return View("Erro", new RespostaViewModels()
                {
                    NomeView = "Cadasto",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession ()
                });
            }

            
        }

    }
}