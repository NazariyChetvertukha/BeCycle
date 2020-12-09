﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Hackaton_test.Controllers
{
    [Authorize]
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}