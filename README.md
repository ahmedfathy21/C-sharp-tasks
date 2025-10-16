# C# Learning Repository & .NET Core Web Server

A comprehensive repository containing C# learning materials, advanced programming concepts, and a production-ready .NET Core web server for hosting content publicly.

## 📚 Repository Overview

This repository serves dual purposes:
1. **Learning Hub** - Complete C# learning journey from basics to advanced concepts
2. **Web Server** - Production-ready .NET Core 9.0 web server for public content hosting

## 🏗️ Repository Structure

```
C-sharp-tasks/
├── 📁 C#/                     # Basic C# Learning Projects
├── 📁 c#_Advanced/            # Advanced C# Programming Concepts  
├── 📁 MynewWebServer/         # .NET Core Web Server
├── 📄 README.md              # This comprehensive guide
├── 📄 .gitignore             # Complete .NET project exclusions
└── 📄 Netcore.sln            # Solution file
```

## 🎓 C# Learning Materials

### � Basic C# (`C#/` Directory)

#### **Assignments & Exercises**
- `Assignment_1` - Fundamental C# concepts
- `Assignment_2` - Object-oriented programming basics
- `Assignment_3.cs` - Advanced OOP implementations
- `Assignment_4` - Data structures and algorithms
- `Assignment_5` - Final comprehensive project

#### **Practice Projects**
- **� Book API** - RESTful API development
- **🧮 Calculator** - Console-based calculator application
- **🌡️ Currency & Temperature Converter** - Unit conversion utilities
- **🎲 Dice Game** - Random number generation and game logic
- **🔢 Number Guessing Game** - Interactive console game
- **📝 Quiz Project** - Question-answer system implementation
- **✂️ Rock Paper Scissors** - Classic game with computer AI
- **📋 TO-DO List** - Task management application
- **📐 Shape Area Calculator** - Geometric calculations with inheritance
- **⚔️ Turn-based Combat** - RPG-style combat system

### 🚀 Advanced C# (`c#_Advanced/` Directory)

#### **📡 Delegates & Events**
- **Delegate Implementations** - Function pointers and callbacks
- **Employee Management** - Delegate-based sorting and filtering
- **Event-driven Architecture** - Publisher-subscriber patterns
- **String Processing** - Custom string manipulation functions

#### **🔧 Generic Programming**
- **Animals Project** - Generic inheritance hierarchies
- **ArrayList Implementation** - Custom generic collections
- **Bubble Sort** - Generic sorting algorithms
- **Corporate Clean** - Employee evaluation systems
- **Equality Comparisons** - Custom equality implementations
- **Hash Functions** - Custom GetHashCode implementations
- **Type Safety** - is/as operators and type checking
- **Dictionary Operations** - Key-value pair manipulations

#### **🏗️ Object-Oriented Design**
- **Encapsulation Examples** - Property-based data hiding
- **Inheritance Patterns** - Base class implementations
- **Polymorphism** - Virtual methods and overriding
- **Interface Implementations** - Contract-based programming

#### **🔍 LINQ & Data Processing**
- **Custom LINQ** - Extension method implementations
- **Employee Queries** - Complex data filtering
- **Functional Programming** - Lambda expressions and delegates

## 🌐 .NET Core Web Server (`MynewWebServer/`)

A modern, production-ready web server built with .NET Core 9.0 for hosting HTML files and providing API endpoints.

### ✨ Features

- 📁 **Static File Hosting** - Serves HTML, CSS, JS, and other static assets
- 🔗 **RESTful API Endpoints** - Multiple API endpoints for data exchange
- 🌐 **CORS Support** - Cross-Origin Resource Sharing enabled
- ⚡ **High Performance** - Built on .NET Core for optimal performance
- 📱 **Responsive Design** - Mobile-first responsive layouts
- 🔧 **Health Checks** - Built-in health monitoring
- 🎨 **Modern UI** - Clean, professional interface

### 🚀 Quick Start

#### Development Mode
```bash
cd MynewWebServer
dotnet run
```
The server will start at `http://localhost:5153`

