using System;
using System.Collections.Generic;
using ASPCoreGroupB.DAL;
using ASPCoreGroupB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreGroupB.Controllers
{
    public class PenggunaController : Controller{
        private IPengguna _pengguna;
        public PenggunaController(IPengguna pengguna){
            _pengguna = pengguna;
        }

        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username,string password){
            try{
                var pgn = _pengguna.CekLogin(username,password);
                HttpContext.Session.SetString("username",pgn.Username);
                HttpContext.Session.SetString("aturan",pgn.Aturan);
                ViewData["pesan"] = $"Selamat Datang {pgn.Username}";
                return View("Home/Index");
            }catch(Exception ex){
                return Content(ex.Message);
            }
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