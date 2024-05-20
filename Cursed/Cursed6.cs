using System;
using cursed.Cursed.UselessUsing;
using cursed.Cursed.UselessUsing;

namespace cursed.Cursed
{
    internal class Cursed6 : ICursed
    {
        public static string Name { get; set; } = "Funny brackets =)";

        public void Curse()
        {
            byte[] arr = new byte[] { 9, 12, 2, 6, 3, 3 };
            BubbleSortByteArray(arr);
            foreach (byte b in arr)
            {
                Console.Write(b + " ");
            }
        }

        public void BubbleSortByteArray(byte[] arrayOfBytes)            {
            bool swapped                                                ;
            do                                                          {
                swapped = false                                         ;
                for (int i = 0; i < arrayOfBytes.Length - 1; i++)       {
                    if (arrayOfBytes[i] > arrayOfBytes[i + 1])          {
                        byte temp = arrayOfBytes[i]                     ;
                        arrayOfBytes[i] = arrayOfBytes[i + 1]           ;
                        arrayOfBytes[i + 1] = temp                      ;
                        swapped = true                                  ;}}}
            while (swapped)                                             ;}

    }
}
