using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.OopExamples
{
    internal class ClockHand
    {
        public int Value { get; private set; }
        private readonly int limit;

        public ClockHand(int limit)
        {
            this.limit = limit;
            this.Value = 0;
        }

        public void Advance()
        {
            this.Value = this.Value + 1;

            if (this.Value >= this.limit)
            {
                this.Value = 0;
            }
        }

        public override string ToString()
        {
            return this.Value < 10 ? 
                $"0{ this.Value }" : $"{ this.Value }";
        }
    }
}
