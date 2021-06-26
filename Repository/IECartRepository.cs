using MVCAndOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAndOOP.Repository
{
    public interface IECartRepository
    {
        List<Product> ALLProductsAINCart();
    }
}