#### Production Mode
```bash
cd MynewWebServer
dotnet run --launch-profile production
```
The server will start at `http://0.0.0.0:8080` (accessible from any IP)

### 🛣️ Available Endpoints

#### Web Pages
- `GET /` - Redirects to the main page
- `GET /index.html` - Main homepage with server information
- `GET /index2.html` - Advanced features page

#### API Endpoints
- `GET /hello` - Simple API endpoint returning JSON
- `GET /api/info` - Detailed server information
- `GET /api/status` - Server status and health
- `GET /health` - Health check endpoint

### 📁 Web Server Structure

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

## 🎯 Learning Objectives

### 📚 Basic C# Mastery
- ✅ **Syntax & Fundamentals** - Variables, data types, control structures
- ✅ **Object-Oriented Programming** - Classes, objects, inheritance, polymorphism
- ✅ **Exception Handling** - Try-catch blocks and error management
- ✅ **File I/O Operations** - Reading and writing files
- ✅ **Collections** - Arrays, Lists, Dictionaries
- ✅ **Methods & Functions** - Parameter passing, return values
- ✅ **Console Applications** - Interactive command-line programs

### 🚀 Advanced C# Expertise
- ✅ **Generic Programming** - Type-safe collections and methods
- ✅ **Delegates & Events** - Function pointers and event-driven programming
- ✅ **LINQ** - Language Integrated Query for data manipulation
- ✅ **Async/Await** - Asynchronous programming patterns
- ✅ **Reflection** - Runtime type inspection and manipulation
- ✅ **Extension Methods** - Adding functionality to existing types
- ✅ **Custom Collections** - Implementing IEnumerable and ICollection

### 🌐 Web Development Skills
- ✅ **ASP.NET Core** - Modern web framework
- ✅ **RESTful APIs** - HTTP-based service architecture
- ✅ **Static File Serving** - Web asset hosting
- ✅ **CORS Configuration** - Cross-origin request handling
- ✅ **Health Monitoring** - Application health checks
- ✅ **Production Deployment** - Server configuration and hosting

## 🛠️ Technologies Used

### **Core Technologies**
- **C# 12** - Latest language features
- **.NET 9.0** - Modern runtime and framework
- **ASP.NET Core** - Web application framework
- **Entity Framework** (in some projects) - ORM for database access

### **Development Tools**
- **Visual Studio / VS Code** - Primary IDE
- **Git** - Version control system
- **GitHub** - Repository hosting
- **NuGet** - Package management

### **Web Technologies**
- **HTML5** - Modern markup language
- **CSS3** - Styling and responsive design
- **JavaScript** - Client-side interactivity
- **JSON** - Data exchange format

## 📈 Project Progression

### Phase 1: Foundation (C# Directory)
1. **Basic Syntax** - Variable declarations, operators
2. **Control Structures** - Loops, conditionals, switches
3. **Methods** - Function creation and parameter passing
4. **Classes & Objects** - OOP fundamentals
5. **Simple Projects** - Calculator, games, utilities

### Phase 2: Intermediate (C# Projects)
1. **Data Structures** - Custom collections and algorithms
2. **File Operations** - Reading/writing data
3. **Error Handling** - Exception management
4. **API Development** - Basic web services
5. **Complex Projects** - Multi-class applications

### Phase 3: Advanced (c#_Advanced Directory)
1. **Generic Programming** - Type-safe code
2. **Delegate Systems** - Function pointers and callbacks
3. **LINQ Mastery** - Data query and manipulation
4. **Design Patterns** - Software architecture principles
5. **Performance Optimization** - Memory and speed improvements

### Phase 4: Production (MynewWebServer)
1. **Web Server Development** - Full-stack application
2. **API Design** - RESTful service architecture
3. **Static Content Hosting** - File serving capabilities
4. **Production Deployment** - Real-world hosting
5. **Monitoring & Health Checks** - Application reliability

## 🏃‍♂️ Getting Started

### Prerequisites
```bash
# Install .NET 9.0 SDK
wget https://dot.net/v1/dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh --version latest
```

### Clone Repository
```bash
git clone https://github.com/ahmedfathy21/C-sharp-tasks.git
cd C-sharp-tasks
```

