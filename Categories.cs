using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheckCloud
{
    public class Categories
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
