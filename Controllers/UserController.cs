using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User(){UserId=1,UserName="Sam",UserPwd="sam@1256",UserEmail="sam@yahoo.com"},
            new User(){UserId=2,UserName="Ram",UserPwd="Ram@1256",UserEmail="Ram@yahoo.com"},
            new User(){UserId=3,UserName="Sham",UserPwd="sham@1256",UserEmail="sham@yahoo.com"},
            new User(){UserId=4,UserName="Salim",UserPwd="salim@1256",UserEmail="salim@yahoo.com"},
            new User(){UserId=5,UserName="Shahim",UserPwd="shahim@1256",UserEmail="shahim@yahoo.com"},
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User Model)
        {
            if (ModelState.IsValid)
            {
                users.Add(Model);

                return RedirectToAction("Index");
            }
            else
            {
                return View(Model);
            }
        }
    }
}
