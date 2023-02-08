using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.LinqExamples
{
    internal class LinqQueries
    {
        Data data = new();


        public void QueryExamples()
        {
            IEnumerable<int> QuerySyntax = from obj in data.integerList
                                           where obj > 5
                                           select obj;

            // QuerySyntax is executed first time for this loop
            Console.WriteLine("Enumerable:");
            foreach (var item in QuerySyntax)
            {
                Console.Write($"{ item } ");
            }
            Console.WriteLine();

            // QuerySyntaxList is executed immediately 
            List<int> QuerySyntaxList = (from obj in data.integerList
                                    where obj < 5
                                    select obj).ToList();

            Console.WriteLine("List:");
            QuerySyntaxList.ForEach(x => Console.Write($"{ x } "));
            Console.WriteLine();
        }
        
}
}
