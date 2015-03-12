using System;

    class Problem8IsoscelesTriangleWithLoops
    {
        static void Main()
        {
              //Вариант *
              //        **
              //        ***
              //        ****
              //        *****
            
            Console.Write("Insert triagnle height(in rows): ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col <=row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Вариант     *       0 + 1     (0)
            //           ***      1 + 1 + 1 (1)
            //          *****     2 + 1 + 2 (2)
            //         *******    3 + 1 + 3 (3)
            //        *********   4 + 1 + 4 (4)
            Console.Write("Insert triagnle height(in rows): ");
            int rows = int.Parse(Console.ReadLine());            
            for (int row = 0; row < rows; row++)
            {
                Console.Write(new string(' ', n - row));                          
                Console.Write(new string ('*', 2*row + 1));
                Console.WriteLine();
            }
        }
    }

