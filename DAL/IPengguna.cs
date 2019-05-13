using ASPCoreGroupB.Models;

namespace ASPCoreGroupB.DAL {
   
   public interface IPengguna
   {
        Pengguna CekLogin(string username,string password); 
        void Insert(Pengguna pengguna);
   }

}