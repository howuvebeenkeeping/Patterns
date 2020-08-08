using System;

namespace Patterns.Strategy.Behaviour
{
    public class ExoticQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
