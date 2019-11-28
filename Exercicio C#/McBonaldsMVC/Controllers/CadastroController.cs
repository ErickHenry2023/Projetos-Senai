using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class CadastroController : AbstractController    /*27/11 */
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            return View(new BaseViewModel() /*ele busca pelo primeiro nome, ou seja, "Cadastro.index"  */
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