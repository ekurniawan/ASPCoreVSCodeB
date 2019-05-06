
using System.ComponentModel.DataAnnotations;

namespace ASPCoreGroupB.Models{
    public class Mahasiswa {

        [Required]
        public string Nim { get; set; }
        
        [Required]
        public string Nama { get; set; }
        
        [Required]
        public string Email { get; set; }
        public string Telp { get; set; }
    }
}