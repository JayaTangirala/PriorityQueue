namespace PriorityQueue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PriorityQueue pq = new PriorityQueue();
            pq.Enqueue("Job3",3);
            pq.Enqueue("Job1",1);
            pq.Enqueue("Job2",2);
            pq.Enqueue("Job4",2);
            pq.Enqueue("Job5",2);
            pq.Enqueue("Job6",1);

            Console.WriteLine("Priority Queue:");
            pq.PrintQueue();

            Console.WriteLine("\nDequeueing items:");      
            while (!pq.IsEmpty())
            {
                Console.WriteLine(pq.Dequeue());
            }
        }
    }
}