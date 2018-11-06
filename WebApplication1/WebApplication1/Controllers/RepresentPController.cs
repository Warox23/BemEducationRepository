using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RepresentPController : Controller
    {
        [Route("represent")]
        public IActionResult RepresentP()
        {
            SomeModel x = new SomeModel();
            x.Text = "AnotherName";
            
            return View(x);
        }
    }
}