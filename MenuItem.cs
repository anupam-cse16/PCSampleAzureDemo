using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCheckCloud
{
    public class MenuItem
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Menucode { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public bool active { get; set; }
        public DateTime date_of_launch { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        // public string CategoryName { get; set; }
        public bool freeDelivery { get; set; }
        public virtual Categories Category { get; set; }
    }
}
