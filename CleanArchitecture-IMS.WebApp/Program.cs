using CleanArchitecture_IMS.Plugins.InMemory;
using CleanArchitecture_IMS.UseCases.Inventories;
using CleanArchitecture_IMS.UseCases.Inventories.Interfaces;
using CleanArchitecture_IMS.UseCases.Inventory.Interfaces;
using CleanArchitecture_IMS.UseCases.PluginInterfaces;
using CleanArchitecture_IMS.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorComponents();

// whenever a specific interface is required, the concrete given implementation should be used
// AddSingleton creates an instance only once in the programs lifetime and persists throughout sessions
builder.Services.AddSingleton<IInventoryRepository, InventoryRepository>();

// AddTransient creates a new instance each time it's requested.
// AddTransient is a lightweigt class, as it doesn't store any data
builder.Services.AddTransient<IViewInventoryItemsByNameUseCase, ViewInventoryItemsByNameUseCase>();
builder.Services.AddTransient<IAddInventoryItemUseCase, IAddInventoryItemUseCase>();

// AddScoped stores the created object as long as a SignalR channel is still established (for every session)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>();

app.Run();
