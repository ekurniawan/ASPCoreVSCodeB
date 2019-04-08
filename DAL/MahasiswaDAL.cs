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
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                List<Mahasiswa> lstMahasiswa = new List<Mahasiswa>();
                string strSql = @"select * from Mahasiswa order by Nama";
                SqlCommand cmd = new SqlCommand(strSql,conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows){
                    while(dr.Read()){
                        var mhs = new Mahasiswa {
                            Nim = dr["Nim"].ToString(),
                            Nama = dr["Nama"].ToString(),
                            Email = dr["Email"].ToString(),
                            Telp = dr["Telp"].ToString()
                        };
                        lstMahasiswa.Add(mhs);
                    }
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();

                return lstMahasiswa;
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