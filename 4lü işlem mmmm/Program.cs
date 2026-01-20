using System;

namespace  mitvierzb
{
    class Program
    {
        static void Main()
        {
            string secim;
            do
            {
                Console.Clear();
                Console.WriteLine("=== ANA MENÜ ===");
                Console.WriteLine("1 - Hesap Makinesi");
                Console.WriteLine("2 - Çarpım Tablosu");
                Console.WriteLine("3 - Asal Sayı Kontrolü");
                Console.WriteLine("4 - Faktöriyel Hesaplama");
                Console.WriteLine("5 - Sayı Tahmin Oyunu");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçiminiz: ");
                secim = Console.ReadLine();

                Console.Clear(); 

                switch (secim)
                {
                    case "1":
                        HesapMakinesi();
                        break;
                    case "2":
                        CarpimTablosu();
                        break;
                    case "3":
                        AsalKontrol();
                        break;
                    case "4":
                        Faktoriyel();
                        break;
                    case "5":
                        SayiTahmin();
                        break;
                    case "0":
                        Console.WriteLine("programm schlissen!!");
                        break;
                    default:
                        Console.WriteLine(" 0-5 arasında bir sayı gir.");
                        break;
                }

                

            } while (secim != "0");
        }

        static void HesapMakinesi()
        {
            Console.WriteLine("------- HESAP MAKİNESİ -------");
            Console.Write("1. sayıyı gir: ");
            double.TryParse(Console.ReadLine(), out double sayi1);

            Console.Write("2. sayıyı gir: ");
            double.TryParse(Console.ReadLine(), out double sayi2);

            Console.Write("İşlem seç (+, -, *, /): ");
            string islem = Console.ReadLine();

            double sonuc = 0;
            bool hata = false;

            switch (islem)
            {
                case "+": sonuc = sayi1 + sayi2; break;
                case "-": sonuc = sayi1 - sayi2; break;
                case "*": sonuc = sayi1 * sayi2; break;
                case "/":
                    if (sayi2 != 0) sonuc = sayi1 / sayi2;
                    else {
                        Console.WriteLine("0'a bölünemez!"); hata = true; 
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    hata = true;
                    break;
            }

            if (!hata)
                Console.WriteLine($"Sonuç: {sonuc}");
        }
        static void CarpimTablosu()
        {
            Console.WriteLine("------ ÇARPIM TABLOSU ------");
            Console.Write("Bir sayı gir:");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine("----------");
            }
        }

        static void AsalKontrol()
        {
            Console.WriteLine("----- ASAL SAYI KONTROLÜ ------");
            Console.Write("Bir sayı gir: ");
            int sayi = int.Parse(Console.ReadLine());

            bool asalMi = true;

            if (sayi < 2)
            {
                asalMi = false;
            }
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
            }

            if (asalMi)
                Console.WriteLine($"{sayi} asaldır.");
            else
                Console.WriteLine($"{sayi} asal değildir.");
        }

        static void Faktoriyel()
        {
            Console.WriteLine("----- FAKTÖRİYEL HESAPLAMA ------");
            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi < 0)
            {
                Console.WriteLine("Negatif sayıların faktöriyeli hesaplanmaz!");
                return;
            }

            if (sayi > 20)
            {
                Console.WriteLine("en fazla 20 gir");
                return;
            }

            long sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }

            Console.WriteLine($"{sayi}! = {sonuc}");
        }

        static void SayiTahmin()
        {
            Console.WriteLine("----- SAYI TAHMİN OYUNU -----");
            Random rnd = new Random();
            int hedef = rnd.Next(1, 101);
            int tahmin = 0, deneme = 0;

            while (tahmin != hedef)
            {
                Console.Write("Tahmininiz: ");
                int.TryParse(Console.ReadLine(), out tahmin);
                deneme++;

                if (tahmin < hedef)
                    Console.WriteLine("Daha büyük!");
                else if (tahmin > hedef)
                    Console.WriteLine("Daha küçük!");
                else
                    Console.WriteLine($"Tebrikler! {deneme} denemede buldunuz!");
            }
        }
    }
}
