using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using TMS_New.Models;

namespace TMS_New.Controllers
{
    public class AccountController : Controller
    {
        private readonly DBModel gdb = new DBModel();

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = gdb.aspnet_Users.Where(x => x.UserName.Equals(model.Username)).FirstOrDefault();
            var userPassword = gdb.aspnet_Membership.Where(x => x.UserId.Equals(user.UserId)).FirstOrDefault();
            if (user == null || userPassword == null)
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
            var hashedPassword = Crypto.HashPassword(model.Password);
            var verified = Crypto.VerifyHashedPassword(hashedPassword, userPassword.Password);
            if (verified)
            {
                return RedirectToLocal(returnUrl);
            }

            ModelState.AddModelError("", "Invalid login attempt.");
            return View(model);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}