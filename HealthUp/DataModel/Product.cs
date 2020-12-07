using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthUp.DataModel
{
    public class Product
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string benefits { get; set; }
        [Required]
        public int size { get; set; }
        
    }
}
