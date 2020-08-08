using System;

namespace Patterns.Strategy.Behaviour
{
    public class NoFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("---");
        }
    }
}
