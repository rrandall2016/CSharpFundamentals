using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Checking { get; set; }
        public decimal Savings { get; set; }

        public User(int id, string username, string password, decimal check, decimal save)
        {
            Id = id;
            Username = username;
            Password = password;
            Checking = check;
            Savings = save;
        }

        private static List<User> Users = new()
        {
            new User(1, "Randy", "12345", 1000.15m, 500.15m),
            new User(1, "Kim", "12345", 13337.33m,1000.17m),
            new User(1, "Koga", "12345", 500000.55m, 1000000.17m)
        };

        public static List<User> getList()
        {
            return Users;
        }
        
    }
}
