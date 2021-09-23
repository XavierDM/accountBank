using System;

namespace accountBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your initial balance");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            BankAccount account = new BankAccount(name, amount);
            Console.WriteLine($"Accoount {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            //BankAccount account2 = new BankAccount("Xavier", 1000);
            //Console.WriteLine($"Accoount {account2.Number} was created for {account2.Owner} with {account2.Balance} initial balance.");

            do
            {
                Console.WriteLine("Would you like to :");
                Console.WriteLine("1. Make a deposit");
                Console.WriteLine("2. Make a withdrawal");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("How much would you like to deposit?");
                    int deposit = int.Parse(Console.ReadLine());
                    Console.WriteLine("Would you like to add a comment?");
                    string comment = Console.ReadLine();
                    account.MakeDeposit(deposit, DateTime.Now, comment);
                    Console.WriteLine(account.Balance);
                    
                }
                else if (choice == "2")
                {
                    Console.WriteLine("How much do you wish to withdraw?");
                    int withdraw = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please add a comment");
                    string comment = Console.ReadLine();
                    account.MakeWithdrawal(withdraw, DateTime.Now, comment);
                    Console.WriteLine(account.Balance);
                    
                }
                else
                {
                    Console.WriteLine(account.GetAccountHistory());
                    Console.WriteLine("Thank you for choosing Becode Bank.");
                    break;
                }
            } while (true);

            /*account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid back");
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());

            GiftCartAccount giftCard = new GiftCartAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            InterestEarningAccount savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());

            LineOfCreditAccount lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, " take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "partial restoration of repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());*/

            /*BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caugh creating account with negative balance");
                Console.WriteLine(e.ToString());
                return;
            }*/

            /*try
            {
                account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }*/
        }
    }
}
