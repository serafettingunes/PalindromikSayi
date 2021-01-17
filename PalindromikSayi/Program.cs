using System;
using System.Collections;
using System.Collections.Generic;

namespace PalindromikSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            string TersiniAl = "";
            List<int> PalindromikSayilar = new List<int>();
            string[] sayilar = new string[10000];
            for (int i = 1; i <=10000 ; i++)
            {
                for (int j = 0; j <i.ToString().Length ; j++)
                {
                  TersiniAl=  i.ToString().Substring(j, 1)+TersiniAl;
                    sayilar[i - 1] = TersiniAl;

                    
                }
                
                TersiniAl = "";

                if (i.ToString()==sayilar[i-1])
                {
                    Console.WriteLine(sayilar[i-1]);
                }
            }    
        }
    }
}
