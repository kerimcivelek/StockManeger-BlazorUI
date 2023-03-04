using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Blazored.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using WebUI.PBYS.Client;
using WebUI.PBYS.Shared.Services.Abstract;
using WebUI.PBYS.Shared.Services.Concrete;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7243/") });
builder.Services.AddBlazoredToast();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IDashboardService, DashboardService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ITechnicalService, TechnicalServices>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IloginService, LoginService>();
builder.Services.AddScoped<IProductStockService, ProductStockService>();

builder.Services.AddScoped(serviceProvider => (IJSInProcessRuntime)serviceProvider.GetRequiredService<IJSRuntime>());
builder.Services.AddScoped(serviceProvider => (IJSUnmarshalledRuntime)serviceProvider.GetRequiredService<IJSRuntime>());

await builder.Build().RunAsync();



 