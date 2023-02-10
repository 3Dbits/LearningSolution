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

            var task1 = FirstTask();
            await task1; //=> usefull in when the other tasks are dependent on the first one
            var task2 = SecondTask();
            var task3 = ThirdTask();


            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds} ms");


        }

        public async Task FirstTask()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Starting Task 1");
                Thread.Sleep(5000);
                Console.WriteLine("Finishig Task 1");
            });
        }


        public async Task SecondTask()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Starting Task 2");
                Thread.Sleep(3000);
                Console.WriteLine("Finishing Task 2");
            });


        }

        public async Task ThirdTask()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Starting Task 3");
                Thread.Sleep(2000);
                Console.WriteLine("Finishing Task 3");
            });
        }

    }
}

