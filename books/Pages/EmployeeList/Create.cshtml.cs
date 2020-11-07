using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace books.Pages.EmployeeList
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Employee employee { get; set; }

        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                
                await _db.employee.AddAsync(employee);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {

                return Page();
            }
            
        }

        //public async Task<IActionResult> OnPost(Employee employeeObj)
        //{

        //    return 
        //}

    }
}
