using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace books.Pages.EmployeeList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {

            _db = db;
        }
        [BindProperty]
        public Employee employee { get; set; }
        public async Task OnGet(int id)
        {

            employee = await _db.employee.FindAsync(id);


        }

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {

                var EmpFromDb = await _db.employee.FindAsync(employee.id);

                EmpFromDb.FName = employee.FName;
                EmpFromDb.LName = employee.LName;
                EmpFromDb.PhoneNumber = employee.PhoneNumber;
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage();

        }
    }
}
