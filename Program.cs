var builder = WebApplication.CreateBuilder();

builder.Services.AddRazorComponents().AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.MapRazorComponents<BlazorTodoApp.Components.App>()
    .AddInteractiveServerRenderMode();

app.UseAntiforgery();
app.UseStaticFiles();

app.Run();