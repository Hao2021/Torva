using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Torva.Controllers
{
    //Only after login you access this controller else you will be redirected back to the login page.
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            return View("Views/Account/Login.cshtml");
        }
    }
}
