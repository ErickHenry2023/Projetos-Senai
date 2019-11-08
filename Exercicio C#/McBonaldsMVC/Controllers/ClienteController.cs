using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Login()       /*IActionResult  para mostrar a pag "return View();"*/
        {
            return View();
        }
    }
}