using System;
using System.Net.Http;
using System.Threading.Tasks;
using MetadataTypeExample.Models;
using Newtonsoft.Json;

namespace MetadataTypeExample
{
    class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        static async Task Main(string[] args)
        {   
            var resultData = await ProcessRepositories();           
            Example example = JsonConvert.DeserializeObject<Example>(resultData);

            foreach (Result result in example.Results)
            {
                Console.WriteLine($"{result.Id.Value}-{result.Name.Title}.{result.Name.First} {result.Name.Last} [{result.Email}] {result.Dob}");
            }
        }

        private static async Task<string> ProcessRepositories()
        {
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Add("User-Agent", "Async Main Method Test");

            var stringTask = await Client.GetStringAsync("https://randomuser.me/api/?results=5");
            return stringTask;
        }
    }
}
