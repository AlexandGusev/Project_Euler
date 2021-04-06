using System;

namespace Euler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            string str;
            int a = 0;
            int b = 0;
            int ans = 0;
            int gg = 0; // Переменная в которй будем сохранять максимальное значение
            
            
            for(int i = 100; i<1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    c = i * j;
                    str = Convert.ToString(c);
                    int LengthStr = str.Length;
                    if (LengthStr == 5)
                    {
                        if ((str[0] == str[4]) && (str[1] == str[3]))
                        {
                            ans = Convert.ToInt32(str);
                            if (gg>ans)
                            {
                                ans = gg;
                                
                            }

                            
                        }
                    }

                    if (LengthStr == 6)
                    {
                        if ((str[0] == str[5]) && (str[1] == str[4]) && (str[2] == str[3]))
                        {
                            ans = Convert.ToInt32(str);

                             if (gg > ans)
                             {
                                 ans = gg;
                                
                            }

                           
                        }
                    }
                    a = i;
                    b = j;
                }
                gg = ans;
                
            }
            Console.WriteLine(ans);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
