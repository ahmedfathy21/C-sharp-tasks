# My .NET Core Web Server

A modern, lightweight web server built with .NET Core 9.0 for hosting HTML files and providing API endpoints.

## Features

- 📁 **Static File Hosting** - Serves HTML, CSS, JS, and other static assets
- 🔗 **RESTful API Endpoints** - Multiple API endpoints for data exchange
- 🌐 **CORS Support** - Cross-Origin Resource Sharing enabled
- ⚡ **High Performance** - Built on .NET Core for optimal performance
- 📱 **Responsive Design** - Mobile-first responsive layouts
- 🔧 **Health Checks** - Built-in health monitoring
- 🎨 **Modern UI** - Clean, professional interface

## Quick Start

### Development Mode
```bash
cd MynewWebServer
dotnet run
```
The server will start at `http://localhost:5153`

### Production Mode
```bash
cd MynewWebServer
dotnet run --launch-profile production
```
The server will start at `http://0.0.0.0:8080` (accessible from any IP)

## Available Endpoints

### Web Pages
- `GET /` - Redirects to the main page
- `GET /index.html` - Main homepage with server information
- `GET /index2.html` - Advanced features page

### API Endpoints
- `GET /hello` - Simple API endpoint returning JSON
- `GET /api/info` - Detailed server information
- `GET /api/status` - Server status and health
- `GET /health` - Health check endpoint

## File Structure

```
MynewWebServer/
├── Program.cs              # Main server configuration
├── wwwroot/               # Static files directory
│   ├── index.html         # Main homepage
│   ├── index2.html        # Features page
│   └── styles.css         # Global CSS styles
├── Properties/
│   └── launchSettings.json # Launch profiles
└── MynewWebServer.csproj  # Project configuration
```

## Hosting Static Content

### Adding New HTML Files
1. Create your HTML file in the `wwwroot/` directory
2. The file will be automatically served at `http://localhost:5153/yourfile.html`

### Adding CSS/JS Files
1. Place CSS files in `wwwroot/css/` (create directory if needed)
2. Place JS files in `wwwroot/js/` (create directory if needed)
3. Reference them in your HTML files using relative paths

### Example HTML File Structure
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Your Page Title</title>
    <link rel="stylesheet" href="/styles.css">
</head>
<body>
    <div class="container">
        <h1>Your Content Here</h1>
    </div>
</body>
</html>
```

## Deployment Options

### Local Network Access
To make your server accessible from other devices on your local network:
```bash
dotnet run --launch-profile production
```

### Cloud Deployment
The application is ready for deployment to:
- Azure App Service
- AWS Elastic Beanstalk
- Google Cloud Run
- Docker containers
- Any hosting service supporting .NET Core

### Docker Deployment
Create a `Dockerfile`:
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY bin/Release/net9.0/publish/ .
EXPOSE 8080
ENTRYPOINT ["dotnet", "MynewWebServer.dll"]
```

## Configuration

### Environment Variables
- `ASPNETCORE_ENVIRONMENT` - Set to "Production" for production deployment
- `ASPNETCORE_URLS` - Configure the URLs the server listens on

### Custom Configuration
Modify `Program.cs` to:
- Add new API endpoints
- Configure authentication
- Add database connections
- Customize middleware

## Security Considerations

- CORS is currently configured to allow all origins (for development)
- For production, configure CORS to only allow specific domains
- Consider adding authentication for sensitive endpoints
- Use HTTPS in production environments

## Performance Features

- Static file caching (24-hour cache headers)
- Minimal API design for reduced overhead
- Async/await patterns throughout
- Optimized for high concurrency

## Monitoring

### Health Checks
- Visit `/health` to check server status
- Returns HTTP 200 when healthy

### Server Information
- Visit `/api/info` for detailed server information
- Includes uptime, environment, and feature list

## Troubleshooting

### Port Already in Use
```bash
# Find process using port 5153
lsof -i :5153

# Kill the process (replace PID with actual process ID)
kill -9 <PID>
```

### Static Files Not Loading
- Ensure files are in the `wwwroot/` directory
- Check file permissions
- Verify case-sensitive paths on Linux/macOS

### API Endpoints Not Working
- Check the console output for any errors
- Verify the endpoint URLs match exactly
- Test with curl: `curl http://localhost:5153/api/info`

## License

This project is open source and available under the MIT License.