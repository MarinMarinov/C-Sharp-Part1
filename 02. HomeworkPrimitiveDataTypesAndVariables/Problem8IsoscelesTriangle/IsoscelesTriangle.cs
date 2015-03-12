using System;

        /*Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
           ©

          © ©

         ©   ©

        © © © ©*/

namespace Problem8IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char c = '\u00a9';
            Console.WriteLine("   " + c);
            Console.WriteLine("  " + c + " " + c);
            Console.WriteLine(" " + c + "   " + c);
            Console.WriteLine(c + " " + c + " " + c + " " + c);
        }
    }
}
/* Насторйките на конзолата ми са на шрифт Consolas(truetype шрифт) и размер на символите 18. 
 * При други настройки, символът u00a9 може да изглежда по различен начин*/