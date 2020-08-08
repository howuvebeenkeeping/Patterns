using System;

namespace Patterns.Strategy.Behaviour
{
    public class NoQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("...");
        }
    }
}
