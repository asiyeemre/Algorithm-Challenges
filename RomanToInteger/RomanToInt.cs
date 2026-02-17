/*
         * LEETCODE SORU 13: Roman to Integer
         * Zorluk: Easy
         * * SORU:
         * Roma rakamlarını (String) normal sayılara (Integer) çeviren bir fonksiyon yazın.
         * Semboller: I=1, V=5, X=10, L=50, C=100, D=500, M=1000
         * * KURAL:
         * - Genelde büyük sayı önce gelir (VI = 6).
         * - Eğer küçük sayı büyük sayının ÖNÜNE gelirse çıkarma yapılır (IV = 4).
         */

using System;
using System.Collections.Generic;
//Roma rakamını tam sayıya çeviren method.
class Program{
public static int RomanToInt(string s)
    {
        //1.Adım: Sözlüğü oluştururuz.(hangi harfin int değeri ne ?)
        Dictionary<char,int> romaRakamlari = new Dictionary<char, int>()
        {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
        };

        int toplam=0;

        //2.Adım : Harfleri tek tek gezeriz.
        for(int i =0; i<s.Length ; i++)
        {
            //O anki harfin değerini alalım.
            int suankiRakam=romaRakamlari[s[i]];

            //3.Adım : Bir sonraki harfe bakacağız
            //Kural: Eğer su anki harften sonra bir harf varsa ve o suanki harften büyükse toplamdan çıkarıırız.
            if(i+1<s.Length && suankiRakam<romaRakamlari[s[i+1]])
            {
                toplam -= suankiRakam;
            }
            else
            {
                toplam +=suankiRakam;
            }
        }

        return toplam;
    }
          //test alanı
        static void Main(string[] args)
        {
            Console.WriteLine("--- Roma Rakamı Çevirici Testi ---");

            string ornek1 = "III";      // Beklenen: 3
            string ornek2 = "LVIII";    // Beklenen: 58
            string ornek3 = "MCMXCIV";  // Beklenen: 1994

            Console.WriteLine($"Giriş: {ornek1} -> Sonuç: {RomanToInt(ornek1)}");
            Console.WriteLine($"Giriş: {ornek2} -> Sonuç: {RomanToInt(ornek2)}");
            Console.WriteLine($"Giriş: {ornek3} -> Sonuç: {RomanToInt(ornek3)}");

            Console.ReadLine();
            
        }
}