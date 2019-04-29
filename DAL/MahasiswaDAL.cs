using System.Collections.Generic;
using System.Data.SqlClient;
using ASPCoreGroupB.Models;
using Microsoft.Extensions.Configuration;
using Dapper;
using System;

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

        public IEnumerable<Mahasiswa> GetAll(){
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                string strSql = @"select * from Mahasiswa order by Nama";
                return conn.Query<Mahasiswa>(strSql);
            }
        }

        public void Delete(string nim)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                //var strSql = @"delete from Mahasiswa wh";
            }
        }

        public Mahasiswa GetById(string nim)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"select * from Mahasiswa 
                             where Nim=@Nim";
                var param = new {Nim=nim};
                var result = conn.QuerySingleOrDefault(strSql,param);
                if(result!=null)
                    throw new Exception("Error: data tidak ditemukan !");
                
                return result;
            }
        }

        public void Insert(Mahasiswa mhs)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr())){
                var strSql = @"insert into Mahasiswa(Nim,Nama,Email,Telp) 
                values(@Nim,@Nama,@Email,@Telp)";

                try{
                    var param = new {Nim=mhs.Nim,Nama=mhs.Nama,Email=mhs.Email,
                        Telp=mhs.Telp};
                    conn.Execute(strSql,param);
                }
                catch(SqlException sqlEx){
                    throw new Exception($"Error : {sqlEx.Message}");
                }
            }
        }

        public void Update(Mahasiswa mhs)
        {
            
        }
    }
}