
using System.Data.SqlClient;
using ASPCoreGroupB.Models;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Security.Cryptography;
using System.Text;
using System;

namespace ASPCoreGroupB.DAL {
    public class PenggunaDAL : IPengguna
    {
        private IConfiguration _config;
        public PenggunaDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr(){
            return _config.GetConnectionString("DefaultConnection");
        }

        public Pengguna CekLogin(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(Pengguna pengguna)
        {
             using(SqlConnection conn = new SqlConnection(GetConnStr())){
                 string strSql = @"insert into Pengguna(Username,Password,Aturan,Nama,Telp) 
                 values(@Username,@Password,@Aturan,@Nama,@Telp)";
                 var param = new {Username=pengguna.Username,
                 Password=GetMd5(pengguna.Password),
                 Aturan=pengguna.Aturan,Nama=pengguna.Nama,
                 Telp=pengguna.Telp};
                 try{
                     conn.Execute(strSql,param);
                 }
                 catch(SqlException sqlEx){
                     throw new Exception($"Error: {sqlEx.Message}");
                 }
             }
        }

        private string GetMd5(string input){
            using (var md5 = MD5.Create())
            {       
                var result = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
                return Encoding.ASCII.GetString(result);
            }
        }
    }
}