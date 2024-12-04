using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Navigation System Using Strategy Pattern\n");

            // Create context with initial strategy
            var navigation = new NavigationContext(new DrivingStrategy());

            // Test all strategies
            TestStrategy(navigation, "Home", "Office", 10.0);

            navigation.SetStrategy(new WalkingStrategy());
            TestStrategy(navigation, "Home", "Office", 10.0);

            navigation.SetStrategy(new CyclingStrategy());
            TestStrategy(navigation, "Home", "Office", 10.0);

            Console.ReadKey();
        }

        static void TestStrategy(NavigationContext navigation, string start, string end, double distance)
        {
            Console.WriteLine(navigation.GetRoute(start, end));
            Console.WriteLine($"Estimated time: {navigation.GetEstimatedTime(distance):F2} hours\n");
        }
    }
}
