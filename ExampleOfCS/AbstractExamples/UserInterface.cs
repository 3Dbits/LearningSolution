using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.AbstractExamples
{
    internal class UserInterface
    {
        private readonly List<Operation> operations;

        public UserInterface()
        {
            this.operations = new();
        }

        public void AddOperation(Operation operation)
        {
            this.operations.Add(operation);
        }

        public void Start()
        {
            while (true)
            {
                PrintOperations();
                Console.WriteLine("Choice: ");

                string choice = Console.ReadLine();
                if (choice.Equals("0"))
                {
                    break;
                }

                ExecuteOperation(choice);
                Console.WriteLine();
            }
        }

        private void PrintOperations()
        {
            Console.WriteLine("\t0: Stop");
            int i = 0;

            this.operations.ForEach(operation => {
                Console.WriteLine($"\t{ i + 1 }: { operation.Name }");
                i += 1;
            });
        }

        private void ExecuteOperation(String choice)
        {
            int operation = Int32.Parse(choice);

            this.operations[operation - 1].Execute();
        }
    }
}
