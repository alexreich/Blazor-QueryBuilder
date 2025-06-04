using System.Text.Json.Serialization;

namespace BlazorQueryBuilder.Models
{
    /// <summary>
    /// Represents a filter definition for the QueryBuilder
    /// </summary>
    public class QueryBuilderFilter
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("label")]
        public string Label { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = "string";

        [JsonPropertyName("input")]
        public string? Input { get; set; }

        [JsonPropertyName("values")]
        public Dictionary<string, string>? Values { get; set; }

        [JsonPropertyName("operators")]
        public string[]? Operators { get; set; }

        [JsonPropertyName("validation")]
        public QueryBuilderValidation? Validation { get; set; }

        [JsonPropertyName("placeholder")]
        public string? Placeholder { get; set; }

        [JsonPropertyName("multiple")]
        public bool? Multiple { get; set; }

        [JsonPropertyName("optgroup")]
        public string? Optgroup { get; set; }

        [JsonPropertyName("icon")]
        public string? Icon { get; set; }
    }

    /// <summary>
    /// Validation rules for a filter
    /// </summary>
    public class QueryBuilderValidation
    {
        [JsonPropertyName("min")]
        public object? Min { get; set; }

        [JsonPropertyName("max")]
        public object? Max { get; set; }

        [JsonPropertyName("step")]
        public object? Step { get; set; }

        [JsonPropertyName("format")]
        public string? Format { get; set; }

        [JsonPropertyName("messages")]
        public Dictionary<string, string>? Messages { get; set; }
    }

    /// <summary>
    /// QueryBuilder options configuration
    /// </summary>
    public class QueryBuilderOptions
    {
        [JsonPropertyName("allow_groups")]
        public object? AllowGroups { get; set; } = true;

        [JsonPropertyName("allow_empty")]
        public bool? AllowEmpty { get; set; } = false;

        [JsonPropertyName("default_condition")]
        public string? DefaultCondition { get; set; } = "AND";

        [JsonPropertyName("display_errors")]
        public bool? DisplayErrors { get; set; } = true;

        [JsonPropertyName("display_empty_filter")]
        public bool? DisplayEmptyFilter { get; set; } = true;

        [JsonPropertyName("select_placeholder")]
        public string? SelectPlaceholder { get; set; } = "------";

        [JsonPropertyName("operators")]
        public QueryBuilderOperator[]? Operators { get; set; }

        [JsonPropertyName("plugins")]
        public Dictionary<string, object?>? Plugins { get; set; }

        [JsonPropertyName("icons")]
        public QueryBuilderIcons? Icons { get; set; }

        [JsonPropertyName("lang")]
        public Dictionary<string, object>? Lang { get; set; }

        [JsonPropertyName("lang_code")]
        public string? LangCode { get; set; } = "en";
    }

    /// <summary>
    /// Operator definition
    /// </summary>
    public class QueryBuilderOperator
    {
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("optgroup")]
        public string? Optgroup { get; set; }

        [JsonPropertyName("nb_inputs")]
        public int? NbInputs { get; set; }

        [JsonPropertyName("apply_to")]
        public string[]? ApplyTo { get; set; }
    }

    /// <summary>
    /// Icon configuration
    /// </summary>
    public class QueryBuilderIcons
    {
        [JsonPropertyName("add_group")]
        public string? AddGroup { get; set; } = "bi bi-plus-square";

        [JsonPropertyName("add_rule")]
        public string? AddRule { get; set; } = "bi bi-plus";

        [JsonPropertyName("remove_group")]
        public string? RemoveGroup { get; set; } = "bi bi-x-square";

        [JsonPropertyName("remove_rule")]
        public string? RemoveRule { get; set; } = "bi bi-x";

        [JsonPropertyName("error")]
        public string? Error { get; set; } = "bi bi-exclamation-triangle";
    }

    /// <summary>
    /// Rule structure for QueryBuilder
    /// </summary>
    public class QueryBuilderRule
    {
        [JsonPropertyName("condition")]
        public string? Condition { get; set; } = "AND";

        [JsonPropertyName("rules")]
        public List<object>? Rules { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("field")]
        public string? Field { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("input")]
        public string? Input { get; set; }

        [JsonPropertyName("operator")]
        public string? Operator { get; set; }

        [JsonPropertyName("value")]
        public object? Value { get; set; }
    }
}