using Microsoft.AspNet.Identity;
using MyChatApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyChatApp.Controllers
{
    public class HomeController : Controller
    {public readonly ApplicationDbContext  _context;
        public readonly UserManager <AppUser>_userManager;
        public HomeController (ApplicationDbContext context, UserManager <AppUser>_userManager)

        {
            _context = context ;
            _userManager = userManager ;

        }
        public async Task<IActionResult>Index()
        {
            var currentUser = _userManager.GetUserAsync(User);
            If(User.Identity.IsAuthenticated){
                ViewBag.CurrentUserNAme = await_currentUser.UserName;
            }
                var messages = ContextBoundObject.Messages.ToListAsync();
           
                return View();
        }
        public async Task<IActionResult>Create(Message messsage)
        {
            if (ModelState.IsValid)
            {
                message.Username = User.Identity.Name;
                    var sender = await_userManager.GetUserAsync(User);
                    Message.UserID = sender.Id;
                await_context.Messages.AddAsync(message);
                Await_context.SaveChangesAsync();
                return Ok();
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}