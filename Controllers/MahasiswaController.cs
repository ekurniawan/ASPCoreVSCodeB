using System;
using ASPCoreGroupB.DAL;
using ASPCoreGroupB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreGroupB.Controllers
{
    public class MahasiswaController : Controller
    {
        private IMahasiswa _mhs;
        public MahasiswaController(IMahasiswa mhs)
        {
            _mhs = mhs;
        }

        public IActionResult Index()
        {
            var data = _mhs.GetAll();
            return View(data);
        }

        [HttpPost]
        public IActionResult Search(string keyword){
            var data = _mhs.GetAllByNim(keyword);
            return View("Index",data);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(string id){
            try{
                _mhs.Delete(id);
                var data = _mhs.GetAll();
                ViewData["pesan"] =
                    "<span class='alert alert-success'>Data Mahasiswa berhasil didelete</span>";
                return View("Index",data);
            }catch(Exception ex){
                return Content($"Error: {ex.Message}");
            }
        }

        public IActionResult Details(string id)
        {
            try
            {
                var data = _mhs.GetById(id);
                return View(data);
            }
            catch (Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }

        }

        [HttpPost]
        public IActionResult Edit(Mahasiswa mhs){
            try{
                _mhs.Update(mhs);
                ViewData["pesan"] =
                    "<span class='alert alert-success'>Data Mahasiswa berhasil diedit</span>";
                return View("Details");
            }catch(Exception ex){
                return Content($"Error: {ex.Message}");
            }
        }


        [HttpPost]
        public IActionResult CreatePost(Mahasiswa mhs)
        {
            try
            {
                _mhs.Insert(mhs);
                ViewData["pesan"] =
                    "<span class='alert alert-success'>Data Mahasiswa berhasil ditambah</span>";
                return View("Create");
            }
            catch (Exception ex)
            {
                ViewData["pesan"] =
                $"<span class='alert alert-danger'>Data Gagal Ditambah, {ex.Message}</span>";
                return View("Create");
            }
        }
    }
}