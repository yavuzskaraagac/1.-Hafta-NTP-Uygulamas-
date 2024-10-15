using System;

class AsalSayiToplami
{
    static void Main(string[] args)
    {
        // Kullanıcıdan N sayısını al
        Console.Write("Bir N sayısı girin: ");
        int n = int.Parse(Console.ReadLine());

        // Asal sayıların toplamı için değişken tanımla
        int toplam = 0;

        // 2'den N'e kadar olan tüm sayıları kontrol et
        for (int i = 2; i <= n; i++)
        {
            bool asal = true;

            // 2'den i'nin kareköküne kadar olan sayılarla kontrol et
            for (int j = 2; j * j <= i; j++)
            {
                if (i % j == 0)
                {
                    asal = false; // Eğer tam bölünürse asal değildir
                    break; // Döngüyü kır, daha fazla kontrol etmeye gerek yok
                }
            }

            // Eğer sayı asal ise toplamı ekle
            if (asal)
            {
                toplam += i;
            }
        }

        // Sonucu ekrana yazdır
        Console.WriteLine("N'e kadar olan asal sayıların toplamı:" + toplam );
        Console.ReadKey();
    }
}
