using System;

namespace hw3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
             exercise1();
             exercise2();
             exercise3();
             exercise4();
             exercise5();
             exercise6();
             exercise7();
             exercise8();
        }

        public static void exercise1()
        {
            Console.WriteLine("\n\nKlavyeden girilen metnin kaç kelimeden oluştuğunu bulan program");
            Console.Write("Metin yazınız : ");
            string text = controlEmptyInput();
            text = text.Trim();
            string[] words = text.Split(' ');
            Console.WriteLine("{0} kelimeden oluşmaktadır.",words.Length);
        }
        public static void exercise2()
        {
            Console.WriteLine("\n\nVerilen bir karakter dizininin substring() metodunu kullanarak string içerisinde arama yapan ve kaç defa geçtiğini bulan program.");
            Console.Write("Metin yazınız : ");
            string text = controlEmptyInput(); // Input should not be empty
            Console.Write("\nArama yap : ");
            string search = controlEmptyInput();
            int searchLen = search.Length;
            int count = 0;

            for(int i = 0; i<=text.Length - searchLen; i++)
            {
                if(text.Substring(i,searchLen) == search)
                {
                    count++;
                }
            }

            Console.WriteLine("{0} kere {1} geçmektedir.", count,search);
        }
        public static void exercise3()
        {
            Console.WriteLine("\n\nGirilen sayı çift ise yarısını , tek ise 2 katını alarak ekrana yazdıran program");
            Console.Write("Sayı giriniz : ");
            int num = controlInputFunc();
            int result = (num % 2 == 0) ? num / 2 : num * 2;
            Console.WriteLine(result);
        }
        public static void exercise4()
        {
            Console.WriteLine("\n\nKlavyeden girilen bir sayının faktöriyelini alan program.");
            Console.Write("Sayı giriniz : ");
            int num = controlInputFunc(); //Input should be int
            int result = 1;
            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        public static void exercise5()
        {
            Console.WriteLine("\n\n1’den başlayıp 200’e kadar klavyeden girilen sayıya bölünen kaç adet sayı olduğunu veren program.");
            Console.Write("Sayı giriniz : ");
            int num = controlInputFunc(true); // true parameter means "Check the input whether zero or not. If input is zero, ask again the user."
            Console.WriteLine("{0} ile bölünen sayılar",num);
            for (int i = 1; i <= 200; i++)
            {
                if(i%num == 0)
                {
                    Console.Write("{0} ",i);
                }
            }
        }
        public static void exercise6()
        {
            Console.WriteLine("\n\nVerilen bir kişi adını bir dizide arayan ve bulunup bulunamadığını belirten program. (Diziyi siz girebilirsiniz ya da kullanıcıdan alabilirsiniz.)");
            string[] nameArray = { "Elif", "Feyza", "Ceyda", "Mert", "Aslıhan", "Deniz", "Kenan", "Gürol", "Bade", "Soner", "Meral" };
            Console.WriteLine("İsim listesi :");
            foreach(string name in nameArray)
                Console.Write("{0} ", name);

            Console.Write("\nKişi ara : ");
            string text = controlEmptyInput();
            int result = Array.IndexOf(nameArray, text);
            string message = (result == -1) ? "İsim bulunamadı." : "İsim bulundu";
            Console.WriteLine(message);
        }
        public static void exercise7()
        {
            Console.WriteLine("\n\nDerece olarak verilen sıcaklığı Fahrenheita çeviren program.");
            Console.Write("Derece giriniz : ");
            int num = controlInputFunc();
            double fahrenheit = (num * 1.8) + 32;
            Console.WriteLine("{0} derece {1} fahrenheit", num, Math.Round(fahrenheit, 2));
        }
        public static void exercise8()
        {
            Console.WriteLine("\n\nGirilen string ifadede boşluk karakterine kadar olan kısmı yazdıran program.");
            Console.Write("Metin yazınız : ");
            string text = controlEmptyInput();
            string[] words = text.Split(' ');
            Console.WriteLine("Sonuç : {0}", words[0]);
        }

        // Input should not be empty in some cases.
        public static string controlEmptyInput()
        {
            string tempStr = Console.ReadLine();
            tempStr = tempStr.Trim();
            tempStr = (tempStr == "") ? takeInputAgainStr() : tempStr;
            return tempStr;
        }
        public static string takeInputAgainStr()
        {
            string tempStr;
            while (true)
            {
                Console.Write("Lütfen boş bırakmayın : ");
                tempStr = Console.ReadLine();
                tempStr = tempStr.Trim();
                if (tempStr != "")
                {
                    break;
                }
            }
            return tempStr;
        }
        public static int controlInputFunc(bool isZeroControl = false)
        {
            string tempStr = Console.ReadLine();
            bool controlInput = Microsoft.VisualBasic.Information.IsNumeric(tempStr); //input should be int, otherwise ask the user again
            int num = 0;
            if(isZeroControl)
            {
                num = (controlInput == false || Convert.ToInt32(tempStr) == 0) ? takeInputAgain(isZeroControl) : Convert.ToInt32(tempStr);
            }
            else
            {
                num = (controlInput == false) ? takeInputAgain() : Convert.ToInt32(tempStr);
            }
            return num;
        }
        //If user enters string but wanted input is int or not zero
        public static int takeInputAgain(bool isZeroControl = false)
        {
            string input;
            bool controlInput;
            while (true)
            {
                string message = (isZeroControl) ? "Lütfen 0'dan farklı bir sayı giriniz : " : "Lütfen Sayı giriniz : ";
                Console.Write(message);
                input = Console.ReadLine();
                controlInput = Microsoft.VisualBasic.Information.IsNumeric(input);
                if (controlInput)
                {   
                    if((isZeroControl && Convert.ToInt32(input) != 0) || !isZeroControl)
                    {
                        break;
                    }
                }
            }
            return Convert.ToInt32(input);
        }
    }
}
