using Blazored.LocalStorage;
using System.Reflection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

builder.Services.AddSingleton(new HttpClient
{
    BaseAddress = new Uri("https://localhost:7015/")
});

builder.Services.AddHttpClient<GloboTicket.TicketManagement.App.Services.IClient, GloboTicket.TicketManagement.App.Services.Client>(client => client.BaseAddress = new Uri("https://localhost:7015/"));

builder.Services.AddScoped<IEventDataService, EventDataService>();
builder.Services.AddScoped<ICategoryDataService, CategoryDataService>();
builder.Services.AddScoped<IOrderDataService, OrderDataService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


await builder.Build().RunAsync();
