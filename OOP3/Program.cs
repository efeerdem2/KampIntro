using OOP3;

IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
TasitKrediManager tasitKrediManager = new TasitKrediManager();
KonutKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService FileLoggerService = new FileLoggerService();


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());

List<IKrediManager> krediler = new List<IKrediManager>{ihtiyacKrediManager, tasitKrediManager};
{ };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);