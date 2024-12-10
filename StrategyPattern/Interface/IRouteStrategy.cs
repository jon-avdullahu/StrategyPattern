// This interface defines what all navigation strategies must implement
// It's part of the Strategy Pattern and acts as a contract for different transportation methods
public interface IRouteStrategy
{
    // Calculates a route between two points and returns directions
    string CalculateRoute(string startPoint, string endPoint);

    // Calculates how long the journey will take based on the distance
    double EstimateTime(double distance);
}
