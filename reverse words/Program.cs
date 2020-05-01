using System;

namespace reverse_words
{
    class Program
    {
        //reversed words
        public static void reversed(string before)
        {
            string after = "";
            int x = before.Length - 1;
            while (x >= 0)
            {
                after = after + before[x];
                x--;
            }
            Console.WriteLine("the string before reversed is: " + before + " \nthe string after reversed is: " + after);
        }
        static void Main(string[] args)
        {
            //reversed words
            string n = "amr";
            reversed(n);
            Console.ReadKey();
        }
    }
}