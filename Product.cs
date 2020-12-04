using System;
using System.Collections.Generic;
using System.Text;

namespace GunShopASP.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
        public string PhotoPath { get; set; }
        public Cat? Category{ get; set; }
    }
}
