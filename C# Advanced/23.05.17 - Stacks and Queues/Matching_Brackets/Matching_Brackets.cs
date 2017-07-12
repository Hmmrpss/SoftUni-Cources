namespace Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    public class Matching_Brackets
    {
        public static void Main()
        {
            //read the input
            var input = Console.ReadLine();

            //set up a stack for the indexes of (
            var stack = new Stack<int>();

            //go trough the whole mathematical problem and exctract the brackets and their contents
            for (int i = 0; i < input.Length; i++)
            {
                //get the current char from the input string
                var character = input[i];

                if (character.Equals('('))
                {
                    //if the character in a ( get it's index and store it
                    stack.Push(i);
                }
                //when you come to an )
                else if (character.Equals(')'))
                {
                    //get the starting index for the substring from the stack
                    var startIndex = stack.Pop();

                    //extract the substring from it till the current char - it + 1
                    var bracet = input.Substring(startIndex, i - startIndex + 1);

                    //print out the brackets and it's content
                    Console.WriteLine(bracet);
                }
            }
        }
    }
}