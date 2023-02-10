using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.LinqExamples
{
    internal class ListCFiles
    {
        public void Example()
        {
            var files = Directory.EnumerateFiles(@"c:\windows");

            var results = from f in files
                          let fi = new FileInfo(f)
                          orderby fi.Length
                          select fi.Length;

            foreach (var fi in results)
            {
                Console.WriteLine(fi);
            }
        }


    }
}
