using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace BankAcount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make List of accounts 
            List<User> Test = User.getList();

            Console.WriteLine("Welcome to Bank of America!");

            //Check login
            bool auth = false;
            string userName = null;
            while (auth == false)
            {
                Console.WriteLine("Enter username:");
                userName = Console.ReadLine();
                foreach (var userNameCheck in Test)
                {
                    if (userName == userNameCheck.Username)
                    {
                        auth = true;
                    }
                }
            }
            bool passAuth = false;
            while (passAuth == false)
            {
                Console.WriteLine("Enter password:");
                string passWord = Console.ReadLine();
                foreach (var pass in Test)
                {
                    if (passWord == pass.Password)
                    {
                        passAuth = true;
                    }
                }
            }
            //Find proper index for logged in user
            int index = -1;
            for (int i = 0; i < Test.Count; i++)
            {
                if (userName == Test[i].Username)
                {
                    index = i;
                }
            }
            Console.WriteLine("You have logged in successfully " + userName + " at " + DateTime.Now);
            BankTransactions.AccountBalance(index,Test);
            Console.WriteLine();
            Console.WriteLine("Transferring 100.23 from savings to checking");
            BankTransactions.TransferToChecking(100.23m, Test[index]);
            BankTransactions.AccountBalance(index, Test);
            Console.WriteLine();
            Console.WriteLine("Applying 4% interest to savings");
            BankTransactions.AddInterest(Test[index]);
            BankTransactions.AccountBalance(index, Test);
            Console.WriteLine();
            BankTransactions.Deposit(Test[index],"Checking",100.00m);
            BankTransactions.AccountBalance(index, Test);

        }


    }
}
