using System;

namespace _8_if_else_ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get current hour
            int time = DateTime.Now.Hour;
            //IF ELSE
            if(time>=6 && time < 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi Günler!");
            }
            else
            {
                Console.WriteLine("İyi geceler!");
            }

            //TERNARY
            string sonuc = time <= 18 ? "İyi Günler!" : "İyi Geceler!";
            sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "İyi Günler!" : "İyi Geceler!";
            Console.WriteLine(sonuc);
        }
    }
}
