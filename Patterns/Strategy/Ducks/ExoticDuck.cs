using System;
using Patterns.Strategy.Behaviour;

namespace Patterns.Strategy.Ducks
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            QuackBehaviour = new ExoticQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm an exotic duck.");
        }
    }
}
