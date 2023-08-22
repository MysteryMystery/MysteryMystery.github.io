using Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor.Services;
using Blazor.Services.Catan;
using Blazor.Services.Pokedex;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ITextualDataService, TextualDataService>();
builder.Services.AddScoped<ICloutShootsService, CloutShootsService>();
builder.Services.AddScoped<ICatanBoardBuilder, CatanBoardBuilder>();
builder.Services.AddScoped<IPokeAPIService, PokeAPIService>(x => new PokeAPIService(
                        builder.Configuration["pokedex:baseUrl"],
                        x.GetRequiredService<ILogger<PokeAPIService>>(),
                        x.GetRequiredService<HttpClient>()
                    ));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
