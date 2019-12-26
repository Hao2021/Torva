using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Torva.Controllers
{
    //Only after login you access this controller else you will be redirected back to the login page.
    public class ContentController : Controller
    {
        public IActionResult Index()
        {

            return View();


        }
    }
}
