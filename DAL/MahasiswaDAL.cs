using System.Collections.Generic;
using System.Data.SqlClient;
using ASPCoreGroupB.Models;
using Microsoft.Extensions.Configuration;

namespace ASPCoreGroupB.DAL { 
    public class MahasiswaDAL : IMahasiswa {
        private IConfiguration _config;
        public MahasiswaDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }

        public List<Mahasiswa> GetAll(){
            using(SqlConnection conn = new SqlConnection()){

            }
        }

        public void Delete(string nim)
        {
            throw new System.NotImplementedException();
        }

        

        public Mahasiswa GetById(string nim)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Mahasiswa mhs)
        {
            throw new System.NotImplementedException();
        }
    }
}