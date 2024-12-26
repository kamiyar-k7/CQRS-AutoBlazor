

using AutoBlazor.shared.Services.CategoryServices;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<ICategoryServices, CategoryServices>();

await builder.Build().RunAsync();
