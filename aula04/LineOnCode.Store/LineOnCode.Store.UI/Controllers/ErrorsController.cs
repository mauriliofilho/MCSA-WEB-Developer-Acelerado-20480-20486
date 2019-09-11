using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineOnCode.Store.UI.Controllers
{
    public class ErrorsController : Controller
    {
        public IActionResult E404() => View();
        public IActionResult E500() => View(); 

    }
}
