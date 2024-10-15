using System;

namespace AdamAsmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kelimelerin olduğu diziyi oluşturalım.
            string[] kelimeler = { "fener", "tadic", "ferdi", "dzeko", "irfan" };

            // Rastgele bir kelime seçelim.
            Random rastgele = new Random();
            string randomKelime = kelimeler[rastgele.Next(kelimeler.Length)];
            Console.WriteLine("Adam Asmaca Oyununa Hoş Geldiniz!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            // Puan değişkenini tanımlayalım.
            int puan = 0;

            // Tahmin hakkı değişkenini tanımlayalım.
            int tahminHakki = 5;

            // Seçilen kelimedeki harf kadar _ oluştursun.
            char[] karakter = new char[randomKelime.Length];
            for (int i = 0; i < karakter.Length; i++)
            {
                karakter[i] = '_';
            }

            // Oyun döngüsü
            while (true)
            {


                // Kelimenin mevcut durumunu ekrana yazdıralım
                Console.Write("Kelime: ");
                foreach (var y in karakter)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Kalan Tahmin Hakkınız: " + tahminHakki);

                // Kullanıcıdan bir harf girmesini isteyelim
                Console.WriteLine("Bir harf giriniz:");
                char harf = char.Parse(Console.ReadLine());

                // Girilen harfin doğru olup olmadığını kontrol edelim
                bool dogruTahmin = false;
                for (int i = 0; i < randomKelime.Length; i++)
                {
                    if (harf == randomKelime[i])
                    {
                        karakter[i] = harf;
                        dogruTahmin = true;
                    }
                }

                // Eğer tahmin yanlışsa tahmin hakkı azalır
                if (!dogruTahmin)
                {
                    tahminHakki--;
                    Console.WriteLine("Yanlış tahmin! Kalan tahmin hakkınız: " + tahminHakki);
                }

                // Eğer tüm kelimeyi doğru tahmin edersek oyunu kazanırız
                if (new string(karakter) == randomKelime)
                {
                    Console.WriteLine("Tebrikler! Kelimeyi doğru tahmin ettiniz: " + randomKelime);
                    Console.ReadKey();
                }

                // Tahmin hakkı biterse oyunu kaybederiz
                if (tahminHakki == 0)
                {
                    Console.WriteLine("Tahmin hakkınız bitti. Oyunu kaybettiniz! Doğru kelime: " + randomKelime);
                    Console.ReadKey();
                }
                Console.WriteLine("----------------------------------");

            }
        }
    }
}

