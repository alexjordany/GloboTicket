namespace GloboTicket.TicketManagement.API.IntegrationTests.Controllers;

public class CategoryControllerTests : IClassFixture<CustomWebApplicationFactory<IStartup>>
{
    private readonly CustomWebApplicationFactory<IStartup> _factory;

    public CategoryControllerTests(CustomWebApplicationFactory<IStartup> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task ReturnsSuccessResult()
    {
        var client = _factory.GetAnonymousClient();

        var response = await client.GetAsync("/api/category/all");

        response.EnsureSuccessStatusCode();

        var responseString = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<List<CategoryListVm>>(responseString);

        Assert.IsType<List<CategoryListVm>>(result);
        Assert.NotEmpty(result);
    }
}
