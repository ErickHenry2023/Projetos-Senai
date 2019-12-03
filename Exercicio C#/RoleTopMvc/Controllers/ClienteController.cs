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
    public class ClienteController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new BaseViewModels()
            {
                NomeView = "Cliente",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}