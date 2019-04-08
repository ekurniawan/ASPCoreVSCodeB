using System.Collections.Generic;
using System.Data.SqlClient;
using ASPCoreGroupB.Models;
using Microsoft.Extensions.Configuration;

namespace ASPCoreGroupB.DAL { 
    public class MahasiswaDAL {
        private IConfiguration _config;
        public MahasiswaDAL(IConfiguration config)
        {
            _config = config;
        }

        

        public List<Mahasiswa> GetAll(){
            using(SqlConnection conn = new SqlConnection()){

            }
        }
    }
}