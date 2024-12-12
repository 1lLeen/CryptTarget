using CryptTarget.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace CryptTarget.Controllers
{
    public class CryptController : Controller
    {
        protected CryptService _cryptService;
        public CryptController(CryptService service) 
        {
            _cryptService = service;
        }
        public IActionResult Index(int? id)
        {
            if (id == null)
                id = 1; 
            return View(id);
        }
    }
}
