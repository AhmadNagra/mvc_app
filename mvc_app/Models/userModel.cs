using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace mvc_app.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "please enter username")]
       public string Name{ get;set;}

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email{get;set; }

        [Required(ErrorMessage = "please enter comments")]
        public string Comments
        {
            get;set;
        }
        [Required(ErrorMessage = "please enter a choice")]
        public string Choice
        { get; set; }
        public List<FileAttribute> FilePath { get; set; }
              = new List<FileAttribute>();
       

    }
    public class FileAttribute
    {
        public string Names { get; set; }
        public string path { get; set; }

    }

}
