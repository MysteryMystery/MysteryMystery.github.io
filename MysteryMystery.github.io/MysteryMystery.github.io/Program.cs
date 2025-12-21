using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MysteryMystery.github.io;
using MysteryMystery.github.io.Repositories;
using Microsoft.Extensions.Options;
using MysteryMystery.github.io.Components.Models.Options;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.Configure<FeatureFlagOptions>(builder.Configuration.GetSection("FeatureFlags"));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IJsonRepository, JsonRepository>();

await builder.Build().RunAsync();
