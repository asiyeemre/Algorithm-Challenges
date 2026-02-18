using System;

namespace AlgoritmaCalismalari
{
    class Program
    {
        /*
         * LEETCODE SORU 14: Longest Common Prefix (En Uzun Ortak Önek)
         * Zorluk: Easy
         * * SORU:
         * Verilen kelime listesindeki (string array) kelimelerin BAŞINDAKİ 
         * ortak harfleri bulun.
         * Örnek: ["flower", "flow", "flight"] -> "fl"
         */

        // 1. METOT: SORUYU ÇÖZEN KISIM 
        public static string LongestCommonPrefix(string[] strs)
        {
            // GÜVENLİK: Liste boşsa işlem yapma, boş dön.
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            // STRATEJİ: İlk kelimeyi "Lider" (Prefix) ilan ediyoruz.
            // Diğerlerine uymadıkça bunu kısaltacağız (Budama Yöntemi).
            string prefix = strs[0];

            // Diğer kelimeleri (1. sıradan başlayarak) tek tek geziyoruz.
            for (int i = 1; i < strs.Length; i++)
            {
          
                // Soru: "Sıradaki kelime (strs[i]), benim prefix'imle BAŞLIYOR MU?"
                // IndexOf 0 verirse "Evet başlıyor" demektir. 0 değilse "Hayır" demektir.
                while (strs[i].IndexOf(prefix) != 0)
                {
                
                    // Uymadığı sürece prefix'in sonundan bir harf kesiyoruz.
                    // (0, Length - 1) demek: Baştan başla, son harfi alma demektir.
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // Eğer elinde hiçbir şey kalmadıysa, ortak harf yok demektir.
                    if (string.IsNullOrEmpty(prefix))
                    {
                        return "";
                    }
                }
            }

            return prefix;
        }

        // 2. METOT: TEST ALANI (MAIN)
        static void Main(string[] args)
        {
            Console.WriteLine("--- En Uzun Ortak Önek Testi ---");

            // Test 1: Ortak harfler var
            string[] liste1 = { "flower", "flow", "flight" };
            Console.WriteLine($"Liste: flower, flow, flight -> Sonuç: '{LongestCommonPrefix(liste1)}'");

            // Test 2: Ortak harf yok
            string[] liste2 = { "dog", "racecar", "car" };
            Console.WriteLine($"Liste: dog, racecar, car    -> Sonuç: '{LongestCommonPrefix(liste2)}'");

            // Test 3: Kendimizden bir örnek
            string[] liste3 = { "masa", "masal", "maske" };
            Console.WriteLine($"Liste: masa, masal, maske   -> Sonuç: '{LongestCommonPrefix(liste3)}'");

            Console.ReadLine();
        }
    }
}