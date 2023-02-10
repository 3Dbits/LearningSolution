using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.AsyncExamples
{
    internal class SyncExample
    {


        public void RunTasks()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            RandomTask(1, 5000);
            RandomTask(2, 2000);
            RandomTask(3, 4000);
            watch.Stop();

            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds} ms");


        }

        public void RandomTask(int num, int sleep)
        {
                Console.WriteLine($"Starting Task {num}");
                Thread.Sleep(sleep);
                Console.WriteLine($"Finishig Task {num}");

        }
    }
}
