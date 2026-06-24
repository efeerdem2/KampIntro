using Metotlar;

string urunAdi = "Elma";
double fiyati = 15;
string aciklama = "Amasya Elması";

string[] meyveler = new string[] { };

Product product1 = new Product();
product1.Adi = "Elma";
product1.Fiyati = 15;
product1.Aciklama = "Amasya Elması";

Product product2 = new Product();
product2.Adi = "Karpuz";
product2.Fiyati = 15;
product2.Aciklama = "Diyarbakır Karpuzu";

Product[] products = new Product[] { product1, product2 };

//type -safe -- tip güvenli
foreach (var product in products)
{
    Console.WriteLine(product.Adi);
    Console.WriteLine(product.Aciklama);
    Console.WriteLine(product.Fiyati);
    Console.WriteLine("--------------------");
}

Console.WriteLine("----------Metotlar----------");

//encapsulation - kapsülleme
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
sepetManager.Ekle(product2);


sepetManager.Ekle2("armut", "yeşil armut", 12);
sepetManager.Ekle2("armut2", "sarı armut", 12);  //bu şekilde yazıldığında yeni bir bilgi ekleniceği zaman hepsi hata verir ve fazladan tekrar eklemek zorunda kalınıyor
sepetManager.Ekle2("armut3", "kırmızı armut", 12);









//Dont repeat Yourself - DRY - Clean Code - Best Practices

