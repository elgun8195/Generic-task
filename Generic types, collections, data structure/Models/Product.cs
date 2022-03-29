using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types__collections__data_structure.Models
{
    abstract class Product
    {
        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public byte Count { get; set; }

        protected double TotalInCome { get; set; }

        public Product( )
        {
            _id++;
            Id = _id;
        }

        public abstract void Sell();
        public abstract void ShowInfo();
        

    }
}
