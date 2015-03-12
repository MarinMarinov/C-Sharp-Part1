/*Problem 1. Declare Variables
  Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, 
  ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
  Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.*/

using System;

namespace Problem1DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            ushort v = 52130;
            sbyte w = -115;
            uint x = 4825932;
            byte y = 97;
            int z = -10000;
            Console.WriteLine("ushort= {0} \nsbyte= {1} \nuint= {2} \nbyte= {3} \nint= {4}", v, w, x, y, z);
        }
    }
}
