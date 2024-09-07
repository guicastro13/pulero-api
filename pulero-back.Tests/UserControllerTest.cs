using System.Net.Http;
using System.Threading.Tasks;
using xunit;

namespace pulero_back.Tests;
public class IntegracaoTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;

        public IntegracaoTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Testar_Get_Endpoint()
        {
            // Arrange
            var requestUri = "/api/exemplo"; // Altere para o endpoint que você deseja testar

            // Act
            var response = await _client.GetAsync(requestUri);

            // Assert
            response.EnsureSuccessStatusCode(); // Verifica se a resposta tem um código de status 2xx
            var responseString = await response.Content.ReadAsStringAsync();
            Assert.Contains("expected value", responseString); // Verifica o conteúdo da resposta
        }
    }