using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal interface ICursed
    {
        public static string? Name { get; set; }
        void Curse();
    }

    internal abstract class ______ : ICursed {
        public static string Name { get; set; } = "UnderscoreSharp";
        abstract public void Curse();
	}
}
