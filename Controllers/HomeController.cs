using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    //action method
    public IActionResult Index(){
        return View();
    }

    public IActionResult About(){
        return View();
    }

    public string Contact(){
        return "Ini adalah halaman Contact";
    }
}