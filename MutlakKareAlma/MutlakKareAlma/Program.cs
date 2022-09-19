Console.WriteLine("Lütfen aralarında boşluk bırakarak sayılar giriniz");
giris:
try
{
    List<int> entry = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    int kucuk = 0;
    int buyuk = 0;
    string kucukSonuc = "";
    string buyukSonuc = "";


    for (int i = 0; i < entry.Count; i++)
    {
        if (entry[i] < 67)
        {
            int eklenecekSayi = 67 - entry[i];
            kucuk = kucuk + eklenecekSayi;

            if (kucuk>0)
            {
                kucukSonuc = kucuk + " ";
            }
            
        }
        else
        {
            int ekelnecekSayi = (int)Math.Pow((entry[i] - 67), 2);
            buyuk = buyuk + ekelnecekSayi;

            buyukSonuc = buyuk + " ";
        }
    }

    Console.WriteLine(kucukSonuc + "" + buyukSonuc);
}
catch (Exception)
{
    Console.WriteLine("Lütfen istenilen formatta giriş yapınız");
    goto giris;
}



