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

            FirstTask();
            SecondTask();
            ThirdTask();
            watch.Stop();

            Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds} ms");


        }

        public void FirstTask()
        {

            Console.WriteLine("Starting Task 1, THIS TASK MUST FINISH BEFORE OTHERS HAVE STARTED");
            Thread.Sleep(5000);
            Console.WriteLine("Finishig Task 1");

        }


        public void SecondTask()
        {

            Console.WriteLine("Starting Task 2");
            Thread.Sleep(3000);
            Console.WriteLine("Finishing Task 2");

        }

        public void ThirdTask()
        {
            Console.WriteLine("Starting Task 3");
            Thread.Sleep(2000);
            Console.WriteLine("Finishing Task 3");
        }

    }
}
