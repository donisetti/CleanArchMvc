using Microsoft.AspNetCore.Mvc;

namespace Vasis.Gestor.WebUI.Controllers
{
    public class EmpresasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
