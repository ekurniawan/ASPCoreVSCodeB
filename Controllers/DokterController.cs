
using ASPCoreGroupB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreGroupB.Controllers
{
    public class DokterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tampil(Dokter dokter)
        {
            //return Content($"{dokter.FirstName} {dokter.LastName}, {dokter.Address}, {dokter.Telp}");
            Dokter model = dokter;
            return View(model);
        }
    }
}
