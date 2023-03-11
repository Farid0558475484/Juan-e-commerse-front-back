﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]


    public class DashboardController : Controller
        
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}