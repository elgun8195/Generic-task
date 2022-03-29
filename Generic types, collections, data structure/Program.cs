using Generic_types__collections__data_structure.Exceptions;
using Generic_types__collections__data_structure.Models;
using System;

namespace Generic_types__collections__data_structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book Kitab1 = new Book("Kitabi Dedem Qorqud",20.2,"Mikayil Mushvig",25,222);
            Book Kitab2 = new Book("Kitabi Dedem Qorqud", 20.2, "Mikayil Mushvig", 25, 222);
            Kitab1.Count = 3;
            Kitab1.ShowInfo();
            Kitab2.Count = 3;
            Kitab2.ShowInfo();
            Library lib = new Library(10);
            lib.AddBook(Kitab1);
            lib.AddBook(Kitab2);
            


            try
            {
                lib.RemoveById(2);
                Kitab1.Sell();
                Kitab2.Sell();
            }
            catch (ProductCountIsZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
