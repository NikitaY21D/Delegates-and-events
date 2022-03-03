using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_and_events
{
    internal class Prograam
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();



            Clock clock = new Clock();



            timer.TimeChangeEvent += clock.Parsetime;

            timer.Start();
        }
    }
}