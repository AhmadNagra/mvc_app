using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_app.Models
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string plainPassword { get; set; }
    }
}
