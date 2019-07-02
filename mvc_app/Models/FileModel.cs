using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_app.Models
{
    
    public class FileModel
    {


        public List<FileAttribute> FilePath { get; set; } 
            = new List<FileAttribute>();
    }
    public class FileAttribute
    {
        public string Names { get; set; }
        public string path { get; set; }

    }
   
}
