using System;
using System.Device.Location;

namespace distance
{
    class Program
    {
        public static double DistanceTo(double startLatitude, double startLongitude, double endLatitude, double endLongitude)
        {
            var radius = 6371;
            var radianLat1 = Math.PI * startLatitude / 180;
            var radianLat2 = Math.PI * endLatitude / 180;
            var radianTheta = Math.PI * (startLongitude - endLongitude) / 180;
            var distance =
                Math.Sin(radianLat1) * Math.Sin(radianLat2) + Math.Cos(radianLat1) *
                Math.Cos(radianLat2) * Math.Cos(radianTheta);
            distance = Math.Acos(distance);
            return distance * radius;
        }

        static void Main(string[] args)
        {
            var startLatitude = 0;
            var startLongitude = 170;
            var endLatitude = 0;
            var endLongitude = 180;
            Console.WriteLine(DistanceTo(startLatitude,startLongitude,endLatitude,endLongitude));
            /*var startCoord = new GeoCoordinate(startLatitude, startLongitude);
            var endCoord = new GeoCoordinate(endLatitude, endLongitude);
            Console.WriteLine(startCoord.GetDistanceTo(endCoord)/1000);*/
            Console.ReadKey();
        }
    }
}
