using System;

namespace DependencyInjection
{
    class Ferrari : Car
    {
        public override void Drive()
        {
            if (_on)
            {
                Console.WriteLine("Drive Ferrari!");
            }
            else
            {
                Console.WriteLine("Have to start Ferrari first!");
            }
        }
    }
}