using System;

namespace DependencyInjection
{
    class Lamborghini : Car
    {
        public override void Drive()
        {
            if (_on)
            {
                Console.WriteLine("Drive Lamborghini!");
            }
            else
            {
                Console.WriteLine("Have to start Lamborghini first!");
            }
        }
    }
}