namespace _06.Math_Potato
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;

    public class Math_Potato
    {
        public static void Main()
        {
            //read the list of kids
            var input = Console.ReadLine();
            var kids = new List<string>(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            //read the number of tosses
            var tosses = int.Parse(Console.ReadLine());
            //add the list of kids in a queue
            var queue = new Queue<string>(kids);

            //remove the children from the list untill only one remains
            while (queue.Count != 1)
            {
                //skip the ball and remove a child
                for (int i = 1; i < tosses; i++)
                {
                    if (IsPrime(i))
                    {
                        //print out the ones wich are removed
                        Console.WriteLine("Prime {0}", queue.Dequeue());
                    }
                    else
                    {
                        queue.Enqueue(queue.Dequeue());
                        //print out the ones wich are removed
                        Console.WriteLine("Removed {0}", queue.Peek());

                    }
                }
            }
            //print out the victor
            Console.WriteLine("Last is {0}", queue.Dequeue());
        }

        //prime number checker
        private static bool IsPrime(BigInteger num)
        {
            if (num == 0 || num == 1)
                return false;

            bool isPrime = true;
            for (int j = 2; j < num; j++)
            {
                if ((num % j) == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
    }
}