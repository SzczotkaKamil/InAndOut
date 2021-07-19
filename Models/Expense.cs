using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Item Name")]
        [Required]
        public string ItemName { get; set; }
        [Required]
        [DisplayName("Item Value")]
        public int ItemValue { get; set; }

    }
}
