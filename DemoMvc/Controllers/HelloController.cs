using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc{
    public class HelloController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
    
}
