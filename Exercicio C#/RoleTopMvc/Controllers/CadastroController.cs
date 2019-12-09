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
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult CadastrarCliente(IFormCollection form)         /*Para retornar uma TELA "IActionResult" (IFormCollection "(ctrl+.)"*/
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["data-nascimento"]);

            ViewData["Action"] = "Cadastro";

            try
            {
                Cliente cliente = new Cliente(form ["nome"], form["endereco"], form["telefone"], form["senha"], form["email"], DateTime.Parse(form["data-nascimento"]));

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