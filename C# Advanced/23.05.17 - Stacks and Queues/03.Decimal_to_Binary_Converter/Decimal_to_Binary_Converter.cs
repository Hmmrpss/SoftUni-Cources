namespace _03.Decimal_to_Binary_Converter
{
    using System;
    using System.Collections.Generic;

    public class DecimalToBinaryConverter
    {
        public static void Main()
        {
            //read the number
            var input = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            //if 0 write 0 (same in the both systems)
            if (input == 0)
            {
                Console.WriteLine(0);
            }
            //else convert it to binary
            else
            {
                while (input != 0)
                {
                    //take the remainder of / 2
                    stack.Push(input % 2);
                    //decrease the number / 2
                    input /= 2;
                }
            }

            //print out the result
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}