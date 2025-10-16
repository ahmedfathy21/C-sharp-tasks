using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
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

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Enable CORS
app.UseCors();

// Enable static files with caching headers for better performance
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        // Cache static files for 24 hours
        ctx.Context.Response.Headers.Append("Cache-Control", "public,max-age=86400");
    }
});

// Configure routing
app.MapGet("/", () => Results.Redirect("/index.html"));

app.MapGet("/hello", () => new
{
    Message = "Hello, World!",
    Timestamp = DateTime.UtcNow,
    Server = "My .NET Core Web Server",
    Version = "1.0.0"
});

app.MapGet("/api/info", () => new
{
    ServerName = "My Web Server",
    Version = "1.0.0",
    Environment = app.Environment.EnvironmentName,
    Timestamp = DateTime.UtcNow,
    Uptime = DateTime.UtcNow.Subtract(Process.GetCurrentProcess().StartTime).ToString(@"dd\.hh\:mm\:ss"),
    Features = new[]
    {
        "Static File Hosting",
        "RESTful APIs",
        "CORS Support",
        "Cross-platform"
    }
});

app.MapGet("/api/status", () => new
{
    Status = "Online",
    Timestamp = DateTime.UtcNow,
    Server = Environment.MachineName,
    ProcessId = Environment.ProcessId
});

// Health check endpoint
app.MapGet("/health", () => Results.Ok("Healthy"));

// Fallback for SPA routing (optional)
app.MapFallbackToFile("index.html");

Console.WriteLine($"🚀 Server starting at: {DateTime.Now}");
Console.WriteLine("📁 Serving static files from wwwroot/");
Console.WriteLine("🌐 Available endpoints:");
Console.WriteLine("   GET  /              -> Redirects to index.html");
Console.WriteLine("   GET  /hello         -> Simple API endpoint");
Console.WriteLine("   GET  /api/info      -> Server information");
Console.WriteLine("   GET  /api/status    -> Server status");
Console.WriteLine("   GET  /health        -> Health check");
Console.WriteLine("   Static files served from wwwroot/");

await app.RunAsync();