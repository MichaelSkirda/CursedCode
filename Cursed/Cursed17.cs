using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed17 : ICursed
    {
        public static string Name { get; set; } = "Comparing ints without logic operators";

        public void Curse()
        {
            // Any 2 nums. Compare x and y
            int x = 19;
            int y = 18;

            // Must have const
            const int z = 42;

            try
            {
                int ix = z / (x - y); 
                try
                {
                    _ = ix / (x - y + Math.Abs(y - x));
                    Console.WriteLine("X greater than Y");
                }
                catch
                {
                    Console.WriteLine("X lower than Y");
                }
            }
            catch
            {
                Console.WriteLine("X equals Y");
            }
        }

    }
}
