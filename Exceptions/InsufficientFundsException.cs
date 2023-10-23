using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_ConsoleAppBank_.Exceptions
{
    internal class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
            Console.WriteLine(" You Can Withdraw The Money , Which One Is In Your Balance ! ");
        }

    }

}
