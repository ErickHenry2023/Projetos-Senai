using Microsoft.AspNetCore.Mvc;
using RoleTopMvc.ViewModels;

namespace RoleTopMvc.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {
            
            return View(new BaseViewModels()
            {
                NomeView = "Galeria",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
}