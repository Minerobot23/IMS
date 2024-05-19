using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection; // Add this directive
using IMS; // Ensure this matches your Blazor app's namespace

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Set the BaseAddress for the HttpClient to your API's localhost URL
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5197/") }); // Adjust the port if necessary

await builder.Build().RunAsync();