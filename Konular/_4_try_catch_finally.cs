using System;

namespace _4_try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {
          try{
              Console.WriteLine("Sayı yazınız :");
              int sayi = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Girmiş olduğunuz sayi {0}",sayi);
          }
          catch(Exception ex){
              Console.WriteLine(ex.Message);
          }
          finally{
              //Optional
          }
          //**********************************

          try{
              int a = int.Parse(null);
          }
          catch(ArgumentNullException ex){
              Console.WriteLine(ex);
          }

          //**********************************

          try{
              int a = int.Parse("test");
          }
          catch(FormatException ex){
              Console.WriteLine(ex);
          }

          //**********************************

          try{
              int a = int.Parse("-200000000000000000000");
          }
          catch(OverflowException ex){
              Console.WriteLine(ex);
          }
        }
    }
}
