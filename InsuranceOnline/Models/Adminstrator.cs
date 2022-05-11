using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceOnline.Models
{
    public class Adminstrator
    {
        [Key]
        public int ID { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
    }
}
