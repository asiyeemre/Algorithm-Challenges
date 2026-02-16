using System;

/*
* LeetCode Problem: 9. Palindrome Number
* Link: https://leetcode.com/problems/palindrome-number/
* Zorluk : Easy
* * SORU:
* Verilen sayının Polindrom olup olmadıgını döndürün.
*/
class Program{
public static bool IsPalindrome(int x)
{
    //ADIM 1 : Negatif sayılar palindrom olamaz.
    //Çünkü -121 tersten 121- olur.

    if (x < 0)
    {
        return false;
    }

    //Adım 2 : Sayıyı yazıya çeviriyoruz.
    //Neden? Çünkü sayı üzerinde karakter karakter işlem yapamayız.
    string duzHali = x.ToString();

    //Adım 3: ToCharArray() ile metni karakter dizisine çeviriyoruz.
    //Çünkü stringler "Immutable" yani değiştirelemez olduğu için parçalamamız şart.
    char[] karakterler = duzHali.ToCharArray();

    //Adım 4 : Array.Reverse() ile bu parçaların sırasını tersine çeviriyoruz.
    //Baştaki sona sondaki başa geçer.
    Array.Reverse(karakterler);

    //Adım 5 : Parçalanmış ve ters çevrilmiş karakterleri tekrar birleştiriyoruz.
    //new string() komutu lego parçalarını tekrar bir metin yapar.
    string tersHali = new string(karakterler);

    //Adım 6: Sonuçları kıyaslıyoruz.
    if (duzHali == tersHali)
    {
        return true;
    }
    else
    {
        return false;
    }
}
static void Main(string[] args)
    {
        int sayi1=545;
        int sayi2= -232;
        int sayi3= 10;

        //Sonucları ekrana yazdıralım
            Console.WriteLine($"{sayi1} Palindrom mu? --> " + IsPalindrome(sayi1));
            Console.WriteLine($"{sayi2} Palindrom mu? --> " + IsPalindrome(sayi2));
            Console.WriteLine($"{sayi3} Palindrom mu? --> " + IsPalindrome(sayi3));  
            
            Console.ReadLine();
              }
}