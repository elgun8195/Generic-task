using _3._28._2022.Models;
using _3._28._2022.CustomExceptions;
using System;

namespace _3._28._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Test",24,3);
            product.ShowInfo();


            try
            {

            }
            catch (CapacityLimitException )
            {
                Console.WriteLine("capacity");
            }
            catch (ProductCountException)
            {
                Console.WriteLine("Count error");
            }
            catch (ProductNotFoundException)
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
