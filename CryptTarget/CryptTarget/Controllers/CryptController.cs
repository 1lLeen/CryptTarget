using CryptTarget.Models.Services;
using CryptTarget.Models.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CryptTarget.Controllers
{
    public class CryptController : Controller
    {
        protected ICryptService _cryptService;
        public CryptController(ICryptService service) 
        {
            _cryptService = service;
        }
        public async Task<IActionResult> Index(int? id)
        {
            await _cryptService.UpdateCrypts(); 
            return View(await _cryptService.GetCrypts(id));
        }
    }
}
