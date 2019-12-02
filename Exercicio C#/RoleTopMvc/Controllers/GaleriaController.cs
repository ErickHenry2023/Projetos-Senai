using Microsoft.AspNetCore.Mvc;

namespace RoleTopMvc.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}