using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace books.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string FName { get; set; }
        public string LName { get; set; }

        public string PhoneNumber { get; set; }

        public string title { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        public string Zip { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string Status { get; set; }
    }
}
