using cursed.Cursed;
using System;
using System.Linq;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;


internal class Program
{
    public static void Main()
    {
        // Call neccessary method
        //new Cursed9().Curse();

        // Or use menu
        CursedCodeMenu();
    }

    private static void CursedCodeMenu()
    {
        while (true)
        {


            var iType = typeof(ICursed);

            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => iType.IsAssignableFrom(p) && p.IsInterface == false && p.IsAbstract == false)
                .OrderBy(x => x.Name.Length)
                    .ThenBy(x => x.Name)
                .ToList();

            for (int i = 0; i < types.Count(); i++)
            {
                Console.WriteLine($"{i + 1}.){new string(' ', types.Count().ToString().Length - (i + 1).ToString().Length + 1)}|  {types[i].Name}. " + (types[i]?.GetProperty("Name")?.GetValue(null, null) ?? "Unknown"));
            }

            int input;
            while (true)
            {
                Int32.TryParse(Console.ReadLine(), out input);

                if (input >= 1 && input <= types.Count)
                {
                    break;
                }
            }

            Console.Clear();

            var cursedType = types[input - 1];
            var cursedInstance = (ICursed)Activator.CreateInstance(cursedType)!;

            cursedInstance.Curse();

            Console.WriteLine("\n\nView sources!");
            Console.WriteLine("\nPress any button to restart");
            Console.ReadKey();
        }
    }
}