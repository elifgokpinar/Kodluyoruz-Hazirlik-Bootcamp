using System;

namespace _3_conversions
{
    class Program
    {
        static void Main(string[] args)
        {
          //*****Implicit Conversion***** 
          //Düşük kapasiteli bir tipin kendinden büyük kapasiteli bir tipe dönüşmesidir.
          byte a=1; // 1 byte
          int b=4;  // 4 byte
          b=a;

          string isim = "elif";
          char ch = 'g';
          object obj = isim +" "+ch;


          //*****Explicit Conversion*****
          //Büyük kapasiteli bir tipin kendinden düşük kapasiteli bir tipe dönüşmesidir.
          //Veri kaybı olabilir.
          //Convert, Parse kullanıyoruz.

          int x = 12;
          byte y = (byte)x;

          string str = 12.5f.ToString();

          //Convert
          string num1="10";
          string num2="10.2";
          int result = Convert.ToInt32(num1);
          
          //Parse
          int result2 = Int32.Parse(num1);
          double result3 = Double.Parse(num2);
        }
    }
}
