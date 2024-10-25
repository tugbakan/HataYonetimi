//HATA YÖNETİMİ
Console.WriteLine("***Hata Yönetimi***");

// try //Hata alması muhtemel olan güvence altına almak istediğimiz kod bloğu
// {
//      Console.WriteLine("Bir sayı giriniz:");
//      int sayi= Convert.ToInt32(Console.ReadLine());
//      Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);
// }
// catch(Exception ex) //Hatayı yakaladığında ne yapmak istediğimizi buraya yazıyoruz.
// {
//      Console.WriteLine("Hata: " + ex.Message.ToString());
// }
// finally //Hata alsın ya da almasın bu kod bloğu çalışır.Zorunlu değil.
// {
//      Console.WriteLine("İşlem tamamlandı.");
// }

try
{
    //int a= int.Parse(null);
    //int a= int.Parse("test");
      int a=int.Parse("-200000000000");
}
catch(ArgumentNullException ex) //Yaptığım hata ArgumentNullException hatasıysa bu kod bloğunu çalıştır.
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
}
catch (FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
    Console.WriteLine(ex);
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}