using System;
using System.Collections.Generic;
using ASPCoreGroupB.DAL;
using ASPCoreGroupB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreGroupB.Controllers
{
    public class PenggunaController : Controller{
        private IPengguna _pengguna;
        public PenggunaController(IPengguna pengguna){
            _pengguna = pengguna;
        }

        public IActionResult Registrasi(){
            return View();
        }

        [HttpPost]
        public IActionResult Registrasi(Pengguna pengguna){
            try{
                _pengguna.Insert(pengguna);
                 ViewData["pesan"] =
                    "<span class='alert alert-success'>Registrasi Pengguna Berhasil, Silahkan Login untuk masuk</span>";
                return View();
            }
            catch(Exception ex){
                return Content($"Error: {ex.Message}");
            }
        }
    }
}