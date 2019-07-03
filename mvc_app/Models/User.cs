using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace mvc_app.Models
{
    public class User
    {
        public User()
        {
            Name = "";
            email_address = "";
            phone_number = "";
            job_type = "";
            password = "";
        }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Name must be within 3 and 60 letters")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [Required(ErrorMessage = "Email is required")]
        public string email_address { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public string phone_number { get; set; }

        [Required(ErrorMessage = "Job Type is required")]
        public string job_type { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }

        public IFormFile SelectedFile{ get; set; }
        
    }
    
}
