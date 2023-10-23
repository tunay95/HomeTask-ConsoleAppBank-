using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_ConsoleAppBank_.Exceptions
{
    internal class AccountNotFoundException : Exception
    {
        public AccountNotFoundException()
        {
        }

        public AccountNotFoundException(string message) : base(message)
        {
            Console.WriteLine(" The AccNumber Which You Entered is Invalid ( Not Found ) ! ");
        }

    }
}
