// Strategy for calculating walking routes
// Implements IRouteStrategy for walking-specific logic
public class WalkingStrategy : IRouteStrategy
{
    private const double AVERAGE_WALKING_SPEED = 5.0; // km/h

    public string CalculateRoute(string startPoint, string endPoint)
    {
        // Return walking directions
        return $"Walking route from {startPoint} to {endPoint}: " +
               "Use sidewalks and pedestrian crossings";
    }

    public double EstimateTime(double distance)
    {
        // Calculate time based on walking speed
        return distance / AVERAGE_WALKING_SPEED;
    }
}
