using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed2 : ICursed
    {
        public static string Name { get; set; } = "Unsafe reverse";

        public void Curse()
        {
            string s = "Strings are immutable!";

            Reverse(s);

            Console.WriteLine("Strings are immutable!");
			// Output is interesting

			Console.WriteLine("\nTry to restart this!");
		}

		private void Reverse(string s)
        {
            unsafe
            {

                for (int i = 0; i < s.Length / 2; i++)
                {
                    fixed (char* c = s)
                    {
                        char tmp = s[i];
                        c[i] = c[s.Length - i - 1];
                        c[s.Length - i - 1] = tmp;
                    }
                }

            }

        }
    }
}
