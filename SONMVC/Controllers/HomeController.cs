using Microsoft.AspNetCore.Mvc;
using SONMVC.Models.context;
using SONMVC.Models.entity;


namespace SONMVC.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            NorthwindContext northwind = new NorthwindContext();
            
              List<Product> products= northwind.Products.ToList();    


          // List<Product> products = new List<Product>();   // bununla geldi ..




            return View(products);  

        }

        

       

    }
}
