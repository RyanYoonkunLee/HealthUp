using System;
using System.Collections.Generic;
using System.Text;

namespace HealthUp.ViewModel
{
    public class ProductViewModel
    {
        public Guid id { get; set; }
        public int number { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string benefits { get; set; }
        public int size { get; set; }
    }
}
