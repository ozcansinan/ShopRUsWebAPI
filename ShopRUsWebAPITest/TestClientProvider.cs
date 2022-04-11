using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using ShopRUsWebAPI;
using System.Net.Http;

namespace ShopRUsWebAPITest
{
    class TestClientProvider
    {
        public HttpClient Client { get; set; }

        public TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            Client = server.CreateClient();
        }
    }
}
