namespace _02.Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleCalculator
    {
        public static void Main()
        {
            //read the input expression
            var input = Console.ReadLine();
            //get the values for the calculation
            var inputValues = input.Split(' '); 
            //add them in the stack in reversed order
            var inputStack = new Stack<string>(inputValues.Reverse());

            //repeat untill only one number remains
            while (inputStack.Count > 1)
            {
                //get the two numbers and the perator
                var firstNumber = int.Parse(inputStack.Pop());
                var oper = inputStack.Pop();
                var secondNumber = int.Parse(inputStack.Pop());

                //if it is + add them
                if (oper == "+")
                {
                    inputStack.Push((firstNumber + secondNumber).ToString());
                }
                //if it is - substract them
                else if (oper == "-")
                {
                    inputStack.Push((firstNumber - secondNumber).ToString());
                }
            }
            //print out the result on the console
            Console.WriteLine(inputStack.Pop());
        }
    }
}