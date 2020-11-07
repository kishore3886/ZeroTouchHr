using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace books.Pages.EmployeeList
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Employee> employees { get; set; }
        public async Task OnGet()
        {
            employees = await _db.employee.ToListAsync();
        }
    }
}
