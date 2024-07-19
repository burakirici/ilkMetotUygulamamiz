// Geriye değer döndürmeyen bir void metot
void sarkiSozu()
{
    Console.WriteLine("Eskisi gibi değiliz");
}
sarkiSozu();
// Geriye tamsayı Döndüren Bir Metot.
{
    int kalan = rastgeleSayi();
    Console.WriteLine($"Rastgele sayinin 2 ye bölümünden kalan: {kalan}");
}
int rastgeleSayi()
{
Random rnd = new Random();
int rastgele = rnd.Next();
return rastgele % 2;
}

// Parametre Alan ve Geriye Değer Döndüren Bir Metot

int carpimUyg(int x=5, int y=4)
{
    return x*y;
}
carpimUyg();
// Parametre Alan ve Geriye Değer Döndürmeyen Bir Metot
static void Main(string[] args)
{
    string name = "Burak";
    string surname = "Kırıcı";

    isimSoyisim(name, surname);
}
static void isimSoyisim(string name, string surname)
{
    
    Console.WriteLine($"Hos Geldiniz {name} {surname}!");
}