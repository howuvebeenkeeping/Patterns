using System;

namespace Patterns.Strategy.Behaviour
{
    public class FlyWithWings : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying.");
        }
    }
}
