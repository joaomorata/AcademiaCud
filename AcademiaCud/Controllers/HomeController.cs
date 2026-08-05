using Microsoft.AspNetCore.Mvc;

namespace AcademiaCud.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult SobreNos()
        {
            ViewData["Title"] = "Sobre Nós";
            return View();
        }
    }
}
