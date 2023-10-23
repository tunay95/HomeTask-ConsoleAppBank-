using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_ConsoleAppBank_
{
    public enum AccountType
    {
        Default=0,
        Checking,
        Savings, 
        Business

    }
    public enum CurrencyType
    {

        USD, 
        AZN, 
        EUR

    }
    public enum Operation
    {

        CreateAccount, 
        DepositMoney,
        WithdrawMoney,
        ListTransactions,
        ListAccounts,
        TransferMoney,
        CurrencyConversion,
        Exit

    }
}
