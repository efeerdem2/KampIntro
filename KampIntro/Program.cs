//type safety - tip güvenliği

//Do not repeat yourself - Kendini Tekrarlama 



string kategoriEtiket = "Kategoriler: ";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemGirisYapmisMi = false;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("azalış butonu");
}
else if (dolarDun < dolarBugun)
{
    Console.WriteLine("artış butonu");
}
else
{
    Console.WriteLine("değişmedi butonu");
    {
    
}

    if (sistemGirisYapmisMi == true)
    {
        Console.WriteLine("Kullanıcı Ayarları Butonu");
    }
    else
    {
        Console.WriteLine("Giriş Yap Butonu");
    }

    Console.WriteLine(kategoriEtiket);
