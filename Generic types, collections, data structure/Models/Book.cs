using Generic_types__collections__data_structure.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types__collections__data_structure.Models
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(string name,double price,string authorName,double totalInCome, int pageCount)
        {
            TotalInCome = totalInCome;
            Name = name;
            Price = price;            
            AuthorName = authorName;
            PageCount = pageCount;

        }
        public override void Sell()
        {
            if (Count==0)
            {
                throw new ProductCountIsZeroException("0 ola bilmez!");
            }
            else
            {
                Count--;
                TotalInCome+=Price;
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - AuthorName: {AuthorName} - PageCount: {PageCount} - Price: {Price} - Count: {Count} - TotallInCome: {TotalInCome}");
        }
    }
}
