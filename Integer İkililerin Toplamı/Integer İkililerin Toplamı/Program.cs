Console.WriteLine("Lütfen aralarında boşluk bırakarak sayı giriniz");
giris:
try
{
    
    List<int> entry = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    List<int> yeniList = new List<int>();

    for (int i = 0; i < entry.Count - 1;)
    {
        if (entry[i] != entry[i + 1])
        {
            int sum = entry[i] + entry[i + 1];
            yeniList.Add(sum);
            i = i + 2;

        }
        else
        {
            int sum = (int)Math.Pow((entry[i] + entry[i + 1]), (entry[i] + entry[i + 1]));
            yeniList.Add((int)sum);
            i = i + 2;
        }

    }

    string result = "";

    foreach (var item in yeniList)
    {
        result = result + item + " ";
    }

    Console.WriteLine(result);

}
catch (Exception)
{

    Console.WriteLine("Lütfen istenilen formatta giriş yapınız");
    goto giris;
}





