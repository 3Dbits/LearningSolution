using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfCS.OopExamples
{
    public class Clock
    {
        private readonly ClockHand hours;
        private readonly ClockHand minutes;
        private readonly ClockHand seconds;

        public Clock()
        {
            this.hours = new ClockHand(24);
            this.minutes = new ClockHand(60);
            this.seconds = new ClockHand(60);
        }

        public void Advance()
        {
            this.seconds.Advance();

            if (this.seconds.Value == 0)
            {
                this.minutes.Advance();

                if (this.minutes.Value == 0)
                {
                    this.hours.Advance();
                }
            }
        }

        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
    }
}
