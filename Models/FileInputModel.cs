using Microsoft.AspNetCore.Http;

namespace ASPCoreGroupB.Models
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}