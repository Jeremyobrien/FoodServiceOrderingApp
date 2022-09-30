using Microsoft.AspNetCore.Mvc;

namespace FoodServiceOrderingApp.Controllers
{
    public class ContactController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
