using System;
using System.Threading.Tasks;

namespace SoapClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SoapDemo.SOAPDemoSoapClient client = new();

            long sum = await client.AddIntegerAsync(1, 2);
            Console.WriteLine($"Soma: {sum}");

            var response = await client.GetListByNameAsync("Adams");
            Console.WriteLine($"Registros encontrados: {response[0].Name}");

            var city = await client.LookupCityAsync("99950");
            Console.WriteLine($"Cidade: {city.City}");
        }
    }
}
