namespace HomeTask_ConsoleAppBank_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();
            bool running = true;
            Console.WriteLine("===========================Welcome============================\n");
            do
            {
                Console.WriteLine("\t     ============== Menyu =============\n");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. To deposit money");
                Console.WriteLine("3. To withdraw money");
                Console.WriteLine("4. List of transactions");
                Console.WriteLine("5. List of accounts");
                Console.WriteLine("6. Money transfer between accounts");
                Console.WriteLine("7. Currency conversion");
                Console.WriteLine("8. Exit");
                Console.Write("\nEnter the operation you want to select: ");
                string choice = Console.ReadLine();
                if (choice == "8") running = false;
                if (Operation.TryParse(choice, out Operation userChoice))
                {
                    AppMenu(userChoice, bank);
                }
                else
                {
                    Console.WriteLine("\nInvalid choice, try again!\n");
                }
            } while (running);
            Console.WriteLine("\n\t        Program has been stopped!\n");
            Console.WriteLine("==============================================================\n");

        }
        public static void AppMenu(Operation userChoice, Bank bank)
        {
            switch (userChoice)
            {
                case Operation.CreateAccount:
                    Console.WriteLine("\n\tCreate account section\n");
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Surname: ");
                    string surname = Console.ReadLine();

                    Console.WriteLine("Account type:");
                    Console.WriteLine("1. Checking");
                    Console.WriteLine("2. Savings");
                    Console.WriteLine("3. Business");
                    Console.Write("User choice: ");
                    string userChoice2 = Console.ReadLine();

                    AccountType accountType = AccountType.Default;
                    if (AccountType.TryParse(userChoice2, out AccountType newChoice))
                    {
                        switch (newChoice)
                        {
                            case AccountType.Checking:
                                accountType = AccountType.Checking;
                                break;
                            case AccountType.Savings:
                                accountType = AccountType.Business;
                                break;
                            case AccountType.Business:
                                accountType = AccountType.Savings;
                                break;
                            default:
                                Console.WriteLine("\nChoice is wrong, try again!");
                                return;
                                break;
                        }
                    }

                    Console.WriteLine("Currency type:");
                    Console.WriteLine("1. AZN");
                    Console.WriteLine("2. USD");
                    Console.WriteLine("3. EUR");
                    Console.Write("User choice: ");
                    string userChoice3 = Console.ReadLine();

                    CurrencyType currencyType = CurrencyType.Default;
                    if (CurrencyType.TryParse(userChoice3, out CurrencyType newChoice2))
                    {

                        switch (newChoice2)
                        {
                            case CurrencyType.AZN:
                                currencyType = CurrencyType.AZN;
                                break;
                            case CurrencyType.USD:
                                currencyType = CurrencyType.USD;
                                break;
                            case CurrencyType.EUR:
                                currencyType = CurrencyType.EUR;
                                break;
                            default:
                                Console.WriteLine("\nChoice is wrong, try again!");
                                return;
                                break;
                        }
                    }

                    bank.CreateAccount(name, surname, accountType, currencyType);
                    break;
                case Operation.DepositMoney:
                    Console.WriteLine("\n\tDeposit money section\n");
                    Console.Write("Bank account ID: ");
                    string bankAccountId = Console.ReadLine();
                    Console.Write("The amount of money: ");
                    string amount = Console.ReadLine();
                    if (int.TryParse(bankAccountId, out int newID) && decimal.TryParse(amount, out decimal newAmount))
                    {
                        bank.DepositMoney(newID, newAmount);
                    }
                    break;
                case Operation.WithdrawMoney:
                    Console.WriteLine("\n\tWithdraw money section\n");
                    Console.Write("Bank account ID: ");
                    string bankAccountId2 = Console.ReadLine();
                    Console.Write("The amount of money: ");
                    string amount2 = Console.ReadLine();
                    if (int.TryParse(bankAccountId2, out int newID2) && decimal.TryParse(amount2, out decimal newAmount2))
                    {
                        bank.WithdrawMoney(newID2, newAmount2);
                    }
                    break;
                case Operation.ListTransactions:
                    Console.WriteLine("\n\tTransaction list section\n");
                    Console.Write("Bank account ID: ");
                    string bankAccountId3 = Console.ReadLine();
                    if (int.TryParse(bankAccountId3, out int newID3))
                    {
                        bank.TransactionList(newID3);
                    }
                    break;
                case Operation.ListAccounts:
                    Console.WriteLine("\n\tBank accounts list\n");
                    foreach (var item in bank.GetAllAccounts())
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Bank account ID: {item.AccountId}");
                        Console.WriteLine($"Bank account name: {item.Name}");
                        Console.WriteLine($"Bank account surname: {item.Surname}");
                        Console.WriteLine($"Bank account balance: {item.Balance}");
                        Console.WriteLine($"Bank account account type: {item.AccountType}");
                        Console.WriteLine($"Bank account currency type: {item.CurrencyType}");
                        Console.WriteLine();

                    }
                    break;
                case Operation.TransferMoney:
                    Console.WriteLine("\n\tTransfer money section\n");
                    Console.Write("Bank account ID(From): ");
                    string bankAccountIdFrom = Console.ReadLine();
                    Console.Write("Bank account ID(To): ");
                    string bankAccountIdTo = Console.ReadLine();
                    Console.Write("The amount of money: ");
                    string amount4 = Console.ReadLine();
                    if (int.TryParse(bankAccountIdFrom, out int newID4) && decimal.TryParse(amount4, out decimal newAmount4)
                        && int.TryParse(bankAccountIdTo, out int newID5))
                    {
                        bank.TransferMoney(newID4, newID5, newAmount4);
                    }
                    break;
                case Operation.CurrencyConversion:
                    Console.WriteLine("\n\tCurrency conversion section\n");
                    Console.Write("Bank account ID: ");
                    string bankAccountId5 = Console.ReadLine();
                    if (int.TryParse(bankAccountId5, out int newID6))
                    {
                        bank.CurrencyConversion(newID6);
                    }
                    break;
                case Operation.Exit:
                    break;
                default:
                    Console.WriteLine("\nUser choice is wrong, try again!");
                    break;
            }
        }
    }
}