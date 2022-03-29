using Generic_types__collections__data_structure.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_types__collections__data_structure.Models
{
    internal class Library
    {
        public int BookLimit { get; set; }
                
        List<Book> Books = new List<Book>();
        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
        }

        public void AddBook(Book Book)
        {
            if (Books.Capacity < BookLimit)
            {
                Books.Add(Book);
            } else
            {
                throw new CapacityLimitException("Limit dolub!");
            }
        }

        public Book GetBookById(int? id)
        {
            foreach (var item in Books)
            {
                if (item.Id==id)
                {
                    return item;
                }
                else if (id==null)
                {
                    throw new NullReferenceException();
                }                 
            }
            return null;
        }

        public void RemoveById(int? id)
        {
            foreach (var item in Books)
            {
                if (item.Id == id)
                {
                    Books.Remove(item);
                }
                else if (id == null)
                {
                    throw new NullReferenceException();
                }
            }
            throw new NotFoundException("Tapilmadi!");
        }
    }
}
