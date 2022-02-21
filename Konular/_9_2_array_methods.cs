using System;

namespace _9_2_array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("****Sırasız Dizi*****");
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("****Sıralı Dizi*****");
            Array.Sort(sayiDizisi);
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("****Clear Methodu*****");
            Array.Clear(sayiDizisi,2,2);
            //Makes 2 elements 0 from 2nd index.
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("****Reverse Methodu*****");
            Array.Reverse(sayiDizisi);
            //Reverse the array elements.
            foreach(var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("****IndexOf Methodu*****");
            Array.IndexOf(sayiDizisi,23);
            //Gives index of element 23

            Console.Write("****Resize Methodu*****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
        }
    }
}
