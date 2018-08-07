using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //聖誕樹for迴圈
            {
                
                int i ,j ,l;
                string k;
                Console.Write("請輸入聖誕樹層數:");
                k=Console.ReadLine();
                l=int.Parse(k);
                for (i = 1; i <= 5; i++)
                {
                    for (int x = 5- i ; x > 0; x--)
                    {
                        Console.Write(" ");
                    }
                    for (j = 1; j <= i * 2-1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                 
            }

            ///聖誕樹老師版本
            {
                
                int star,space;
                space = 4;
                star = 1;
                int t = 1;
                Console.WriteLine("開始");
                while (t<=5)
                {
                    int i = 1;
                    while(i<=space)
                    {
                        Console.Write(" ");
                        i++;
                    }
                    space -= 1;
                    i = 1;
                    while(i<=star)
                    {
                        Console.Write("*");
                        i++;
                    }
                    star += 2;
                    Console.Write("\n");
                    t = t + 1;
                }
                Console.WriteLine("結束");
                
            }


            //聖誕樹while迴圈
            {
                
                int i=1, j, l, x;
                string k;
                Console.Write("請輸入聖誕樹層數:");
                k = Console.ReadLine();
                l = int.Parse(k);
                while(i<l)
                {
                    x = l - i;
                    while (x > 0)
                    {
                        Console.Write(" ");
                        x--;
                    }
                    j = 1;
                    while (j <= i*2-1)
                    { 
                        Console.Write("*");
                        j++;
                    }
                    Console.Write("\n");
                    i++;
                }
                
            }
        }
    }
}
