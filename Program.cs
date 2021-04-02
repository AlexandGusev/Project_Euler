using System;

namespace Eiler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 0;

            for (int i = 0; i<1000; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    a += i;
                }
            }

            Console.WriteLine(a);
        }
    }
}
