using Microsoft.AspNetCore.Mvc;

namespace CryptTarget.Controllers
{
    public class CryptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
