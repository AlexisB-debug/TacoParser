using System;

namespace LoggingKata;

public static class PathGeeseFly
{
    public static double[] VectorBlueprint(double latitude, double longitude)
    {
        double latitudeToRadians = (Math.PI * latitude) / 180;
        double longitudeToRadians = (Math.PI * longitude) / 180;

        double x = Math.Cos(latitudeToRadians) * Math.Cos(longitudeToRadians);
        double y = Math.Cos(latitudeToRadians) * Math.Sin(longitudeToRadians);
        double z = Math.Sin(latitudeToRadians);

        double[] vector = new double[] { x, y, z };
        return vector;
    }

    public static double Flyway(double[] OriginVector, double[] DestinationVector)
    {
        const double earthRadiusInMeters = 6371000.0;
        double dotProduct = OriginVector[0] * DestinationVector[0] + OriginVector[1] * DestinationVector[1] +
                            OriginVector[2] * DestinationVector[2];
        double centralAngle = Math.Acos(dotProduct);
        double arcLength = centralAngle * earthRadiusInMeters;
        return arcLength;
    }
}
