using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] array = { 4, 5, 6, 7 };
            int EvenNumber = 0;
            PrintArrayItem( array );
        }
        static void PrintArrayItem(int[] array)
        {

            foreach (var item in array)
            {
                if (item % 2 == 0 )
                {
                    Console.WriteLine(item);
                }
               
            }
        }
           
    }
}
