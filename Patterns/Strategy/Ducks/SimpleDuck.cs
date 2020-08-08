using System;

namespace Patterns.Strategy.Ducks
{
    public class SimpleDuck : DuckBase
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I'm a simple duck.");
        }
    }
}
