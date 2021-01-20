using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HealthUp.DataModel
{
    public class Article
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string ThumbnailImage { get; set; }
        [Required]
        public string BannerImage { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

        public string RelateProduct { get; set; }
    }
}
