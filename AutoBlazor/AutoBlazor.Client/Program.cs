using AutoBlazor.Shared.Services.Base.ClientServcies;
using AutoBlazor.Shared.Services.CategoryServices;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Register HttpClient with the correct base address
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7133") // Replace with your actual API URL
});


// Register the CategoryServices with its interface
builder.Services.AddScoped<IClient, Client>();
builder.Services.AddScoped<ICategoryServices, CategoryServices>();

await builder.Build().RunAsync();
