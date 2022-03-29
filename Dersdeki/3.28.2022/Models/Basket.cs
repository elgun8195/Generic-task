using _3._28._2022.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _3._28._2022.Models
{
    class Basket
    {
        public int StockCount { get; set; }
        public int Count { get; set; }
        public int ProductLimit { get; set; }

        List<Product> Products = new List<Product>();

        public Basket()
        {
           // Products = new Product[0];
        }

        public void AddProduct(Product product)
        {
           
        }
        public void RemoveProduct(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException("Bosh ola bilmez");
            }
            else
            {
                throw new ProductNotFoundException("Product tapilmadi");
            }
        }
        public void RemoveAll<Product>(int? id)
        {

            Products.Clear();
        }
        public void IncreaseProductCount(Product product)
        {
            Count++;
            StockCount-=Count;
        }
        public void DecreaseProductCount(Product product)
        {
            Count-=StockCount;
            StockCount++;
        }
        public void GetAllProducts()
        {

        }


    }
}
