namespace _01.Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    public class Reverse_Strings
    {
        public static void Main()
        {
            //read the input from the console
            var input = Console.ReadLine();
            //create an empty stack to reverse the input with
            var inputStack = new Stack<char>();

            //fill in the stack
            foreach(var letter in input) //for(i < input.Length)
            {
                inputStack.Push(letter);
            }

            //print out the letters in the stack
            while(inputStack.Count != 0)
            {
                Console.Write(inputStack.Pop());
            }
            Console.WriteLine(); //add a row after just for readability
        }
    }
}