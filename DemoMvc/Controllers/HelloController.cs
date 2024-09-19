using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;
namespace DemoMvc.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Index( Person ps)
         {
            string strOutput = "Xin chao" + ps.PersonId + "-" + ps.Fullname + "-" + ps.Address;
            ViewBag.Message = strOutput;
            return View();
            
         }
    }

}