using System;

namespace _8_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take input from user
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            //Prints average
            while(sayac <= sayi){
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayac);
            
            //Print letters between a and z
            char character = 'a';
            while(character < 'z'){
                Console.Write(character);
                character++;
            }

            //FOREACH 
            Console.WriteLine("*******FOREACH********");
            string[] arabalar= {"Ford", "Nissan"};

            foreach (var araba in arabalar){
                Console.WriteLine(araba);
            }
        }
    }
}
