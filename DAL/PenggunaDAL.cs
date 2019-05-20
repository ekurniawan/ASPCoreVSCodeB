
using System.Data.SqlClient;
using ASPCoreGroupB.Models;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Security.Cryptography;
using System.Text;
using System;

namespace ASPCoreGroupB.DAL
{
    public class PenggunaDAL : IPengguna
    {
        private IConfiguration _config;
        public PenggunaDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public Pengguna CekLogin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr())){
                string strSql = @"select * from Pengguna where 
                Username=@Username and Password=@Password";

                var param = new {Username=username,
                    Password=GetMd5(password)};
                
                var pgn = conn.QuerySingleOrDefault<Pengguna>(strSql,param);
                if(pgn!=null){
                    return pgn;
                }else {
                    throw new Exception("Username atau Password tidak sesuai");
                }
            }
        }

        public void Insert(Pengguna pengguna)
        {
            using (SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"insert into Pengguna(Username,Password,Aturan,Nama,Telp) 
                 values(@Username,@Password,@Aturan,@Nama,@Telp)";
                var param = new
                {
                    Username = pengguna.Username,
                    Password = GetMd5(pengguna.Password),
                    Aturan = pengguna.Aturan,
                    Nama = pengguna.Nama,
                    Telp = pengguna.Telp
                };
                try
                {
                    conn.Execute(strSql, param);
                }
                catch (SqlException sqlEx)
                {
                    throw new Exception($"Error: {sqlEx.Message}");
                }
            }
        }

        private string GetMd5(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}