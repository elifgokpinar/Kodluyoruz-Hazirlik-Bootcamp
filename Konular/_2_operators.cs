using System;

namespace _2_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            // += -= /= *= şeklinde kullanabiliriz.

            //****************Logical Operators***************
            // || && !
            
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted){
                Console.WriteLine("Perfect");
            }
            if(isSuccess || isCompleted){
                Console.WriteLine("Good");
            }
            if(!isSuccess && isCompleted){
                Console.WriteLine("Bad");
            }

            //****************Relational Operators****************
            //<, >, ==, >=, <=, !=

            int a=1;
            int b=2;

            if(a < b){
                Console.WriteLine("Good");
            }
             if(a > b){
                Console.WriteLine("Bad");
            }

            //****************Arithmetic Operators****************
            // + - / *

            // mod => %
            int result = 19%2; // result 1

        }
    }
}
