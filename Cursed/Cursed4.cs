using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed.UselessUsing
{
    internal class Cursed4 : ICursed
    {
        public static string Name { get; set; } = "Useless namespace for useless using";

        public void Curse()
        {
            cursed.Cursed.UselessUsing.Cursed4.DoNothing();
        }

        private static void DoNothing()
        {
            // Am I do nothing?
            // Yes I am
        }
    }
}
