using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthUp.ViewModel
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Benefits { get; set; }
        public string Size { get; set; }
        public string ThumbnailImage { get; set; }
        public string Dosage { get; set; }
        public string Ingredient { get; set; }
        public string ContainNoAdded { get; set; }
        [Required]
        public List<string> Category { get; set; }
        [Required]
        public List<string> Function { get; set; }
        public string ProductImages { get; set; }
        [Required]
        public int CategoryExpose { get; set; }
        [Required]
        public int ProductExpose { get; set; }
    }
}
