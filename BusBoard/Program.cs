using System;
using System.Linq;
using BusBoard.Clients;

namespace BusBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            TflClient tflClient = new TflClient();
            var arrivalsAtStop = tflClient
                .GetArrivals("490008660N")
                .OrderBy(a => a.ExpectedArrival)
                .Take(5)
                .ToList();

            foreach (var arrivalPrediction in arrivalsAtStop)
            {
                Console.Out.WriteLine($"Bus {arrivalPrediction.LineName} arriving at {arrivalPrediction.ExpectedArrival.ToShortTimeString()}");
            }
        }
    }
}