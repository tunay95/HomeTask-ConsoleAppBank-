using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_ConsoleAppBank_.Interfaces
{
    internal interface IAccount
    {
        
        public int AccountId { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
        public string CurrencyType { get; set; }

        public void DepositMoney(int accountId, decimal amount);



        public void WithdrawMoney(int accountId, decimal amount);
     
    }
}
