using ATMUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public class ATMOps
    {
        

        public void EndOfDayReport(string fileName)
        {
            StreamReader sReader = new StreamReader(fileName);

            Console.WriteLine("*****Gün Sonu*****");

            while (sReader.ReadLine() is string s)
            {
                Console.WriteLine(s);
            }

            sReader.Close();

            Console.WriteLine("*****Gün Sonu Başarıyla Alınmıştır*****");
        }

        public void DepositBalance(User user, double balance, string fileName)
        {
            StreamWriter sWriter = new StreamWriter(fileName, true);

            double depositedBalance = balance;

            user.Balance += depositedBalance;

            Console.WriteLine("Bakiyeniz: " + user.Balance);

            sWriter.WriteLine(depositedBalance + " kadar hesaba yatırıldı");
            sWriter.Close();
        }

        public void WithdrawBalance(User user, double balance, string fileName)
        {
            StreamWriter sWriter = new StreamWriter(fileName, true);

            double withdrawedBalance = balance;

            user.Balance -= withdrawedBalance;

            Console.WriteLine("Kalan Bakiye: " + user.Balance);

            sWriter.WriteLine(withdrawedBalance + " kadar hesaptan çekildi");
            sWriter.Close();
        }



    }
}
