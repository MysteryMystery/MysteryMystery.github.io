using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FeatureManagement;
using MysteryMystery.github.io;
using MysteryMystery.github.io.Repositories.Pokedex;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddFeatureManagement();

builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();

await builder.Build().RunAsync();
