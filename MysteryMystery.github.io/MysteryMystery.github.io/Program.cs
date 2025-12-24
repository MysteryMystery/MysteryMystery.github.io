using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MysteryMystery.github.io;
using MysteryMystery.github.io.Repositories;
using Microsoft.Extensions.Options;
using MysteryMystery.github.io.Components.Models.Options;
using MysteryMystery.github.io.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.Configure<FeatureFlagOptions>(builder.Configuration.GetSection("FeatureFlags"));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IJsonRepository, JsonRepository>();
builder.Services.AddScoped<IBrowserStorageRepository, LocalStorageRepository>();
builder.Services.AddScoped<IDarkModeService, DarkModeService>();

await builder.Build().RunAsync();
