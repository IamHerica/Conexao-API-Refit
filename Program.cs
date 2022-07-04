using Refit;
using System;
using System.Threading.Tasks;

namespace ConexaoEntreAPI_Refit
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var adviceClient = RestService.For<IJsonplaceholderAPIService>("https://jsonplaceholder.typicode.com/");
            Console.WriteLine("Number of jsonplaceholder: ");
            int adviceNumber = int.Parse(Console.ReadLine());
            var advice = await adviceClient.GetTitle(adviceNumber);
            Console.WriteLine(advice.title);
        }
    }
}
