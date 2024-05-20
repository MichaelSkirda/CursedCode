using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal sealed class Cursed15 : ICursed
    {
        public static string Name { get; set; } = "PI by random";

        public void Curse()
        {
            double PI = CalcPI(100000000);
            Console.WriteLine(PI);
        }

        private static double CalcPI(long iteration)
        {
            double circleRadius = 1;

            double inCircle = 0;
            double inSquare = 0;

            Random random = new Random();

            double x;
            double y;

            for (long i = 0; i < iteration; i++)
            {
                x = (double)random.Next(0, 1000000000) / 1000000000d;
                y = (double)random.Next(0, 1000000000) / 1000000000d;

                if (x * x + y * y > circleRadius * circleRadius)
                    inSquare++;
                else
                    inCircle++;
            }

            double total = inCircle + inSquare;

            double PI = 4 * inCircle / total;


            return PI;
        }
    }
}

