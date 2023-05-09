using System.Collections.Generic;
using System;
using System.Linq;

namespace ASP.NET_Razor_2.Models
{
    public class Product
    {
        public int ID { set; get; }
        public String Name { set; get; }
        public String Desciption { set; get; }
        public Decimal Price { set; get; } = 0;
    }

    
    
}
