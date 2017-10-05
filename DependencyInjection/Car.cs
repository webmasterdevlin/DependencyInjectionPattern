using System;

namespace DependencyInjection
{
    abstract class Car
    {

        protected bool _on;

        public void TurnOnOff()
        {
            _on = !_on;

            if (_on)
            {
                Console.WriteLine("The car is on!");
            }
            else
            {
                Console.WriteLine("The car is off!");
            }
        }

        public abstract void Drive();
    }
}