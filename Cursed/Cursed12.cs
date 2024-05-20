using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;


namespace cursed.Cursed
{
    internal class Cursed12 : ICursed
    {

        public static string Name { get; set; } = "Ternarygod";

        public void Curse()
        {
            string x = "123";

            bool isValid = (!(x == "123" ? false : true == false || (false == true ? false : true)) == false ? 1 + 2 : 0 + 4) == 4 ? true : false;

            Console.WriteLine(isValid);
        }
    }
}
