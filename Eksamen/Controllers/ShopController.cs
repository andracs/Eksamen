using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eksamen.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eksamen.Controllers
{
    public class ShopController : Controller
    {
        private WebshopContext db = new WebshopContext(new DbContextOptions<WebshopContext>());
        // GET: /<controller>/
        public IActionResult Shop()
        {
        
            return View(db.Products.ToList());
        }
    }
}

