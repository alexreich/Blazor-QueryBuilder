# Blazor QueryBuilder

A Blazor component wrapper for the popular jQuery QueryBuilder library, providing a user-friendly interface for building complex queries in Blazor applications.

## Features

- Full Blazor component integration with JavaScript interop
- Strongly-typed C# models for configuration
- Bootstrap 5 compatible styling
- Support for all original jQuery QueryBuilder features
- Event callbacks for rule changes
- Async methods for programmatic control

## Installation

```bash
dotnet add package BlazorQueryBuilder
```

## Setup

1. **Add the service** (optional, for future extensibility):
```csharp
builder.Services.AddBlazorQueryBuilder();
```

2. **Include required CSS and JS files** in your `_Host.cshtml` or `index.html`:
```html
<!-- jQuery (required) -->
<script src="https://code.jquery.com/jquery-3.7.1.min.js"></script>

<!-- Bootstrap 5 CSS (recommended) -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">

<!-- Bootstrap Icons (recommended) -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.0/font/bootstrap-icons.css" rel="stylesheet">

<!-- QueryBuilder CSS -->
<link href="_content/BlazorQueryBuilder/css/query-builder.default.css" rel="stylesheet" />

<!-- QueryBuilder JS -->
<script src="_content/BlazorQueryBuilder/js/query-builder.standalone.js"></script>
```

3. **Add the using statement** in your `_Imports.razor`:
```csharp
@using BlazorQueryBuilder.Components
@using BlazorQueryBuilder.Models
```

## Basic Usage

```razor
@page "/querybuilder"
@using BlazorQueryBuilder.Components
@using BlazorQueryBuilder.Models

<h3>Query Builder Example</h3>

<QueryBuilder @ref="queryBuilder"
              Filters="filters"
              Options="options"
              OnRulesChanged="OnRulesChanged" />

<div class="mt-3">
    <button class="btn btn-primary" @onclick="GetRules">Get Rules</button>
    <button class="btn btn-secondary" @onclick="ClearRules">Clear</button>
</div>

@if (!string.IsNullOrEmpty(currentRules))
{
    <div class="mt-3">
        <h5>Current Rules:</h5>
        <pre>@currentRules</pre>
    </div>
}

@code {
    private QueryBuilder queryBuilder = default!;
    private string currentRules = "";

    private readonly QueryBuilderFilter[] filters = new[]
    {
        new QueryBuilderFilter
        {
            Id = "name",
            Label = "Name",
            Type = "string"
        },
        new QueryBuilderFilter
        {
            Id = "category",
            Label = "Category",
            Type = "string",
            Input = "select",
            Values = new Dictionary<string, string>
            {
                { "books", "Books" },
                { "movies", "Movies" },
                { "music", "Music" }
            }
        },
        new QueryBuilderFilter
        {
            Id = "price",
            Label = "Price",
            Type = "double",
            Validation = new QueryBuilderValidation
            {
                Min = 0,
                Step = 0.01
            }
        }
    };

    private readonly QueryBuilderOptions options = new()
    {
        AllowGroups = true,
        AllowEmpty = false
    };

    private async Task OnRulesChanged(string rules)
    {
        currentRules = rules;
        Console.WriteLine($"Rules changed: {rules}");
    }

    private async Task GetRules()
    {
        currentRules = await queryBuilder.GetRulesAsync();
    }

    private async Task ClearRules()
    {
        await queryBuilder.ClearAsync();
        currentRules = "";
    }
}
```

## Advanced Configuration

### Custom Operators

```csharp
var options = new QueryBuilderOptions
{
    Operators = new[]
    {
        new QueryBuilderOperator { Type = "equal" },
        new QueryBuilderOperator { Type = "not_equal" },
        new QueryBuilderOperator { Type = "contains" },
        new QueryBuilderOperator { Type = "begins_with" },
        new QueryBuilderOperator { Type = "ends_with" }
    }
};
```

### Custom Icons

```csharp
var options = new QueryBuilderOptions
{
    Icons = new QueryBuilderIcons
    {
        AddGroup = "bi bi-plus-circle",
        AddRule = "bi bi-plus",
        RemoveGroup = "bi bi-dash-circle",
        RemoveRule = "bi bi-trash",
        Error = "bi bi-exclamation-triangle"
    }
};
```

### Internationalization

```csharp
var options = new QueryBuilderOptions
{
    LangCode = "fr",
    Lang = new Dictionary<string, object>
    {
        { "add_rule", "Ajouter une règle" },
        { "add_group", "Ajouter un groupe" },
        { "delete_rule", "Supprimer" },
        { "delete_group", "Supprimer" }
    }
};
```

## API Reference

### QueryBuilder Component

| Parameter | Type | Description |
|-----------|------|-------------|
| `Id` | `string` | Unique identifier for the component |
| `Filters` | `object` | Filter definitions |
| `Options` | `object` | QueryBuilder options |
| `Rules` | `object` | Initial rules |
| `OnRulesChanged` | `EventCallback<string>` | Callback when rules change |
| `CssClass` | `string` | Additional CSS classes |

### Methods

| Method | Description |
|--------|-------------|
| `GetRulesAsync()` | Get current rules as JSON string |
| `SetRulesAsync(object rules)` | Set rules programmatically |
| `ClearAsync()` | Clear all rules |
| `ValidateAsync()` | Validate current rules |

## License

MIT License - see [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please read our contributing guidelines and submit pull requests to our GitHub repository.

## Support

For support, please open an issue on our [GitHub repository](https://github.com/alexreich/Blazor-QueryBuilder).