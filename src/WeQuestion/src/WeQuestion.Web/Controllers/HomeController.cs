using Microsoft.AspNet.Mvc;
using WeQuestion.Data;

namespace WeQuestion.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var dbContext = new WeQuestionDbContext())
            {
                var newUser = new User() {Name = "Nikola"};
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
            }
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
