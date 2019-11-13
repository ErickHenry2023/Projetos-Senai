using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class CadastroController : Controller
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            return View();          /*ele busca pelo primeiro nome, ou seja, "Cadastro.index"  */
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
                return View("Sucesso");

            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);     /*p/  tirar o erro "e" */
                return View ("Erro");
            }

            
        }

    }
}