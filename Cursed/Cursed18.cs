using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed18 : ICursed
    {
        public static string Name { get; set; } = "Very concerned programmer";
        public void Curse()
        {
            // Example of real commercial production code (Except 'x >= 0')
            int numToCheck = 42;
            CheckCount(numToCheck);
        }

        private bool CheckCount(int x)
        {
            if ((x > 0) && (x != 0) && (x >= 0))
                return true;
            return false;
        }
    }
}
