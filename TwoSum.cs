/*
* LeetCode Problem: 1.Two Sum
* Link: https://leetcode.com/problems/two-sum/
* Zorluk : Easy
* * SORU:
* Bir sayı dizisi ve bir hedef sayı(target) veriliyor.
* Toplamları hedef sayıyı veren iki sayının indekslerini döndürün.
*/

using System;
using System.Collections.Generic;

public class Solution {
    /* * ------------------------------
    * Çözüm 1 : Brute Force Yöntemi
    *-----------------------------------
    * Mantık: İç içe iki döngü kullanrak her sayıyı diğer tüm sayılarla toplar.
    * * Zaman Karmaşıklığı
    * Neden? Çünkü dizi büyüdükçe işlem sayısı karesi kadar artar.
    * * KOD (Referans için yorum satırı olarak bırakılmmıştır.):
    * public int[] TwoSum_BruteForce(int[] nums, int target){
        for(int i=0; i < nums.Length; i++){
           //j=i+1 ile başlar çünkü aynı sayıyı kendisiyle toplayamayız.
           for(int j = i+1; j< nums.Length; j++){
               if(nums[i]+nums[j]==target){
                   return new int[] {i,j};
               }
           
           }
        
        
        }

        return new int[0];
    
    }
    */

    /* * ------------------------------------------
    * Çözüm 2: Dictionary Yöntemi - (AKTİF ÇÖZÜM)
    *-----------------------------------------------
    * Mantık: Bir sayıyı kontrol ederken, bizi hedefe götürecek "eşini" (aranan) 
    * hafızada (Dictionary) ararız. Tek seferde buluruz.
    * Neden ? Diziyi sadece 1 kez döneriz.
    */

    public int[] TwoSum(int[] nums, int target){
        //Key: Sayı, Value: İndeks
        Dictionary<int,int>numMap = new Dictionary<int,int>();

        for(int i = 0 ; i < nums.Length; i++){
            int currentNum = nums[i];
            int complement = target - currentNum; //Aranan sayı (Ruh eşi)

            //Aranan sayı daha önce sozlüğe eklendi mi ?
            if(numMap.ContainsKey(complement)){
                return new int[] {numMap[complement], i};
            }

            //Eklenmediyse şu anki sayıyı sözlüğe kaydet.
            if(!numMap.ContainsKey(currentNum)){
                numMap.Add(currentNum,i);
            }
        }

        return new int[0];
    }
}