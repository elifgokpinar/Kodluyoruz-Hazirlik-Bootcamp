using System;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //********Alıştırma 1********
            Console.WriteLine("\n1 – 1.000.000 Arasındaki Asal Sayıları Listeleme");

            for (int num = 2; num <= 100; num++)
            {
                int control = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        control = 1;
                        break;
                    }
                }
                if (control == 0)
                {
                    Console.Write("{0} ", num);
                }
            }


            //********Alıştırma 2********
            Console.WriteLine("\n\n1-N arası 3 e ve 7’ye Tam Bölünen Sayıları Listeleme");
            Console.Write("Sayı giriniz : ");

            int num1 = controlInputFunc();//Input should be int
            int count = 1;
            while (num1 >= count)
            {
                if (count % 3 == 0 && count % 7 == 0)
                {
                    Console.Write("{0} ", count);
                }
                count++;
            }


            //********Alıştırma 3********
            Console.WriteLine("\n\nDiziyi Alfabetik Olarak Sıralama (Kullanıcının gireceği kelimelerden oluşan diziyi alfabetik olarak sıralama)");
            Console.Write("Kaç kelime yazmak istiyorsunuz? : ");
            count = controlInputFunc(); //Input should be int
            string[] words = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("{0}. kelimeyi girin : ", i + 1);
                words[i] = Convert.ToString(Console.ReadLine());
            }
            Array.Sort(words);
            Console.WriteLine("Sorted words:");
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", words[i]);
            }


            //********Alıştırma 4********
            Console.WriteLine("\n\nGirilen Metindeki Sesli Harfleri Bulan Program");
            Console.Write("Metin yazınız : ");
            string text = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' }; // Turkish alphabet vowels
            char[] charArray = text.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (charArray[i] == vowels[j])
                    {
                        Console.Write(charArray[i]);
                    }
                }
            }


            //********Alıştırma 5********
            Console.WriteLine("\n\nKullanıcıdan 10 adet sayı alarak bu sayıların toplamını ekranda gösteren program");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}.sayı : ", i + 1);
                num1 = controlInputFunc(); //Input should be int
                sum += num1;
            }
            Console.WriteLine("Toplam : {0}", sum);


            //********Alıştırma 6********
            Console.WriteLine("\n\nBilgisayarın rastgele tuttuğu 10 sayıdan çift ve tek olanların sayısını gösteren program");
            count = 0;
            int even = 0;
            int odd = 0;
            int temp = 0;
            Random rnd = new Random();
            while (count < 10)
            {
                temp = rnd.Next();
                if (temp % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
                Console.Write("{0} ", temp);
                count++;
            }
            Console.WriteLine("\nEven numbers count: {0}, Odd numbers count: {1} ", even, odd);


            //********Alıştırma 7********
            Console.WriteLine("\n\nKullanıcının girdiği metni kullanıcının girdiği sayıda ekranda yazdıran Program");
            Console.Write("Metin yazınız : ");
            text = Console.ReadLine();
            Console.Write("Kaç kere yazılsın : ");
            count = controlInputFunc(); //Input should be int
            while (count > 0)
            {
                Console.WriteLine(text);
                count--;
            }
        }
        //Controls input whether is number or not. If input is string, run the takeInputAgain function in order to take input again
        public static int controlInputFunc()
        {
            String tempStr = Console.ReadLine();
            bool controlInput = Microsoft.VisualBasic.Information.IsNumeric(tempStr); //input should be int, otherwise ask the user again
            int num = 0;
            num = (controlInput == false) ? takeInputAgain() : Convert.ToInt32(tempStr);
            return num;
        }
        //If user enters string but wanted input is int
        public static int takeInputAgain()
        {
            string input;
            bool controlInput;
            while (true)
            {
                Console.Write("Lütfen Sayı giriniz : ");
                input = Console.ReadLine();
                controlInput = Microsoft.VisualBasic.Information.IsNumeric(input);
                if (controlInput)
                {
                    break;
                }
            }
            return Convert.ToInt32(input);
        }
    }
}
