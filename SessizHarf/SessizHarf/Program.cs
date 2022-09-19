// See https://aka.ms/new-console-template for more information

string[] sessizHarf = { "b", "c", "ç", "d", "f", "g", "h", "j", "k", "m", "n", "p", "r", "s", "ş", "t", "v", "y", "z", "x", "q", "w" };

string sonuc = "";

Console.WriteLine("Lütfen bir cümle giriniz");

List<string> cumle = Console.ReadLine().TrimEnd().Split(' ').ToList();

foreach (var kelime in cumle)
{
    bool kontrol = false;

    for (int i = 0; i < kelime.Length-1; i++)
	{	
		string harf =Convert.ToString(kelime[i]);
		string sonrakiHarf = Convert.ToString(kelime[i+1]);

		if (harf != " " && sessizHarf.Contains(harf) && sessizHarf.Contains(sonrakiHarf))
		{
			kontrol = true;
			break;
		}
		else
		{
            kontrol =false;
        }
	}

	sonuc += kontrol+" ";
}

Console.WriteLine(sonuc);






