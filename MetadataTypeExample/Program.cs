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
            var aa = await ProcessRepositories();
            Console.WriteLine(aa);

            Example example = JsonConvert.DeserializeObject<Example>(aa);
        }

        private static async Task<string> ProcessRepositories()
        {
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = await Client.GetStringAsync("https://randomuser.me/api/?results=5");
            return stringTask;
        }
    }
}
