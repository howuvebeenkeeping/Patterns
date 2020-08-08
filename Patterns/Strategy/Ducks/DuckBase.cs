using System;
using Patterns.Strategy.Behaviour;

namespace Patterns.Strategy.Ducks
{
    public abstract class DuckBase
    {
        public IQuackable QuackBehaviour { get; set; }
        public IFlyable FlyBehaviour { get; set; }
        public DuckBase()
        {
            QuackBehaviour = new SimpleQuack();
            FlyBehaviour = new FlyWithWings();
        }
        public void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }

        public void Fly()
        {
            FlyBehaviour.Fly();
        }

        public void Quack()
        {
            QuackBehaviour.Quack();
        }

        public abstract void Display();
    }
}
