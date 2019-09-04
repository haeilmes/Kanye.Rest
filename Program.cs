using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.kanye.rest";

            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;

            string joke2 = JObject.Parse(response).GetValue("quote").ToString();

            Console.WriteLine(joke2);
        }
    }
}
