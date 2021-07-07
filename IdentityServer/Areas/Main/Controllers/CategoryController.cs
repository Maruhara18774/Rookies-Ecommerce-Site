﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Areas.Main.Controllers
{
    [Area("Main")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            string key = RouteData.Values["id"].ToString();
            if (key == "Clothing")
            {
                return RedirectToAction("Clothing");
            }
            return View();
        }
        public IActionResult Clothing()
        {
            return View();
        }
    }
}
