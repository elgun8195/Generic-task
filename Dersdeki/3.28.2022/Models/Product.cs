using System;
using System.Collections.Generic;
using System.Text;

namespace _3._28._2022.Models
{
    class Product
    {
        private static int _id;
        public int Id { get; }
        public byte Price { get; set; }

        public string Name { get; set; }
        public int Count { get; set; }



        public Product(string name,byte price,int count)
        {
            _id++;
            Id = _id;
            Name = name;
            Price = price;
            Count = count;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"{Name}---{Price}---{Id}---{Count}");
        }
    }
}