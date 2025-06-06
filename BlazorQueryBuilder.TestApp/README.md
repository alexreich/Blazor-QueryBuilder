# Blazor QueryBuilder Test Application

This is a comprehensive test application for the BlazorQueryBuilder library that demonstrates all the features and capabilities of the Blazor QueryBuilder component.

## 🚀 Running the Test Application

### Prerequisites
- .NET 8.0 SDK
- Modern web browser with JavaScript enabled

### Quick Start

1. **Navigate to the test app directory:**
   ```bash
   cd BlazorQueryBuilder.TestApp
   ```

2. **Build the application:**
   ```bash
   dotnet build
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

4. **Open your browser:**
   - Navigate to `https://localhost:7xxx` or `http://localhost:5xxx` (ports shown in console)
   - The application will display with a navigation sidebar

## 📱 Features Demonstrated

### Home Page (`/`)
- Overview of BlazorQueryBuilder capabilities
- Quick start guide
- Feature highlights with visual cards
- Installation and usage instructions

### Examples Page (`/examples`)
- **Full-Featured QueryBuilder**: Complete product catalog example
- **Multiple Filter Types**: Strings, numbers, dates, booleans, selections
- **Real-time Events**: See JSON rules update as you build queries
- **Interactive Controls**: Get rules, clear, validate, load samples
- **Advanced Samples**: Complex nested queries with multiple groups

### Advanced Page (`/advanced`)
- **Minimal Configuration**: Simple QueryBuilder setup
- **Performance Testing**: Async method benchmarking
- **Method Demonstration**: Test all public methods
- **API Reference**: Complete parameter and method documentation
- **Debug Information**: Component state and browser details

## 🎯 Testing Scenarios

### Basic Functionality
1. **Create Simple Rules**:
   - Add a filter condition
   - Set operator and value
   - Verify JSON output

2. **Group Operations**:
   - Add rule groups with AND/OR conditions
   - Nest groups within groups
   - Test complex logical structures

3. **Data Types**:
   - Text input validation
   - Number range validation
   - Date picker functionality
   - Boolean radio buttons
   - Multi-select dropdowns

### Advanced Features
1. **Event Handling**:
   - Watch real-time rule changes
   - Verify event callback functionality

2. **Async Methods**:
   - Test `GetRulesAsync()` performance
   - Validate `SetRulesAsync()` with complex objects
   - Check `ValidateAsync()` with invalid rules
   - Verify `ClearAsync()` functionality

3. **Error Handling**:
   - Create invalid rules to test validation
   - Test edge cases and boundary conditions

## 🔧 Configuration Examples

The test app demonstrates various configuration options:

### Basic Configuration
```csharp
<QueryBuilder @ref="queryBuilder"
              Filters="simpleFilters"
              OnRulesChanged="OnRulesChanged" />
```

### Advanced Configuration
```csharp
<QueryBuilder @ref="queryBuilder"
              Filters="complexFilters"
              Options="customOptions"
              Rules="initialRules"
              OnRulesChanged="OnRulesChanged"
              CssClass="custom-styling" />
```

### Custom Options
```csharp
var options = new QueryBuilderOptions
{
    AllowGroups = true,
    AllowEmpty = false,
    DefaultCondition = "AND",
    DisplayErrors = true,
    Icons = new QueryBuilderIcons
    {
        AddGroup = "bi bi-plus-square",
        AddRule = "bi bi-plus",
        // ... more icons
    }
};
```

## 🎨 Styling and Themes

The test app demonstrates:
- **Bootstrap 5** integration
- **Bootstrap Icons** usage
- **Responsive design** for mobile/desktop
- **Custom CSS classes** and styling

## 📊 Performance Metrics

The advanced page includes performance testing to measure:
- Method execution times
- JavaScript interop latency
- Component rendering performance
- Memory usage patterns

## 🐛 Troubleshooting

### Common Issues

1. **JavaScript Not Loading**:
   - Ensure jQuery and QueryBuilder scripts are loaded
   - Check browser console for script errors
   - Verify CDN links are accessible

2. **Styles Not Applied**:
   - Confirm Bootstrap CSS is loaded
   - Check that QueryBuilder CSS files are included
   - Verify icon fonts are accessible

3. **Component Not Initializing**:
   - Check that `AddBlazorQueryBuilder()` is called in `Program.cs`
   - Ensure proper component reference (`@ref`)
   - Verify filter configuration is valid

### Debug Mode
The advanced page provides debug information including:
- Component initialization state
- Current rule state
- Browser compatibility information
- Performance metrics

## 📝 Example Filter Configurations

### String Filter
```csharp
new QueryBuilderFilter
{
    Id = "name",
    Label = "Product Name",
    Type = "string",
    Placeholder = "Enter product name"
}
```

### Selection Filter
```csharp
new QueryBuilderFilter
{
    Id = "category",
    Label = "Category",
    Type = "string",
    Input = "select",
    Values = new Dictionary<string, string>
    {
        { "electronics", "Electronics" },
        { "clothing", "Clothing" }
    }
}
```

### Number Filter with Validation
```csharp
new QueryBuilderFilter
{
    Id = "price",
    Label = "Price",
    Type = "double",
    Validation = new QueryBuilderValidation
    {
        Min = 0,
        Max = 10000,
        Step = 0.01
    }
}
```

## 🤝 Contributing

This test app serves as both a demonstration and a testing ground for new features. When adding new functionality to BlazorQueryBuilder:

1. Add corresponding test scenarios to this app
2. Update examples to showcase new capabilities
3. Include performance tests for new methods
4. Document new configuration options

---

This test application provides comprehensive coverage of BlazorQueryBuilder features and serves as a practical reference for implementation patterns and best practices.