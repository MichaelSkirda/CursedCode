using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed16 : ICursed
    {
        public static string Name { get; set; } = "Cursed indexer";

        public void Curse()
        {
            var cursed = new CursedIndexer(10);

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < cursed.Capacity; j++)
                {
                    Console.Write(cursed[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class CursedIndexer
    {
        public readonly int[] arr;
        public readonly int Capacity;

        private static int i = 0;

        public int this[int index]
        {
            get
            { 
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = index + Cursed.CursedIndexer.i++;
                }
                return arr[index];
            }
        }

        public CursedIndexer(int capacity)
        {
            Capacity = capacity;
            arr = new int[Capacity];

            for(int i  = 0; i < arr.Length; i++)
            {
                arr[i] = capacity;
            }
        }
    }
}
