using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_app.Models
{
    public class PaginationModel 
    {
        // [BindProperty(SupportsGet = true)]
        public string SortBy { get; set; } = "Id";
        public int Currentpage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 5;
        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));
        public List<StudentRegisterationModel> StudentList { get; set; } = new List<StudentRegisterationModel>();


    }
}
