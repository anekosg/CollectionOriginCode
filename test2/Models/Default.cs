using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test2.Models
{
    public class Default
    {
        [DataType(DataType.Text)]
        [Required]
        public int ID { get; set; }
        [StringLength(5)]
        [Required]
        public string Email { get; set; }
        [StringLength(5)]
        [Required]
        public string Password { get; set; }
    }
}
