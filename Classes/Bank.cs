using HomeTask_ConsoleAppBank_.Classes;
using HomeTask_ConsoleAppBank_.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_ConsoleAppBank_
{
    internal class Bank
    {

        private BankAccount[] Accounts;
        private bool checkId = false;
        public Bank()
        {
            Accounts = new BankAccount[0];
        }
        public void CreateAccount(string name, string surname, AccountType accountType, CurrencyType currencyType)
        {
            BankAccount account = new(accountType, currencyType, name, surname);
            Array.Resize(ref Accounts, Accounts.Length + 1);
            Accounts[Accounts.Length - 1] = account;
            Console.WriteLine($"Account created successfully.  Name : {name}   Surname : {surname}   Account ID : {account.AccountId}");
        }
        private bool FindAccountById(int accountID)
        {
            try
            {
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].AccountId == accountID)
                    {
                        checkId = true;
                        break;
                    }
                }
                if (!checkId)
                {
                    throw new AccountNotFoundException();
                }
                else
                {
                    return true;
                }
            }
            catch (AccountNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void DepositMoney(int accountId, decimal amount)
        {
            bool checkUser = FindAccountById(accountId);
            if (checkUser)
            {
                BankAccount bankAccount = null;
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].AccountId != accountId)
                    {
                        continue;
                    }
                    bankAccount = Accounts[i];
                    break;
                }
                Console.WriteLine("Which kind of deposite type do you want?");
                Console.WriteLine("1. AZN");
                Console.WriteLine("2. USD");
                Console.WriteLine("3. EUR");
                Console.Write("User choice: ");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    if (bankAccount.CurrencyType == CurrencyType.AZN)
                    {
                        bankAccount.Deposit(amount);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.USD)
                    {
                        bankAccount.Deposit(amount * (decimal)0.59);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.EUR)
                    {
                        bankAccount.Deposit(amount * (decimal)0.55);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                }
                if (userChoice == "2")
                {
                    if (bankAccount.CurrencyType == CurrencyType.AZN)
                    {
                        bankAccount.Deposit(amount * (decimal)1.7);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.USD)
                    {
                        bankAccount.Deposit(amount);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.EUR)
                    {
                        bankAccount.Deposit(amount * (decimal)0.94);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                }
                if (userChoice == "3")
                {
                    if (bankAccount.CurrencyType == CurrencyType.AZN)
                    {
                        bankAccount.Deposit(amount * (decimal)1.8);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.USD)
                    {
                        bankAccount.Deposit(amount * (decimal)1.06);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.EUR)
                    {
                        bankAccount.Deposit(amount);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                }
            }
        }
        public void WithdrawMoney(int accountId, decimal amount)
        {
            bool checkUser = FindAccountById(accountId);
            if (checkUser)
            {
                BankAccount bankAccount = null;
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].AccountId == accountId)
                    {
                        bankAccount = Accounts[i];
                        break;
                    }
                }
                Console.WriteLine("Which kind of deposite type do you want?");
                Console.WriteLine("1. AZN");
                Console.WriteLine("2. USD");
                Console.WriteLine("3. EUR");
                Console.Write("User choice: ");
                string userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    if (bankAccount.CurrencyType == CurrencyType.AZN)
                    {
                        bankAccount.Withdraw(amount);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.USD)
                    {
                        bankAccount.Withdraw(amount * (decimal)0.59);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.EUR)
                    {
                        bankAccount.Withdraw(amount * (decimal)0.55);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                }
                if (userChoice == "2")
                {
                    if (bankAccount.CurrencyType != CurrencyType.AZN)
                    {
                    }
                    else
                    {
                        bankAccount.Withdraw(amount * (decimal)1.7);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.USD)
                    {
                        bankAccount.Withdraw(amount);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.EUR)
                    {
                        bankAccount.Withdraw(amount * (decimal)0.94);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                }
                if (userChoice == "3")
                {
                    if (bankAccount.CurrencyType == CurrencyType.AZN)
                    {
                        bankAccount.Withdraw(amount * (decimal)1.8);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.USD)
                    {
                        bankAccount.Withdraw(amount * (decimal)1.06);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                    if (bankAccount.CurrencyType == CurrencyType.EUR)
                    {
                        bankAccount.Withdraw(amount);
                        Console.WriteLine("Deposit successful. New balance:" + bankAccount.Balance);
                    }
                }
            }
        }
        public void TransferMoney(int fromAccountid, int toAccountid, decimal amount)
        {
            bool checkUser1 = FindAccountById(fromAccountid);
            bool checkUser2 = FindAccountById(toAccountid);
            if (checkUser1 && checkUser2)
            {
                BankAccount fromBankAccount = null;
                BankAccount toBankAccount = null;
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].AccountId == fromAccountid)
                    {
                        fromBankAccount = Accounts[i];
                    }
                    if (Accounts[i].AccountId == toAccountid)
                    {
                        toBankAccount = Accounts[i];
                    }
                }
                if (fromBankAccount.CurrencyType == CurrencyType.AZN && toBankAccount.CurrencyType == CurrencyType.AZN)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
                else if (fromBankAccount.CurrencyType == CurrencyType.AZN && toBankAccount.CurrencyType == CurrencyType.USD)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount * (decimal)0.59);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
                else if (fromBankAccount.CurrencyType == CurrencyType.AZN && toBankAccount.CurrencyType == CurrencyType.EUR)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount * (decimal)0.56);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
                else if (fromBankAccount.CurrencyType == CurrencyType.USD && toBankAccount.CurrencyType == CurrencyType.USD)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
                else if (fromBankAccount.CurrencyType == CurrencyType.USD && toBankAccount.CurrencyType == CurrencyType.AZN)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount * (decimal)1.7);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
                else if (fromBankAccount.CurrencyType == CurrencyType.USD && toBankAccount.CurrencyType == CurrencyType.EUR)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount * (decimal)0.94);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
                else if (fromBankAccount.CurrencyType == CurrencyType.EUR && toBankAccount.CurrencyType == CurrencyType.EUR)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
                else if (fromBankAccount.CurrencyType == CurrencyType.EUR && toBankAccount.CurrencyType == CurrencyType.AZN)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount * (decimal)1.8);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
                else if (fromBankAccount.CurrencyType == CurrencyType.EUR && toBankAccount.CurrencyType == CurrencyType.USD)
                {
                    fromBankAccount.Withdraw(amount);
                    toBankAccount.Deposit(amount * (decimal)1.06);
                    Console.WriteLine("Transfer successful. \nNew balance of sender:" + fromBankAccount.Balance);
                    Console.WriteLine("New balance of receiver:" + toBankAccount.Balance);
                }
            }
        }
        public BankAccount[] GetAllAccounts()
        {
            return Accounts;
        }
        public void TransactionList(int accountId)
        {
            bool chekcId = FindAccountById(accountId);
            if (chekcId)
            {
                BankAccount bankAccount = null;
                for (int i = 0; i < Accounts.Length; i++)
                {
                    if (Accounts[i].AccountId == accountId)
                    {
                        bankAccount = Accounts[i];
                        break;
                    }
                }
                Console.WriteLine($"\n\t{bankAccount.Name} {bankAccount.Surname} Transaction List\n");
                foreach (var item in bankAccount.GetTransactionList())
                {
                    Console.WriteLine();
                    Console.WriteLine($"Transaction amount: {item.Amount}");
                    Console.WriteLine($"Transaction date time: {item.TransactionDate}");
                    Console.WriteLine($"Transaction type: {item.TransactionType}");
                    Console.WriteLine();
                }
            }
        }
       
    }
    }
}
