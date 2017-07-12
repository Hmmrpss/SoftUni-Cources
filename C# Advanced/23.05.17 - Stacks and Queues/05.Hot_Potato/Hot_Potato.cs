namespace _05.Hot_Potato
{
    using System;
    using System.Collections.Generic;

    public class Hot_Potato
    {
        public static void Main()
        {
            //read the list of kids
            var input = Console.ReadLine();
            var kids = new List<string>(input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
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
                    queue.Enqueue(queue.Dequeue());
                }
                //print out the ones wich are removed
                Console.WriteLine("Removed {0}", queue.Dequeue());
            }
            //print out the victor
            Console.WriteLine("Last is {0}", queue.Dequeue());
        }
    }
}