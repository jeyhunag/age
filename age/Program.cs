using System;

namespace age
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 1;
            int val2 = 100;
            for (int i = val1; i <= val2; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                }

            }
            
        }
    }
}
