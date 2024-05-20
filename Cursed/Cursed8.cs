using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed8 : ICursed
    {
        public static string Name { get; set; } = "Horror with bool";

        public void Curse()
        {
            Console.WriteLine("Write anything: ");
            string str = Console.ReadLine()!;

            LogMessage(str, true);
            LogMessage(str, false);
            //LogMessage(str, ...);
        }

        private void LogMessage(string str, bool isUpperCase)
        {
            if (isUpperCase == true)
            {
                Console.WriteLine(str.ToUpper());
            }
            else if (isUpperCase == false)
            {
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("...");
            }
        }
    }
}
