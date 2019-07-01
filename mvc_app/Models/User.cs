using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core.Models
{
    public class User
    {
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Name must be within 3 and 60 letters")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        [Required]
        public string email_address { get; set; }

        [RegularExpression(@"^[0 - 9]{1, 45}$")]
        [Required]
        public int phone_number { get; set; }

        [Required]
        public string job_type { get; set; }
        [Required]
        public string password { get; set; }
    }
}
