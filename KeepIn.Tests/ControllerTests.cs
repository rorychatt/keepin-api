using Microsoft.AspNetCore.Mvc.Testing;
namespace KeepIn.Tests
{
    public class ControllerTests(WebApplicationFactory<Program> factory) : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client = factory.CreateClient();

        [Fact]
        public async Task GetUsers_ShouldReturnOk()
        {
            var response = await _client.GetAsync("/api/v1/Users");
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.NotNull(responseString);
        }
    }
}