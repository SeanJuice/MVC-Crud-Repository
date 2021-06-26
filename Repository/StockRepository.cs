using MVCAndOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAndOOP.Repository
{
    public class StockRepository: IEStockRepository,IECartRepository
    {
        public List<Models.Product> SeletctALLPS()
        {
            return Stock.SelectList();
        }

        public Models.Product SelectById(Guid id)
        {
            return Stock.SelectList().Find(x => x.ID == id);
        }

        public void InsertProduct(Models.Product emp)
        {
            Stock.InsertProduct(emp);
        }

        public void UpdateProduct(Models.Product emp)
        {
            Stock.UpdateProduct(emp);
        }

        public void DeleteProduct(Guid id)
        {
            Stock.DeleteProduct(id);
        }

        public List<Product> ALLProductsAsStock()
        {
            throw new NotImplementedException();
        }
        public List<Product> ALLProductsAINCart()
        {
            return Stock.SelectcartList();
        }
        public void Addtocart(Models.Product emp)
        {
            Stock.InsertInCart(emp);
        }
    }
}


