using System;

namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.alıştırma
            Console.Write("Adınız : ");
            String name = Console.ReadLine();
            Console.Write("Soyadınız : ");
            String surname = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz {0} {1}",name, surname);

            //2.alıştırma
            Console.Write("\nToplama\n1.sayı : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayı : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} ve {1} sayısının toplamı {2}", num1, num2, num1+num2);

            //3.alıştırma
            Console.Write("\nDikdörtgen\nKısa kenar : ");
            int shortEdge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun kenar : ");
            int longEdge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alan {0}", shortEdge*longEdge);
            Console.WriteLine("Çevre {0}", (shortEdge + longEdge)*2);

            //4.alıştırma
            Console.Write("\nTek mi çift mi?\nSayı : ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((num3 % 2 == 0) ? "Çift" : "Tek");

            //5.alıştırma
            Console.Write("\nGirilen sayı 0-100 arasında mı?\nSayı : ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((0<=num4 && num4 <= 100) ? "0-100 arasında" : "0-100 arasında değil");

            //6.alıştırma
            Console.Write("\nVücut kitle endeksi hesapla\nKilo(kg) : ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Boy(cm) : ");
            double height = Convert.ToInt32(Console.ReadLine());
            double BMI = weight / ((height/100) * (height/100));
            Console.WriteLine("Vücut kitle endexi : {0}", BMI.ToString("0.00"));

            //7.alıştırma
            Console.Write("\nCümledeki harf sayısı\nCümle : ");
            String sentence = Console.ReadLine();
            int count = 0;
            foreach(var letter in sentence)
            {
                if(letter!=' ' && letter != '.' && !(48<=letter && letter <=57))
                {
                    count++;
                }
            }
            Console.Write("Cümlede {0} harf vardır.", count);
        }
    }
}
