using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class BankTransactions
    {
        public static void TransferToChecking(decimal amount, User user)
        {
            if ((user.Savings - amount) > 0)
            {
                user.Savings -= amount;
                user.Checking += amount;
            }
            else
            {
                Console.WriteLine("Not enough funds");
            }
        }
        public static void TransferToSavings(decimal amount, User user)
        {
            user.Savings -= amount;
            user.Checking += amount;
        }
        public static void AddInterest(User user)
        {
            decimal gained = user.Savings * .04m;
            user.Savings += gained;
        }
        public static void AccountBalance(int index, List<User> user)
        {
            Console.WriteLine("Your checking account balance is " + user[index].Checking);
            Console.WriteLine("Your savings account balance is " + user[index].Savings);
        }        
        public static void Deposit(User user, string checkOrSave, decimal amount)
        {
            if (checkOrSave == "Checking")
            {
                user.Checking += amount;
            }
            else
            {
                user.Savings += amount;
            }
        }
    }
}
