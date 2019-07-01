using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_app.Models
{
    public class StudentRegisterationModel
    {
        [Required(ErrorMessage = "Enter your Name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Select a Program")]
        public string program { get; set; }
        public string detail { get; set; }
        public string myFile { get; set; }
    }
}
