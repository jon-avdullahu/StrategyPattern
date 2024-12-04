public class DrivingStrategy : IRouteStrategy
{
    private const double AVERAGE_DRIVING_SPEED = 60.0; // km/h

    public string CalculateRoute(string startPoint, string endPoint)
    {
        return $"Driving route from {startPoint} to {endPoint}: " +
               "Follow main roads and highways";
    }

    public double EstimateTime(double distance)
    {
        return distance / AVERAGE_DRIVING_SPEED;
    }
}
