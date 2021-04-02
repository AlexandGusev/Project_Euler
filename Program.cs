using System;

namespace Euler__2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найдите сумму всех четных элементов ряда Фибоначчи, которые не превышают четыре миллиона.

            
            ulong c = 0;
            ulong a = 1;
            ulong b = 2;
            ulong ans = 2;

            /*a
                b
                c = a+b
                a=b
                b=c*/


            while (c < 4000000)
            {
                c = a + b;
                a = b;
                b = c;
                if (c%2==0)
                {
                    ans += c;
                }
            }
            
            Console.WriteLine(ans);
        }
    }
}
