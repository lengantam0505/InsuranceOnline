using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceOnline.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { set; get; }
        public string CategoryName { set; get; }
        public string Description { set; get; }
        public DateTime Created_at { set; get; }

    }
}
