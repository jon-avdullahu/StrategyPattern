public class WalkingStrategy : IRouteStrategy
{
    private const double AVERAGE_WALKING_SPEED = 5.0; // km/h

    public string CalculateRoute(string startPoint, string endPoint)
    {
        return $"Walking route from {startPoint} to {endPoint}: " +
               "Use sidewalks and pedestrian crossings";
    }

    public double EstimateTime(double distance)
    {
        return distance / AVERAGE_WALKING_SPEED;
    }
}
