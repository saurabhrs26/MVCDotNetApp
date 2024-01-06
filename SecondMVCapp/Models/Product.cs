using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondMVCapp.Models
{
    public class Product
    {
        public int prodId { get; set; }
        public string propName { get; set; }
        public string prodCompany { get; set; } 

        public string shippingDate{ get; set; }

        public  string address { get; set; }
    }
}