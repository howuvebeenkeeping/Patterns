using System;
using Patterns.Strategy.Behaviour;

namespace Patterns.Strategy.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            FlyBehaviour = new NoFly();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a rubber duck!");
        }
    }
}
