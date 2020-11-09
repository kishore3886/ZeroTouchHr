using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using books.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace books.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public Employee employee { get; set; }
        public void OnGet()
        {

            ViewData["StartedCount"] =  _db.employee.Where(e => e.Status == "Started").Count();
            ViewData["InprocessCount"] = _db.employee.Where(e => e.Status == "Inprocess").Count();
            ViewData["CompletedCount"] = _db.employee.Where(e => e.Status == "Completed").Count();

        }
    }
}
