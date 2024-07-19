
{
    sarkiSozu();
    System.Console.WriteLine($"2 ye Bolumunden kalan {rastgeleSayi()}");
    Console.WriteLine($"Carpma isleminin sonucu: {carpimUyg(5,7)}");
    isimSoyisim("burak", "kırıcı");
}



void sarkiSozu()
{
    Console.WriteLine("Eskisi gibi değiliz");
}
// Geriye tamsayı Döndüren Bir Metot.

int rastgeleSayi()
{
Random rnd = new Random();
int rastgele = rnd.Next();
return rastgele % 2;
}

// Parametre Alan ve Geriye Değer Döndüren Bir Metot

int carpimUyg(int x, int y)
{
    return x*y;
}
// Parametre Alan ve Geriye Değer Döndürmeyen Bir Metot

static void isimSoyisim(string name, string surname)
{
    
    Console.WriteLine($"Hos Geldiniz {name} {surname}!");
}