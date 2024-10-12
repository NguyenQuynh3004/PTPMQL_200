using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
     // tăng độ bảo mật cho ứng dụng
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
        // trả về dữ liệu (var)
        var output = "Xin chào "+Fullname +"Sống ở "+Address;
        ViewData["Message"]=output;
        return View ();
     }

}