### Explore Learning Materials
```bash
# Basic C# projects
cd C#
ls -la

# Advanced concepts
cd ../c#_Advanced
ls -la

# Run web server
cd ../MynewWebServer
dotnet run
```

## 🌐 Hosting & Deployment

### 📋 Adding New HTML Files
1. Create your HTML file in the `MynewWebServer/wwwroot/` directory
2. The file will be automatically served at `http://localhost:5153/yourfile.html`

### 🎨 Adding CSS/JS Files
1. Place CSS files in `wwwroot/css/` (create directory if needed)
2. Place JS files in `wwwroot/js/` (create directory if needed)
3. Reference them in your HTML files using relative paths

### 📄 Example HTML File Structure
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

### 🚀 Deployment Options

#### Local Network Access
```bash
cd MynewWebServer
dotnet run --launch-profile production
```

#### Cloud Deployment
Ready for deployment to:
- **Azure App Service** - Microsoft's cloud platform
- **AWS Elastic Beanstalk** - Amazon's web service platform
- **Google Cloud Run** - Google's containerized hosting
- **Docker Containers** - Containerized deployment
- **Any .NET Core hosting service**

#### Docker Deployment
```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY bin/Release/net9.0/publish/ .
EXPOSE 8080
ENTRYPOINT ["dotnet", "MynewWebServer.dll"]
```

## ⚙️ Configuration & Security

### 🔧 Environment Variables
- `ASPNETCORE_ENVIRONMENT` - Set to "Production" for production deployment
- `ASPNETCORE_URLS` - Configure the URLs the server listens on

### 🔒 Security Considerations
- CORS is currently configured to allow all origins (for development)
- For production, configure CORS to only allow specific domains
- Consider adding authentication for sensitive endpoints
- Use HTTPS in production environments

### ⚡ Performance Features
- Static file caching (24-hour cache headers)
- Minimal API design for reduced overhead
- Async/await patterns throughout
- Optimized for high concurrency

## 📊 Monitoring & Health

### 🩺 Health Checks
- Visit `/health` to check server status
- Returns HTTP 200 when healthy

### 📈 Server Information
- Visit `/api/info` for detailed server information
- Includes uptime, environment, and feature list

## 🔧 Troubleshooting

### 🚫 Port Already in Use
```bash
# Find process using port 5153
lsof -i :5153

# Kill the process (replace PID with actual process ID)
kill -9 <PID>
```

### 📁 Static Files Not Loading
- Ensure files are in the `wwwroot/` directory
- Check file permissions
- Verify case-sensitive paths on Linux/macOS

### 🔗 API Endpoints Not Working
- Check the console output for any errors
- Verify the endpoint URLs match exactly
- Test with curl: `curl http://localhost:5153/api/info`

## 🤝 Contributing

This repository represents a comprehensive learning journey. Feel free to:
- ⭐ Star the repository if you find it helpful
- 🍴 Fork it for your own learning purposes
- 📝 Submit issues for improvements
- 💡 Suggest new learning projects

## 📖 Learning Resources

### 📚 Recommended Reading
- **C# Documentation** - Microsoft's official C# guide
- **ASP.NET Core Documentation** - Web development with .NET
- **Clean Code** - Robert C. Martin
- **Design Patterns** - Gang of Four

### 🎓 Online Courses
- **Microsoft Learn** - Free C# and .NET courses
- **Pluralsight** - Advanced C# programming
- **Udemy** - Practical C# projects
- **YouTube** - C# tutorials and walkthroughs

## 📜 License

This project is open source and available under the **MIT License**.

---

## 🎯 Summary

This repository showcases a complete C# learning journey, from basic console applications to advanced programming concepts and production-ready web server development. It demonstrates practical skills in:

- **Fundamental Programming** - Variables, loops, functions, classes
- **Advanced C# Features** - Generics, delegates, LINQ, async programming
- **Web Development** - ASP.NET Core, APIs, static file hosting
- **Software Engineering** - Version control, project structure, documentation
- **Deployment** - Production hosting, Docker, cloud platforms

Perfect for students, professionals, and anyone looking to master C# development! 🚀
