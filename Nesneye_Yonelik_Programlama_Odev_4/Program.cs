using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    // 1. Matematiksel Hesaplama Yapan Parametresiz ve Geriye Değer Döndüren Metot
    public static double UcgenAlani()
    {
        Console.Write("Taban Giriniz: ");
        double taban = Convert.ToDouble(Console.ReadLine());
        Console.Write("Yükseklik Giriniz: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());
        return (taban * yukseklik) / 2;
    }

    // 2. Dizideki En Büyük Değeri Bulan Parametreli ve Geriye Değer Döndüren Metot
    public static int DizidekiMaxDeger(int[] dizi)
    {
        int max = dizi[0];
        foreach (int sayi in dizi)
        {
            if (sayi > max)
            {
                max = sayi;
            }
        }
        return max;
    }

    // 3. Aşırı Yüklenmiş (Overloaded) Metot ile Farklı Türdeki Verilerin Toplamını Bulma
    public static int CalculateSum(int pw, int px)
    {
        return pw + px;
    }

    public static double CalculateSum(double py, double pz)
    {
        return py + pz;
    }

    public static int CalculateSum(int pi, int pj, int pk)
    {
        return pi + pj + pk;
    }

    // 4. Recursive Metot ile Fibonacci Dizisi Hesaplama
    public static int Fibonacci5(int n)
    {
        if (n <= 1) return n;
        return Fibonacci5(n - 1) + Fibonacci5(n - 2);
    }

    // 5. Params ile Sınırsız Sayıda Parametre Alarak Ortalama Hesaplama
    public static double OrtHes(params double[] sayilar)
    {
        double toplam = 0;
        foreach (double sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam / sayilar.Length;
    }

    // 6. Dizi Elemanlarını Toplayan ve Filtreleme Şartı Ekleyen Metot
    public static int ToplaVeFiltrele(int[] dizi, int filtre)
    {
        int toplam = 0;
        foreach (int sayi in dizi)
        {
            if (sayi > filtre)
            {
                toplam += sayi;
            }
        }
        return toplam;
    }

    // 7. Seçmeli (Optional) Parametre ile Belirli Yaştan Sonraki Yılları Sayma
    public static int YasHesapla(int yas, int varsayılan = 18)
    {
        return yas - varsayılan;
    }

    // 8. Geriye Koleksiyon Döndüren ve Veriyi Filtreleyen Metot
    public static List<string> BestenBuyukOlanlariFiltreleme(string[] dizi)
    {
        List<string> sonuc = new List<string>();
        foreach (string LS in dizi)
        {
            if (LS.Length > 5)
            {
                sonuc.Add(LS);
            }
        }
        return sonuc;
    }


    /*  ***********************************
        Yukarıdaki 8 Metotların Main Metotları
        *********************************** */
    static void Main(string[] args)
    {
        // 1. Soru
        Console.WriteLine("\n*** 1. Soru ***");
        double alan = UcgenAlani();
        Console.WriteLine("Alan: " + alan);
        Console.WriteLine();

        // 2. Soru
        Console.WriteLine("\n*** 2. Soru ***");
        int[] dizi = { 44, 34, 25, 52, 7, 61, 16 };
        int i;
        int max = DizidekiMaxDeger(dizi);
        Console.Write("Dizi: ");
        for (i = 0; i < 7; i++)
        {
            Console.Write(dizi[i] + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("Dizideki En Büyük Değer: " + max);
        Console.WriteLine();

        // 3. Soru
        Console.WriteLine("\n*** 3. Soru ***");
        int pw=3, px=5, pi=3, pj=5, pk=8;
        double py = 3.5, pz = 5.2; 
        int toplam1 = CalculateSum(3, 5);
        double toplam2 = CalculateSum(3.5, 5.2);
        int toplam3 = CalculateSum(3, 5, 8);
        Console.WriteLine("2 int sayı: " + pw + " ve " + px);
        Console.WriteLine("2 int sayı: " + py + " ve " + pz);
        Console.WriteLine("3 int sayı: " + pi + " ve " + pj + " ve" + pk);
        Console.WriteLine("2 int sayının toplamı: " + toplam1);
        Console.WriteLine("2 double sayının toplamı: " + toplam2);
        Console.WriteLine("3 int sayının toplamı: " + toplam3);
        Console.WriteLine();

        // 4. Soru
        Console.WriteLine("\n*** 4. Soru ***");
        Console.Write("Fibonacci sırasını girin: ");
        int sira = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{sira}. Fibonacci sayısı: {Fibonacci5(sira)}");
        Console.WriteLine();

        // 5. Soru
        Console.WriteLine("\n*** 5. Soru ***");
        double ortalama = OrtHes(1.2, 2.3, 3.4, 5.6);
        Console.WriteLine("Sayılar: 1.2, 2.3, 3.4, 5.6");
        Console.WriteLine("Ortalama: " + ortalama);
        Console.WriteLine();

        // 6. Soru
        Console.WriteLine("\n*** 6. Soru ***");
        int toplam = ToplaVeFiltrele(dizi, 5);
        Console.WriteLine("Filtreye Uygun Elemanların Toplamı: " + toplam);
        Console.WriteLine();

        // 7. Soru
        Console.WriteLine("\n*** 7. Soru ***");
        Console.Write("Yaşınızı girin: ");
        int yas = Convert.ToInt32(Console.ReadLine());
        int aradakiyas = YasHesapla(yas);
        Console.Write("18 yaşla aradaki fark: " + aradakiyas);
        if (aradakiyas > 0)
        {
            Console.WriteLine(" kadar büyük");
        }
        else if (aradakiyas < 0)
        {
            Console.WriteLine(" kadar küçük");
        }
        else
        {
            Console.WriteLine(" eşit");
        }
        Console.WriteLine();

        // 8. Soru
        Console.WriteLine("\n*** 8. Soru ***");
        string[] kelimeler = { "seha", "icardi", "osimhen", "gedik", "galatasaray", "fener" };
        List<string> BestenUzunKelimeler = BestenBuyukOlanlariFiltreleme(kelimeler);
        Console.WriteLine("Büyükler: ");
        foreach (string SL in BestenUzunKelimeler)
        {
            Console.WriteLine(SL);
        }
        Console.ReadKey();
    }
}