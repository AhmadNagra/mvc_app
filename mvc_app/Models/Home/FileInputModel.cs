using Microsoft.AspNetCore.Http;

namespace mvc_app.Models.Home
{
    public class FileInputModel
    {
        public IFormFile FileToUpload { get; set; }
    }
}
