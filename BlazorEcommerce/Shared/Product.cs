using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public String Title { get; set; } = String.Empty;
        public String Description { get; set; } = String.Empty;
        public String ImageUrl { get; set; } = String.Empty;
        public decimal Price { get; set; }
    }
}
