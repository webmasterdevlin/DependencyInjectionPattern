using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ferrari = new Ferrari();
            Car lamborghini = new Lamborghini();

            Person person = new Person(lamborghini);
            person.Drive();
        }
    }
}
