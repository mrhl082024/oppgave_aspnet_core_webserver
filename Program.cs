//Builder pattern
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Middleware for serving static files from the "wwwroot" directory
app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/health", () =>
{
    return "Server OK!";
});

app.MapPost("/api/v1/todoos", () =>
{
    return "Recieved a POST request to '/'";
});

app.Run();
