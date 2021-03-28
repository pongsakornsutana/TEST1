using System;

namespace TTTT
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. The Nim

            int p1 , p2 ,i ,n=100 ;
            
                        Console.Write("The number of boxes in tank a :");
            int a = int.Parse(Console.ReadLine());
                        Console.Write("The number of boxes in tank b :");
            int b = int.Parse(Console.ReadLine());
                        Console.Write("The number of boxes in tank c :");
            int c = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Player :A");
                    Console.Write("No. of the tank :");
                    int T = int.Parse(Console.ReadLine());
                    Console.Write("Number of boxes to be picked out (1 or 2) :");
                    int B = int.Parse(Console.ReadLine());

                    switch (T)
                    {
                        case 1:
                            a = a - B;
                            break;

                        case 2:
                            b = b - B;
                            break;

                        case 3:
                            c = c - B;
                            break;
                    }
                    Console.WriteLine("number of box:{0} {1} {2}", a, b, c);
                }              
                else {
                    Console.WriteLine("Player :B");
                    Console.Write("No. of the tank :");
                    int T = int.Parse(Console.ReadLine());
                    Console.Write("Number of boxes to be picked out (1 or 2) :");
                    int B = int.Parse(Console.ReadLine());

                    switch (T)
                    {
                        case 1:
                            a = a - B;
                            break;
                        case 2:
                            b = b - B;
                            break;
                        case 3:
                            c = c - B;
                            break;
                    }
                    Console.WriteLine("number of box:{0} {1} {2}", a, b, c);
                }
                if(a == 0 && b==0 && c==0)
                {
                    if(i%2==0)
                    Console.WriteLine("Player B win");
                    else
                    {
                        Console.WriteLine("Player A win");
                    }
                    break;
                }
            }
        }
    }
}

