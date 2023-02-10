using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.AsyncExamples
{
    internal class AsyncAwait
    {


        public async void RunAsyncTasks()
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            var task1 = RandomTask(1, 5000);
            await task1; //=> usefull in when the other tasks are dependent on the first one
            var task2 = RandomTask(2, 2000);
            var task3 = RandomTask(3, 4000);

            Task.WhenAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds} ms");
        }

        public async Task RandomTask(int num, int sleep)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"Starting Task {num}");
                Thread.Sleep(sleep);
                Console.WriteLine($"Finishig Task {num}");
            });
        }
    }
}

