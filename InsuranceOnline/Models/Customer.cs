using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceOnline.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Gender { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public string Email { set; get; }
        public DateTime Created_at { set; get; }
        public bool Status { set; get; }
        

    }
}
