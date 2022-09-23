using ATMUygulamasi.Data;
using ATMUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi.Controller
{
    public class UserController
    {
        public User GetUserByAccNo(string accNo)
        {
            return InMemory.Users.FirstOrDefault(x => x.AccNo == accNo);
        }

        public User UserLogin(string accNo, string password)
        {
            User user = GetUserByAccNo(accNo);

            if (password == user.Password)
            {
                Console.WriteLine("Hoş Geldiniz," + user.Name);
                return user;
            }
            else
            {
                Console.WriteLine("Şifrenizi yanlış girdiniz");
                return null;
            }

        }

    }
}
