using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed1 : ICursed
    {
        public static string Name { get; set; } = "Index funny";

        public void Curse()
        {
            var foo = new int[] { 2, 4, 6, 8 };

            var a = foo[((int)~(uint.MaxValue - 1)! + (^(..).Start.Value).Value)..^(^(..).End.Value).Value];

            foreach(var x in a)
                Console.WriteLine(x);
        }
    }
}
