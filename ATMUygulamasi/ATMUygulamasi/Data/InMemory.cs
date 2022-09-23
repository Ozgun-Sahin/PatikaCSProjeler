using ATMUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi.Data
{
    public class InMemory
    {
        private static List<User> _users;

        static InMemory()
        {
            _users = new List<User>
            {
                new User{Id=1, Name="Özgün", Password="123", AccNo="111", Balance =10000},
                new User{Id=2, Name="Damla", Password="123", AccNo="222", Balance =6000},
                new User{Id=3, Name="Admin", Password="111", AccNo="000", Balance =0},
            };  
        }

        public static List<User> Users { get { return _users; } }

        public static string Bok { get { return "bok"; } }


    }
}
