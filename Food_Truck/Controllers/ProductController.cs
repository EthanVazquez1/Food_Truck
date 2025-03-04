using Food_Truck.Models;
using Microsoft.AspNetCore.Mvc;

namespace Food_Truck.Controllers
{
    public class ProductController : Controller
    {
        // GET: Display the form
        public IActionResult AddProduct()
        {
            return View();
        }

        // POST: Handle form submission
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                // Save product to database (mock for now)
                ViewBag.Message = "Product added successfully!";
                return View(product);
            }

            return View(product);
        }
    }
}
