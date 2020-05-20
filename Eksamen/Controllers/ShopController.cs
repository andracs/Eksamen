using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eksamen.Data;
using Eksamen.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Eksamen.Controllers
{
    public class ShopController : Controller
    {
        private WebshopContext db = new WebshopContext(new DbContextOptions<WebshopContext>());

       
        // GET: /<controller>/
        public IActionResult Shop()
        {
            String connectionString = "<yourconnectionstringhere>";
            String sql = "SELECT * FROM products";
            var model = new List<Product>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var product = new Product();
                    product.Name = rdr.GetString(rdr.GetOrdinal("Name"));
                    product.Name = rdr.GetString(rdr.GetOrdinal("Name"));
                    model.Add(product);
                }

            }

            return View(model);
        }
    }
}

