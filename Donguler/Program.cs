string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
string kurs2 = "Programlamaya başlangıç için tememl kurs";
string kurs3 = "Java";

//array - dizi

string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
    "Programlamaya başlangıç için tememl kurs",
    "Java", "C#", "Python" };


for (int i = 0; i <kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("for bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine();
}



Console.WriteLine("sayfa sonu - footer");