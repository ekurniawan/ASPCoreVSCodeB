
//localhost/{Controller}/{Action Method}
public class HomeController
{
    //action method
    public string Index(){
        return "Hello from ASP Controller";
    }

    public string About(){
        return "Ini adalah halaman About";
    }

    public string Contact(){
        return "Ini adalah halaman Contact";
    }
}