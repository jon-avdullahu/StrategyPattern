// Strategy for calculating driving routes
// Implements IRouteStrategy for driving-specific logic
public class DrivingStrategy : IRouteStrategy
{
    private const double AVERAGE_DRIVING_SPEED = 60.0; // km/h

    public string CalculateRoute(string startPoint, string endPoint)
    {
        // Return driving directions
        return $"Driving route from {startPoint} to {endPoint}: " +
               "Follow main roads and highways";
    }

    public double EstimateTime(double distance)
    {
        // Calculate time based on driving speed
        return distance / AVERAGE_DRIVING_SPEED;
    }
}
