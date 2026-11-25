using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("products")]
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("list")]
        public IActionResult GetProducts()
        {
            var products = new List<Product>()
            {

                new Product(){Id=1,Name="P1" },
              new Product() { Id = 2, Name = "P2" }


            };
            return Json(products);

        }

        [HttpGet("list/{id:int}")]
        public IActionResult GetProductById(int id)
        {
            return Json(new Product() { Id = id, Name = "ali" });
        }
    }
}
