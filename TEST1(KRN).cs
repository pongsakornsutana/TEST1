using System;

namespace TTTT
{
    class Program
    {
        static void Main(string[] args)
        {

            //ข้อ2คูณร่วมน้อย

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x=0;
            int y=0;
            x = a;
            y = b;

            while (x != y)
                    
            {
                if (x < y)
                {
                    x = x + a;

                }
                else
                {
                    y = y + b;
                }  
            }
            Console.Write("{0}", x);
           
        }
    }
}

