using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    internal class PriorityQueue
    {
        // Maintain the jobTitle,priority as a Key-Value pair. The list of jobs in the priority queue will be a linked list of Key-Value pairs.
        private List<KeyValuePair<string,int>> queue;  

        public PriorityQueue()
        {
            queue = new List<KeyValuePair<string, int>>(); //Initialize the empty priority queue
        }

        public void Enqueue(string jobTitle, int priority)
        {
            // Step 1: Create a Key-Value pair with the jobTitle-priority provided in the parameters
             KeyValuePair<string, int> newJob = new KeyValuePair<string, int>(jobTitle, priority);
            
            //Step 2: Traverse the queue on priority field (which is Value in the Key-Value pair) till the highest priority is reached. 
            int i = 0;
            while (i < queue.Count && queue[i].Value >= priority)
            {
                i++;
            }
            
            // Step 3: Insert the Kay-Value pair before that.
            queue.Insert(i, newJob);
        }

        public string Dequeue()
        {
            //Throw an exception if the queue is empty
            if (queue.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }

            //Get the first item in the queue. First item is the job with highest priority. 
            string item = queue[0].Key;

            //Delete it from the queue. 
            queue.RemoveAt(0);

            //Return the deleted jobTitle(in the Key).
            return item;
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public void PrintQueue()
        {
            foreach (var job in queue)
            {
                Console.Write($" |{job.Key}, {job.Value}| ");
                Console.Write("-->");
            }
            Console.WriteLine("null");
        }
    }
}

