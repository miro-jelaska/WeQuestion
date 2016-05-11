using Microsoft.AspNet.Mvc;

namespace WeQuestion.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
