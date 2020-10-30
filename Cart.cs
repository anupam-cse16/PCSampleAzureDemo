using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheckCloud
{
    public class Cart
    {

        [Key]
       
        public int id { get; set; }
        public int CartId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("MenuItem")]
        public int MenuCode { get; set; }
        public MenuItem MenuItem { get; set; }
        // public virtual ICollection<MenuItem> MenuItems { get; set; }
        // public  int MenuCode { get; set; }
        //public virtual MenuItem MenuItem { get; set; }
        public User User { get; set; }
    }
}
