using MVCAndOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAndOOP.Repository
{
    public class Stock
    {
        static List<Product> empList = null;

        static List<Product> CartStockList = null;

        static Stock()
        {
            empList = new List<Product>(){
            new Product()
            {
                
                ID = new Guid(),
                Name = "Salahuddin Ahmed",
                Description = "Coke",
                Price = 555,
                Quantity = 5
            }
            };
            CartStockList = new List<Product>(){
            new Product()
            {

                Name = "",
                Description = "",
                Price = 0,
                Quantity = 0
            }
            };

        }

        public static List<Product> SelectList()
        {
            return empList;
        }

        public static void InsertProduct(Product emp)
        {
            empList.Add(emp);
        }

        public static void UpdateProduct(Product emp)
        {
            Product empUpdate = empList.Find(x => x.ID == emp.ID);
            empUpdate.Name = emp.Name;
            empUpdate.Description = emp.Description;
            empUpdate.Price = emp.Price;
            empUpdate.Quantity = emp.Quantity;
        }
        public static void DeleteProduct(Guid id)
        {
            Product empDelete = empList.Find(x => x.ID == id);
            empList.Remove(empDelete);
        }
        public static void InsertInCart(Product emp)
        {
            CartStockList.Add(emp);
        }
        public static List<Product> SelectcartList()
        {
            return CartStockList;
        }

    }
}



