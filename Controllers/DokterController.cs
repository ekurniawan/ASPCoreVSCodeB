
using System.Collections.Generic;
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

        public IActionResult DaftarDokter(){
            List<Dokter> lstDokter = new List<Dokter>();
            lstDokter.Add(
                new Dokter {
                    FirstName = "Erick",
                    LastName = "Kurniawan",
                    Address = "Jl Wahidin 5-25",
                    Telp = "55667788"
                }
            );
            lstDokter.Add(
                new Dokter {
                    FirstName = "Argo",
                    LastName = "Dwipangga",
                    Address = "Jl Jambu 12",
                    Telp = "55667799"
                }
            );
            lstDokter.Add(
                new Dokter {
                    FirstName = "Argo",
                    LastName = "Lawu",
                    Address = "Jl Mangga 13",
                    Telp = "55667766"
                }
            );
            
            return View(lstDokter); 
        }

        public IActionResult Tampil(Dokter dokter)
        {
            //return Content($"{dokter.FirstName} {dokter.LastName}, {dokter.Address}, {dokter.Telp}");
            Dokter model = dokter;
            return View(model);
        }
    }
}
