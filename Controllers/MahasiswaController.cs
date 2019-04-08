using ASPCoreGroupB.DAL;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreGroupB.Controllers{
    public class MahasiswaController:Controller {
        private IMahasiswa _mhs;
        public MahasiswaController(IMahasiswa mhs)
        {
            _mhs = mhs;
        }

        public IActionResult Index(){
            var data = _mhs.GetAll();
            return View(data);
        }
    }
}