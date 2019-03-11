
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    //action method
    public IActionResult Index(){
        return View();
    }

    public string About(){
        return "Ini adalah halaman About";
    }

    public string Contact(){
        return "Ini adalah halaman Contact";
    }
}