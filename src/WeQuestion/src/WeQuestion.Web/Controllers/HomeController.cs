using Microsoft.AspNet.Mvc;
using WeQuestion.Domain.Repository;

namespace WeQuestion.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //using (var dbContext = new WeQuestionDbContext())
            //{
            //    var newUser = new User() {Name = "Nikola"};
            //    dbContext.Users.Add(newUser);
            //    dbContext.SaveChanges();
            //}
            var repo = new GetAllPolls();
            var polls = repo.Get();
            return View(polls.Count);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
