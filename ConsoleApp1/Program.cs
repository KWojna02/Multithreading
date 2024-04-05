namespace ConsoleApp1
{
    internal class Program
    {
        public static volatile int count = 0;
        public static readonly object locker = new object();
        static void Main(string[] args)
        {
            int n = 4;
            Thread[] threads = new Thread[n];
            for (int i = 0; i < n; i++) threads[i] = new Thread(Counting);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (Thread thread in threads) thread.Start();
            foreach (Thread thread in threads) thread.Join();
            watch.Stop();
            Console.WriteLine($"{count} threads ended in {watch.ElapsedMilliseconds} ms.");

        }
        
        
        static void Counting()
        {  
            Thread.Sleep(500);
            lock(locker)
            {
                var tmp = count;
                Thread.Sleep(5);
                count = tmp + 1;
            }
        }
    }
}
