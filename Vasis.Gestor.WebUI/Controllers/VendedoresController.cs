using Microsoft.AspNetCore.Mvc;

namespace Vasis.Gestor.WebUI.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
