using System;
using System.Collections.Generic;
using System.Text;

namespace _3._28._2022.CustomExceptions
{
    class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string message) : base(message)
        {
            Console.WriteLine("product not found exception");
        }
    }
}
