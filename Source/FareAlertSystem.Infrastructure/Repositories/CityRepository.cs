using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel.Web;

using FareAlertSystem.Models;
using FareAlertSystem.DomainInterfaces;

using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace FareAlertSystem.Infrastructure
{
    public class CityRepository : ICityRepository
    {
        public void Add(City entity)
        {
            throw new NotImplementedException();
        }

        public City Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            City [] listCity = new City[] {
                new City("BLR", "Bangalore")
            };

            //url https://airport.api.aero/airport?user_key=62c8126824545316f07aa3d9e70fc365
            string key = "62c8126824545316f07aa3d9e70fc365"; // hard coded user key to get iAirport Authentication

            const string URL = "https://airport.api.aero/airport";
            string urlParameters = "?user_key=62c8126824545316f07aa3d9e70fc365";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                List<City> lstCity = null;
                // Parse the response body. Blocking!
                string strResponse = response.Content.ReadAsStringAsync().Result;

                lstCity = JsonConvert.DeserializeObject<List<City>>(strResponse);
                return lstCity;
            }
            else
            {
                //Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return listCity;
            }

            //throw new NotImplementedException();
        }

        public void Remove(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(City entity)
        {
            throw new NotImplementedException();
        }


    }
}