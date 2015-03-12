/*Problem 14. Print the symbols of the ASCII table. */

using System;
using System.Collections.Generic;
using System.Text;

    class Problem14PrintTheASCIITable
    {
        static void Main()
        {
            for (int i = 0; i < 256; i++)
            {
                Console.Write((char)i);
            }
        }
    }

