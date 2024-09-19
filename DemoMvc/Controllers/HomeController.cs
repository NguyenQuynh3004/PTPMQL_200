using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly ILogger<HomeController>_logger;
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]   
     public IActionResult Index (string Fullname,string Address ){
        var output = "Xin chào "+Fullname +"Sống ở "+Address;
        ViewData["Message"]=output;
        return View ();
     }

}
