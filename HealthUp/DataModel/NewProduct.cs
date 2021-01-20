using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthUp.DataModel
{
    public class NewProduct
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string ThumbnailImage { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Body { get; set; }
    }
}
