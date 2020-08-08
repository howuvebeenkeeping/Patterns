using System;
using Patterns.Strategy.Behaviour;

namespace Patterns.Strategy.Ducks
{
    public class WoodenDuck : DuckBase
    {
        public WoodenDuck()
        {
            FlyBehaviour = new NoFly();
            QuackBehaviour = new NoQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a wooden duck!");
        }
    }
}
