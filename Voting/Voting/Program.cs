// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using Voting.Controller;
using Voting.Entities;

baslangic:
Console.WriteLine("Lütfen Kullanıcı Adınınız Giriniz:");

string name = Console.ReadLine();

UserController UserController = new UserController();

CategoryController categoryController = new CategoryController();

User tryingUser = UserController.GetUserByName(name);


if (tryingUser == null)
{
    Console.WriteLine("Böyle bir kullanıcı bulunamadı, lütfen kayıt olun");

    Console.WriteLine("Lütfen Kullanıcı Adınınız Giriniz:");

    string newName =  Console.ReadLine();

    Console.WriteLine("Lütfen şifre giriniz:");

    string newPassword = Console.ReadLine();

    UserController.AddUser(newName, newPassword);

    goto baslangic;
}
else
{
    Console.WriteLine("Lütfen şifre giriniz:");
}

string password = Console.ReadLine();

User LoggedinUser =  UserController.UserLogin(name, password);

Console.WriteLine("Lütfen oy kullanacağınız kategoriyi seçiniz");

List<Category> categories = categoryController.GetAllCategories();

foreach (Category category in categories)
{
    int CID = category.CategoryId;

    Console.WriteLine(category.CategoryName +" için "+ CID);
}

int vote = int.Parse(Console.ReadLine());

Category votedCategory = categoryController.GetCategoryById(vote);

categoryController.RaiseVoteCount(votedCategory);

foreach (Category category in categories)
{
    Console.WriteLine(category.VoteCount);
}
goto baslangic;





