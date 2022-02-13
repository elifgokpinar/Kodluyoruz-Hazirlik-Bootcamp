using System;

namespace _1_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;    // 1 byte
            sbyte c = 5;   // 1 byte

            short s = 5;   // 2 byte
            ushort us = 5; // 2 byte

            Int16 i16 = 2; // 2 byte
            int i = 2;     // 4 byte
            Int32 i32 = 2; // 4 byte
            Int64 i64 = 2; // 8 byte

            uint ui = 2;    // 4 byte
            long il = 4;    // 8 byte
            ulong ul = 4;   // 8 byte

            //real numbers
            float f = 4;    // 4 byte
            double d = 5;   // 8 byte
            decimal de = 5; // 16 byte

            char ch = '2';  //2 byte
            string str= "elif";

            bool b1 = true;

            DateTime dt = DateTime.Now; 
            Console.WriteLine(dt); //prints current date and time

            object o1 = 2; //keeps all types



        }
    }
}
