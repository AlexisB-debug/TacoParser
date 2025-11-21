using System;

namespace LoggingKata;

public static class PathGeeseFly
{
    public static double[] OriginVector(double originLatitude, double originLongitude)
    {
        double originLatitudeToRadians = (Math.PI * originLatitude) / 180.0f;
        double originLongitudeToRadians = (Math.PI * originLongitude) / 180.0f;

        double x = Math.Cos(originLatitudeToRadians) * Math.Cos(originLongitudeToRadians);
        double y = Math.Cos(originLongitudeToRadians) * Math.Sin(originLatitudeToRadians);
        double z = Math.Sin(originLongitudeToRadians);

        double[] OriginVector = new double[] { x, y, z };
        return OriginVector;
    }

    public static double[] DestinationVector(double destinationLatitude, double destinationLongitude)
    {
        double destinationLatitudeToRadians = (Math.PI * destinationLatitude) / 180.0f;
        double destinationLongitudeToRadians = (Math.PI * destinationLongitude) / 180.0f;

        double x = Math.Cos(destinationLatitudeToRadians) * Math.Cos(destinationLongitudeToRadians);
        double y = Math.Cos(destinationLongitudeToRadians) * Math.Sin(destinationLatitudeToRadians);
        double z = Math.Sin(destinationLongitudeToRadians);

        double[] DestinationVector = new double[] { x, y, z };
        return DestinationVector;
    }

    public static double Flyway(double[] OriginVector, double[] DestinationVector)
    {
        double dotProduct = OriginVector[0] * DestinationVector[0] + OriginVector[1] * DestinationVector[1] +
                            OriginVector[2] * DestinationVector[2];
        double centralAngle = Math.Acos((dotProduct / Math.Pow(6371000, 2)));
        return centralAngle;
    }
}