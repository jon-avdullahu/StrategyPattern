public class NavigationContext
{
    private IRouteStrategy _routeStrategy;

    public NavigationContext(IRouteStrategy strategy)
    {
        _routeStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
    }

    public void SetStrategy(IRouteStrategy strategy)
    {
        _routeStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
    }

    public string GetRoute(string startPoint, string endPoint)
    {
        if (string.IsNullOrEmpty(startPoint) || string.IsNullOrEmpty(endPoint))
        {
            throw new ArgumentException("Start point and end point must not be empty");
        }
        return _routeStrategy.CalculateRoute(startPoint, endPoint);
    }

    public double GetEstimatedTime(double distance)
    {
        if (distance < 0)
        {
            throw new ArgumentException("Distance cannot be negative");
        }
        return _routeStrategy.EstimateTime(distance);
    }
}
