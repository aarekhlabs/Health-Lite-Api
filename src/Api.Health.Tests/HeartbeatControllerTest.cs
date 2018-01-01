using AarekhLabs.AspNetCore.Api.Health.Models;
using AarekhLabs.Memcached.Api;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Xunit;

namespace AarekhLabs.AspNetCore.Api.Health.Tests
{
    /// <summary>
    /// HealthController Test cases.
    /// </summary>
    public class HeartbeatControllerTest
    {
        // Make sure Api.Web is running before running the test.
        [Fact]
        public async Task HeartbeatTest()
        {
            HttpClient client = new HttpClient();
            var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get,"http://localhost:8363/api/health/heartbeat"));

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            HeartbeatModel model = JsonConvert.DeserializeObject<HeartbeatModel>(responseString);
            Assert.Equal("OK", model.Heartbeat);
        }
    }
}

