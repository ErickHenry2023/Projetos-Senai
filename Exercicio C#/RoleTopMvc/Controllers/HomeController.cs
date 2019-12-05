using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTopMvc.Models;
using RoleTopMvc.ViewModels;

namespace RoleTopMvc.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            ViewData["Footer"] = "foot";
            ViewData["Nav"] = "nav";

            return View(new BaseViewModels()
            {
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }
    }
}
