using System;
using System.Collections.Generic;
using System.Text;

namespace _3._28._2022.CustomExceptions
{
    class CapacityLimitException:Exception
    {
        public  CapacityLimitException( string message):base(message)
        {
            Console.WriteLine("Limit doldu");
        }
    }
}
