using System;

	class Trainings
	{
		static void Main()
		{
			
			//Odd or Even
			/*Console.Write("Insert numer: ");
			int n = int.Parse(Console.ReadLine());
			if (n%2==0)
			{
				Console.WriteLine("The number is {0} is Even", n);
			}
			else
			{
				Console.WriteLine("The number {0} is Odd", n);
			}*/

			//Gravitation ot the Moon

			/*decimal weightOnEarth = decimal.Parse(Console.ReadLine());
			decimal moonGravityConstant = 0.1666666666666666666666M;
			decimal weightOnMoon = Math.Round(weightOnEarth * moonGravityConstant, 2);
			Console.WriteLine("Your weight on the Moon is: " +weightOnMoon);*/

			//Divided by 7 and 5

			/*Console.Write("Insert some number: ");
			int n = int.Parse(Console.ReadLine());
			bool trueOrFalse = (n != 0) && (n % 7 == 0) && (n % 5 == 0);
			Console.WriteLine(trueOrFalse);*/

			// Third digit is 7

			/*Console.Write("Insert some number: ");
			int n = int.Parse(Console.ReadLine());
			double thirdDigit = n / 100;
			if (thirdDigit ==7)
			{
				Console.WriteLine("The third digit is 7");
			}
			else
			{
				Console.WriteLine("The third digit is not 7");
			}*/

			//Point Inside a Circle & Outside of a Rectangle

			/*Console.Write("Insert x: ");
			double x = double.Parse(Console.ReadLine());
			Console.Write("Insert y: ");
			double y = double.Parse(Console.ReadLine());
			bool insideCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5;
			bool outsideRectangle = (x < 1 || x > 6) && (y < -1 || y > 1);
			if (insideCircle && outsideRectangle)
			{
				Console.WriteLine("The point {0},{1} is inside the circle and outside the rectangle!", x, y);
			}
			else
			{
				Console.WriteLine("The point {0},{1}  isn't", x, y);                
			}*/

            /*Console.Write("Insert number: ");
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int bitMask = n & mask;
            int bit = bitMask >> p;
            Console.WriteLine("The {0} bit of the number {1} is: {2}", p, n, bit);*/

            /*Console.Write("Enter a number from 1 to 100: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;
            if (number > 0 && number <= 100 )
            {
                if (number == 1)
                {
                    Console.WriteLine("The number 1 is Prime!");                    
                }
                else 
                {
                    for (int i = 2; i < number/2; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                        }
                    }
                    Console.WriteLine("Is the number {0} prime? {1}!", number, isPrime);
                }
            }
            else
            {
                Console.WriteLine("You have entered invalid number!");
            }*/
		}
	}
