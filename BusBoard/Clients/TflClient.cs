using System.Collections.Generic;
using BusBoard.Models.TflModels;
using RestSharp;

namespace BusBoard.Clients
{
    public class TflClient
    {
        public List<ArrivalPrediction> GetArrivals(string stopCode)
        {
            var client = new RestClient("https://api.tfl.gov.uk");
            var request = new RestRequest($"StopPoint/{stopCode}/Arrivals", DataFormat.Json);
            var response = client.Get<List<ArrivalPrediction>>(request);

            return response.Data;
        }
    }
}