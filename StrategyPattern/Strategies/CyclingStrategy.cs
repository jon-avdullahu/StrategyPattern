// Strategy for calculating cycling routes
// Implements IRouteStrategy for cycling-specific logic
public class CyclingStrategy : IRouteStrategy
{
    private const double AVERAGE_CYCLING_SPEED = 15.0; // km/h

    public string CalculateRoute(string startPoint, string endPoint)
    {
        // Return cycling directions
        return $"Cycling route from {startPoint} to {endPoint}: " +
               "Use bike lanes and cycle paths";
    }

    public double EstimateTime(double distance)
    {
        // Calculate time based on cycling speed
        return distance / AVERAGE_CYCLING_SPEED;
    }
}
