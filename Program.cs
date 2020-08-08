using System;
using System.Collections.Generic;
using Patterns.Strategy.Ducks;
using Patterns.Strategy.Behaviour;

namespace Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StrategyExampleRun();
        }

        private static void StrategyExampleRun()
        {
            var ducks = new List<DuckBase>
            {
                new SimpleDuck(),
                new ExoticDuck(),
                new WoodenDuck(),
                new RubberDuck()
            };

            foreach (var duck in ducks)
            {
                ShowDuckStuff(duck);
                Console.WriteLine();
            }

            DuckBase upgradableDuck = new SimpleDuck { FlyBehaviour = new NoFly() };
            ShowDuckStuff(upgradableDuck);

            Console.WriteLine("\nThe last duck has been changed\n");
            upgradableDuck.FlyBehaviour = new FlyWithWings();
            upgradableDuck.QuackBehaviour = new ExoticQuack();

            ShowDuckStuff(upgradableDuck);

            void ShowDuckStuff(DuckBase duck)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();
            }
        }
    }
}
