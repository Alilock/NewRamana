using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class GenderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
