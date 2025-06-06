# Blazor QueryBuilder

A modern Blazor component wrapper for the popular jQuery QueryBuilder library, providing a user-friendly interface for building complex queries in Blazor applications.

Originally forked from [jQuery QueryBuilder](https://github.com/mistic100/jQuery-QueryBuilder) and enhanced with native Blazor component integration.

[![screenshot](https://raw.githubusercontent.com/mistic100/jQuery-QueryBuilder/master/examples/screenshot.png)](https://querybuilder.js.org)

## 🚀 What's New in v2.5.1

✅ **Complete Blazor Integration** - Native Blazor component with full C# support  
✅ **Latest Dependencies** - Updated to Bootstrap 5.3.6, jQuery 3.7.1, latest Sass  
✅ **NuGet Package** - Easy installation via NuGet package manager  
✅ **Strongly Typed** - Full C# models and IntelliSense support  
✅ **Event Callbacks** - Real-time notifications of rule changes  
✅ **Async API** - Modern async/await pattern for all operations  

## Quick Start (Blazor)

### 1. Install the NuGet Package
```bash
dotnet add package BlazorQueryBuilder
```

### 2. Add Required Dependencies
Add to your `_Host.cshtml` or `index.html`:
```html
<script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
<link href="_content/BlazorQueryBuilder/css/query-builder.default.css" rel="stylesheet" />
<script src="_content/BlazorQueryBuilder/js/query-builder.standalone.js"></script>
```

### 3. Use the Component
```razor
@using BlazorQueryBuilder.Components
@using BlazorQueryBuilder.Models

<QueryBuilder @ref="queryBuilder"
              Filters="filters"
              OnRulesChanged="OnRulesChanged" />

@code {
    private QueryBuilder queryBuilder = default!;
    
    private readonly QueryBuilderFilter[] filters = new[]
    {
        new QueryBuilderFilter { Id = "name", Label = "Name", Type = "string" },
        new QueryBuilderFilter { Id = "price", Label = "Price", Type = "double" }
    };
    
    private void OnRulesChanged(string rules)
    {
        Console.WriteLine($"Rules: {rules}");
    }
}
```

📖 **[View Complete Blazor Documentation](README.Blazor.md)**

---

## Original jQuery QueryBuilder Documentation

[![npm version](https://img.shields.io/npm/v/jQuery-QueryBuilder.svg?style=flat-square)](https://www.npmjs.com/package/jQuery-QueryBuilder)
[![jsDelivr CDN](https://data.jsdelivr.com/v1/package/npm/jQuery-QueryBuilder/badge)](https://www.jsdelivr.com/package/npm/jQuery-QueryBuilder)
[![Build Status](https://github.com/mistic100/jQuery-QueryBuilder/workflows/CI/badge.svg)](https://github.com/mistic100/jQuery-QueryBuilder/actions)
[![gitlocalized](https://gitlocalize.com/repo/5259/whole_project/badge.svg)](https://gitlocalize.com/repo/5259/whole_project?utm_source=badge)

jQuery plugin offering an simple interface to create complex queries.



## Documentation
[querybuilder.js.org](https://querybuilder.js.org)



## Install

#### Manually

[Download the latest release](https://github.com/mistic100/jQuery-QueryBuilder/releases)

#### With npm

```bash
$ npm install jQuery-QueryBuilder
```

#### Via CDN

jQuery-QueryBuilder is available on [jsDelivr](https://www.jsdelivr.com/package/npm/jQuery-QueryBuilder).
### Dependencies
 * [jQuery 3](https://jquery.com)
 * [Bootstrap 5](https://getbootstrap.com/docs/5.3/) CSS and bundle.js which includes `Popper` for tooltips and popovers
 * [Bootstrap Icons](https://icons.getbootstrap.com/) 
 * [jQuery.extendext](https://github.com/mistic100/jQuery.extendext)
 * [MomentJS](https://momentjs.com) (optional, for Date/Time validation)
 * [SQL Parser](https://github.com/mistic100/sql-parser) (optional, for SQL methods)
 * Other Bootstrap/jQuery plugins used by plugins

($.extendext is directly included in the [standalone](https://github.com/mistic100/jQuery-QueryBuilder/blob/master/dist/js/query-builder.standalone.js) file)


## 🧪 Test Application

A comprehensive test application is included to demonstrate all BlazorQueryBuilder features in action.

### Running the Test App

```bash
cd BlazorQueryBuilder.TestApp
chmod +x run-demo.sh
./run-demo.sh
```

Or on Windows:
```powershell
cd BlazorQueryBuilder.TestApp
.\run-demo.ps1
```

Or manually:
```bash
cd BlazorQueryBuilder.TestApp
dotnet build
dotnet run
```

### Features Demonstrated

The test application includes three main sections:

#### 🏠 Home Page
- Overview of BlazorQueryBuilder capabilities
- Installation and quick start guide
- Feature highlights and code examples

#### 📊 Examples Page
- **Interactive QueryBuilder** with real-time JSON output
- **Multiple Filter Types** (strings, numbers, dates, booleans, selections)
- **Sample Data Loading** with simple and complex queries
- **Event Handling** demonstration with live rule change notifications
- **Validation Testing** with error handling examples

#### ⚙️ Advanced Page
- **Performance Testing** with execution time measurement
- **Method Testing** for all async operations (`GetRulesAsync`, `SetRulesAsync`, etc.)
- **Minimal Configuration** examples
- **API Reference** with parameter documentation
- **Debug Information** and browser compatibility details

### Test Scenarios

The application provides comprehensive test scenarios for:
- Creating and modifying simple rules
- Building complex nested queries with multiple groups
- Testing all supported data types and operators
- Validating async method performance
- Demonstrating real-time event callbacks
- Loading and manipulating complex rule structures

Visit `http://localhost:5000` after running the application to explore all features interactively.

## Developement

Install Node dependencies with `npm install`.

#### Build

Run `npm run build` in the root directory to generate production files inside `dist`.

#### Serve

Run `npm run serve` to open the example page with automatic build and livereload.


## License
This library is available under the MIT license.
