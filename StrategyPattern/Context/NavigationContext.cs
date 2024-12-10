// Context class that uses a strategy to calculate routes
// Allows switching between different strategies at runtime
public class NavigationContext
{
    private IRouteStrategy _routeStrategy;

    public NavigationContext(IRouteStrategy strategy)
    {
        // Initialize with a specific strategy
        _routeStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
    }

    public void SetStrategy(IRouteStrategy strategy)
    {
        // Change the current strategy
        _routeStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
    }

    public string GetRoute(string startPoint, string endPoint)
    {
        // Get route using the current strategy
        if (string.IsNullOrEmpty(startPoint) || string.IsNullOrEmpty(endPoint))
        {
            throw new ArgumentException("Start point and end point must not be empty");
        }
        return _routeStrategy.CalculateRoute(startPoint, endPoint);
    }

    public double GetEstimatedTime(double distance)
    {
        // Estimate time using the current strategy
        if (distance < 0)
        {
            throw new ArgumentException("Distance cannot be negative");
        }
        return _routeStrategy.EstimateTime(distance);
    }
}
