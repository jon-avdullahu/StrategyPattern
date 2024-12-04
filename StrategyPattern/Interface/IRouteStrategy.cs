public interface IRouteStrategy
{
    string CalculateRoute(string startPoint, string endPoint);
    double EstimateTime(double distance);
}
