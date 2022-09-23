// See https://aka.ms/new-console-template for more information
using ATMUygulamasi;
using ATMUygulamasi.Controller;
using ATMUygulamasi.Data;
using ATMUygulamasi.Entities;
using System;

baslangic:

DateTime date = DateTime.Now;

string fileName = "EOD_" + String.Format("{0:ddMMyyyy}", date) + ".txt";

UserController userController = new UserController();
ATMOps ATMOps = new ATMOps();

Console.WriteLine("RealDay Bank'a hoş geldiniz\nLütfen hesap numaranızı giriniz:");

string accNo = Console.ReadLine();

User tryingUser = userController.GetUserByAccNo(accNo);


if (tryingUser == null)
{
    Console.WriteLine("Böyle bir kullanıcı bulunamadı");
    goto baslangic;
}
else
{
    Console.WriteLine("Lütfen şifrenizi giriniz");
}

string password = Console.ReadLine();

User loggedinUser = userController.UserLogin(accNo, password);

if (loggedinUser == null)
{
    goto baslangic;
}
else
{
    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz \n Para yatrımaka için 1'e \n Para çekmek için 2'ye \n Gün sonu raporu için 3'e basınız");

    int secim = int.Parse(Console.ReadLine());

    switch (secim)
    {
        case 1:

            Console.WriteLine("Yatırmak istediğiniz tutaruz giriniz");

            double depositedBalance = double.Parse(Console.ReadLine());

            ATMOps.DepositBalance(loggedinUser, depositedBalance, fileName);

            goto baslangic;

            

        case 2:

            Console.WriteLine("Çekmek istediğiniz tutarı giriniz");

            double withdrawedBalance = double.Parse(Console.ReadLine());

            ATMOps.WithdrawBalance(loggedinUser, withdrawedBalance, fileName);

            goto baslangic;

            

        case 3:

            ATMOps.EndOfDayReport(fileName);

            goto baslangic;

            

    }
}


