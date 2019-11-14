using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : Controller                          /*Para Criar um pedido no MVC */
    {
        PedidoRepository pedidoRepository = new PedidoRepository();

        HamburguerRepository hamburguerRepository = new HamburguerRepository();     /*Preco dos hamburguer */
        public IActionResult Index()
        {
            PedidoViewModel pvm = new PedidoViewModel();
           pvm.Hamburgueres = hamburguerRepository.ObterTodos();          /*devolver lista */
            return View(pvm);
        }

        public IActionResult Registrar(IFormCollection form)
        {       
                ViewData["Action"] = "Pedido";

                Pedido pedido = new Pedido();

                Shake shake = new Shake();
                shake.Nome = form["shake"];
                shake.Preco = 0.0;
                
                pedido.Shake = shake;

                Hamburguer hamburguer = new Hamburguer (form["hamburguer"], 0.0);      /*Parou AQUI */
                pedido.Hamburguer = hamburguer;
                // hamburguer.Nome = form["hamburguer"];
                // hamburguer.Preco = 0.0;

                Cliente cliente = new Cliente(){

                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"],
                };            

                pedido.Cliente = cliente;

                pedido.DateDoPedido = DateTime.Now;

                pedido.PrecoTotal = 0.0; 

                if (pedidoRepository.Inserir(pedido)) {
                    return View("Sucesso");

                } else {
                    return View("Erro");
                }
        }
    }
}