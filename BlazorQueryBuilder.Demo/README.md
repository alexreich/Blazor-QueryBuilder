# BlazorQueryBuilder Demo

A comprehensive demonstration application showcasing how to consume BlazorQueryBuilder as a NuGet package in a real-world scenario.

## 🎯 Purpose

This demo application serves as:
- **Consumer Example**: Shows how end-users would integrate BlazorQueryBuilder into their projects
- **Package Reference Demo**: Uses BlazorQueryBuilder as a PackageReference (not ProjectReference)
- **Interactive Playground**: Allows users to try out all component features
- **Documentation**: Live examples of API usage and configuration options

## 🚀 Quick Start

### Prerequisites
1. Build the BlazorQueryBuilder package first:
   ```bash
   cd ../
   dotnet build --configuration Release
   ```

### Running the Demo
```bash
cd BlazorQueryBuilder.Demo
dotnet run
```

Visit `https://localhost:5001` to explore the demo.

## 📋 Demo Features

### Home Page
- Overview of BlazorQueryBuilder capabilities
- Quick start guide for developers
- Navigation to demo pages

### Basic Demo (`/basic-demo`)
- Simple query building with common filter types
- Real-time JSON output
- API method testing (Get, Clear, Validate, Load Sample)
- Common filter types: string, integer, double, boolean, date

### Advanced Demo (`/advanced-demo`)
- Complex filter configurations
- Custom operators and validation rules
- Dropdown/select inputs with predefined values
- Performance testing and stress tests
- Nested and complex rule structures
- Real-time performance metrics

## 🔧 Technical Details

### Package Consumption
This demo consumes BlazorQueryBuilder exactly as end-users would:

```xml
<PackageReference Include="BlazorQueryBuilder" Version="2.5.1" />
```

### Service Registration
```csharp
builder.Services.AddBlazorQueryBuilder();
```

### Component Usage
```razor
@using BlazorQueryBuilder.Components
@using BlazorQueryBuilder.Models

<QueryBuilder @ref="queryBuilder"
              Filters="filters"
              OnRulesChanged="OnRulesChanged" />
```

## 📁 Project Structure

```
BlazorQueryBuilder.Demo/
├── BlazorQueryBuilder.Demo.csproj    # Package reference configuration
├── Program.cs                        # Service registration
├── App.razor                         # Blazor app root
├── Components/
│   ├── Layout/
│   │   ├── MainLayout.razor          # Main layout
│   │   └── NavMenu.razor             # Navigation menu
│   └── Pages/
│       ├── Home.razor                # Landing page
│       ├── BasicDemo.razor           # Basic functionality demo
│       └── AdvancedDemo.razor        # Advanced features demo
├── Pages/
│   ├── _Host.cshtml                  # Host page
│   └── Shared/
│       └── _Layout.cshtml            # HTML layout
└── wwwroot/
    └── css/
        └── app.css                   # Custom styles
```

## 🎨 Demo Highlights

### Interactive Features
- ✅ Real-time rule JSON output
- ✅ Live validation feedback
- ✅ Performance metrics
- ✅ Sample data loading
- ✅ Stress testing capabilities

### Filter Types Demonstrated
- **Text Filters**: Name, email with various operators
- **Numeric Filters**: Age, salary with validation ranges
- **Boolean Filters**: Manager status, active flags
- **Date/DateTime Filters**: Hire dates, review dates
- **Select Filters**: Department, rating dropdowns

### API Methods Showcased
- `GetRulesAsync()` - Retrieve current rules
- `SetRulesAsync()` - Load predefined rules
- `ClearAsync()` - Clear all rules
- `ValidateAsync()` - Validate current rules
- `OnRulesChanged` - Real-time change events

## 💡 For Developers

This demo serves as a complete reference implementation for:
- How to properly reference and configure BlazorQueryBuilder
- Best practices for filter configuration
- Handling async operations and events
- Performance optimization techniques
- Error handling and validation

## 🔗 Related

- [Main BlazorQueryBuilder Documentation](../README.Blazor.md)
- [Original jQuery QueryBuilder](../README.md)
- [NuGet Package](https://www.nuget.org/packages/BlazorQueryBuilder)