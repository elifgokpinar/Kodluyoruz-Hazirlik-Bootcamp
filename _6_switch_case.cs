using System;

namespace _6_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get current month order
            int month = DateTime.Now.Month;

            //SWITCH CASE - print current month
            switch(month){

                case 1: Console.WriteLine("Ocak ayındasınız."); break;
                case 2: Console.WriteLine("Şubat ayındasınız."); break;
                case 3: Console.WriteLine("Mart ayındasınız."); break;
                case 4: Console.WriteLine("Nisan ayındasınız."); break;
                case 5: Console.WriteLine("Mayıs ayındasınız."); break;
                case 6: Console.WriteLine("Haziran ayındasınız."); break;
                case 7: Console.WriteLine("Temmuz ayındasınız."); break;
                case 8: Console.WriteLine("Ağustos ayındasınız."); break;
                case 9: Console.WriteLine("Eylül ayındasınız."); break;
                case 10: Console.WriteLine("Ekim ayındasınız."); break;
                case 11: Console.WriteLine("Kasım ayındasınız."); break;
                case 12: Console.WriteLine("Aralık ayındasınız."); break;
            }

            //SWITCH CASE - print current season according to month

            switch(month){
                case 12:
                case 1:
                case 2: Console.WriteLine("Kış mevsimi."); break;
                case 3:
                case 4:
                case 5: Console.WriteLine("İlkbahar mevsimi."); break;
                case 6:
                case 7:
                case 8: Console.WriteLine("Yaz mevsimi."); break;
                case 9:
                case 10:
                case 11: Console.WriteLine("Sonbahar mevsimi."); break;
            }

            
        }
    }
}
