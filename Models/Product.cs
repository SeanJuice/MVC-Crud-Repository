using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAndOOP.Models
{
    public class Product
    {

        public Guid ID { get; set; }
        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }
        public  string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}