using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Verifiers.Web;
using Xunit;

namespace Verifiers.Tests
{

    public class PasswordVerifierIntegrationTest
    {

        private readonly HttpClient _httpClient = null;
        private readonly TestServer _testServer = null;

        public PasswordVerifierIntegrationTest()
        {
            this._testServer = new TestServer(new WebHostBuilder().UseEnvironment("Development").UseStartup<Startup>());

            this._httpClient = this._testServer.CreateClient();
        }

        [Theory]
        [InlineData("AbTp9!fok")]
        [InlineData("ycTp9$fuk")]
        [InlineData("xbTw9@cok")]
        public async Task CheckIfPasswordMatchesAllVerifiers(string value)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(new HttpMethod("GET"), $"/v1/verifiers/passwords/{value}");

            HttpResponseMessage httpResponseMessage = await this._httpClient.SendAsync(httpRequestMessage);

            httpResponseMessage.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, httpResponseMessage.StatusCode);
        }

        [Theory]
        [InlineData("AbT p9!fok")]
        [InlineData("ycTp9$aaa")]
        [InlineData("abc")]
        public async Task CheckIfPasswordDoesNotMatchVerifiers(string value)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(new HttpMethod("GET"), $"/v1/verifiers/passwords/{value}");

            HttpResponseMessage httpResponseMessage = await this._httpClient.SendAsync(httpRequestMessage);

            Assert.Equal(HttpStatusCode.BadRequest, httpResponseMessage.StatusCode);
        }
    }
}
