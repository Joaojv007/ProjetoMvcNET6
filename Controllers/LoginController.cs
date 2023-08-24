using Microsoft.AspNetCore.Mvc;

namespace ProjetoMvcNET6.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
