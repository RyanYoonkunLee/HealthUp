using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthUp.DataModel
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string ThumbnailImage { get; set; }
        [Required]
        public string Name { get; set; }       
        public string Capsule { get; set; }
        public string Description { get; set; }       
        public string Ingredients { get; set; }      
        public string Dosage { get; set; }      
        public string Benefits { get; set; }       
        public string PackSize { get; set; }        
        public string Category { get; set; }
        public string ContainNoAdded { get; set; }
        public string Functions { get; set; }
        public string ProductImages { get; set; }
        public int CategoryExpose { get; set; }
        public int ProductExpose { get; set; }
        public string Warning { get; set; }
        
    }
}
