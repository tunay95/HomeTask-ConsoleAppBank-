using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_ConsoleAppBank_.Exceptions
{
    internal class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message)
        {
            Console.WriteLine(" You should enter the number MORE THAN  0 ! ");
        }

    }
}
