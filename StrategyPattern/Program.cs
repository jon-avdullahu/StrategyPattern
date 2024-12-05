using System;

namespace StrategyPattern
{
    // Main program to demonstrate the Strategy Pattern
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Navigation System Using Strategy Pattern\n");

            // Create context with initial strategy (driving)
            var navigation = new NavigationContext(new DrivingStrategy());

            // Test all strategies
            TestStrategy(navigation, "Home", "Office", 10.0);

            // Switch to walking strategy
            navigation.SetStrategy(new WalkingStrategy());
            TestStrategy(navigation, "Home", "Office", 10.0);

            // Switch to cycling strategy
            navigation.SetStrategy(new CyclingStrategy());
            TestStrategy(navigation, "Home", "Office", 10.0);

            Console.ReadKey();
        }

        // Helper method to test a strategy
        static void TestStrategy(NavigationContext navigation, string start, string end, double distance)
        {
            Console.WriteLine(navigation.GetRoute(start, end));
            Console.WriteLine($"Estimated time: {navigation.GetEstimatedTime(distance):F2} hours\n");
        }
    }
}
