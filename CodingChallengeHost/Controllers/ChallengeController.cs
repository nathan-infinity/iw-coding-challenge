﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodingChallengeHost.Controllers
{
    public class ChallengeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}