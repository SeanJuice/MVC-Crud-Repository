using MVCAndOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAndOOP.Repository
{
    public interface IEStockRepository
    {
        List<Product> SeletctALLPS();
        Product SelectById(Guid id);
        void InsertProduct(Product emp);
        void UpdateProduct(Product emp);
        void DeleteProduct(Guid id);
    }
}