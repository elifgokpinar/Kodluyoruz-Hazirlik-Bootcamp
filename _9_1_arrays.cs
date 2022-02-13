using System;

namespace _9_1_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define array
            string[] renkler = new string[5];
            
            string[] hayvanlar = {"Kedi", "Köpek","Kuş", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Assign variable to array element
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //For loop
            Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
            int uzunluk = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[uzunluk];

            for(int i = 0; i<uzunluk; i++){
                Console.Write("Lütfen {0}. sayısı giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach( var sayi in sayiDizisi){
                toplam += sayi;
            }
            Console.Write("Ortalama :"+ toplam/uzunluk);
        }
    }
}
