var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors();

app.MapGet("/api/hello", () =>
{
    return new { message = "Hello from .NET API 🚀" };
});

app.Run("http://0.0.0.0:80");
