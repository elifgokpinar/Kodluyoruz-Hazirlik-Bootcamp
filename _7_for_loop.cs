using System;

namespace _7_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the odd number
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for(int i = 1; i<=sayac; i++){
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }

            //Print the sum of odd and even numbers seperately between 1 and 1000
            int tekToplam=0;
            int ciftToplam=0;
            for(int i = 0; i<=1000; i++){
                if(i%2 == 1){
                    tekToplam += i;
                }
                else{
                    ciftToplam += i ;
                }
            }
            Console.WriteLine("Tek toplam: "+tekToplam);
            Console.WriteLine("Çift toplam: "+ciftToplam);
            
        }
    }
}
