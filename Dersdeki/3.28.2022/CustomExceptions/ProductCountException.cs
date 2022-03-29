using System;
using System.Collections.Generic;
using System.Text;

namespace _3._28._2022.CustomExceptions
{
    class ProductCountException:Exception
    {
        public ProductCountException(string message):base(message)
        {
            Console.WriteLine("product exception");
        }
    }
}
