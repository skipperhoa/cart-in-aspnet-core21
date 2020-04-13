using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartASP_Core21.Models
{
    public class Product
    {
        public int idProduct { get; set; }
        public string Title { get; set; }
        public string UrlImage { get; set; }
        public string Detail { get; set; }
        public int Price { get; set; }
    }
}
