using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed7 : ICursed
    {
        public static string Name { get; set; } = "Sad bool reverse";
        public void Curse()
        {

        }

        private bool ReverseBool(bool @bool)
        {
            if (@bool == true)
                return false;
            else if(@bool == false)
                return true;
            else
                return ReverseBool(@bool);
        }
    }
}
