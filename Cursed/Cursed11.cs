using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed11 : ICursed
    {

        public static string Name { get; set; } = "Bogosort";

        public void Curse()
        {
            byte[] data = new byte[] { 7, 10, 3, 5, 9, 3, 15, 22, 4, 9, 11, 0 };

            foreach(byte b in data)
                Console.Write(b + " ");

            Console.WriteLine("\n\nSorting...\n");

            SortO1(data, new Random());

            foreach (byte b in data)
                Console.Write(b + " ");
        }

        

        private void SortO1(byte[] data, Random random)
        {
            while(!IsSorted(data))
            {
                Shuffle(data, random);
            }
        }

        private void Shuffle(byte[] data, Random random)
        {
            int n = data.Length;
            while (n > 1)
            {
                int k = random.Next(n--);
                byte temp = data[n];
                data[n] = data[k];
                data[k] = temp;
            }
        }

        private bool IsSorted(byte[] data)
        {
            if (data.Length <= 1)
                return true;

            for(int i = 1; i < data.Length; i++)
            {
                if (data[i - 1] > data[i])
                    return false;
            }

            return true;
        }

    }
}
