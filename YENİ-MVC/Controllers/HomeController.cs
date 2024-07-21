using Microsoft.AspNetCore.Mvc;
using YENİ_MVC.Models.context;
using YENİ_MVC.Models.entity;


namespace YENİ_MVC.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {



           
            NorthwindContext northwind = new NorthwindContext();

      

 

            // NorthwindContext Northwind = new NorthwindContext();  

            List<Product> Product = northwind.Products.ToList();

            List <string>list=new List <string>();
            list.Add("furkan");
            list.Add("hasan"); 
            return View(list);
            
            // fronted liste gidiyor. 

        }
        


    }
}
