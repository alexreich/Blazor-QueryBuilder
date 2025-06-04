using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Text.Json;

namespace BlazorQueryBuilder.Components
{
    /// <summary>
    /// Blazor wrapper component for jQuery QueryBuilder
    /// </summary>
    public partial class QueryBuilder : ComponentBase, IAsyncDisposable
    {
        [Inject] public IJSRuntime JSRuntime { get; set; } = default!;
        
        [Parameter] public string Id { get; set; } = $"querybuilder_{Guid.NewGuid():N}";
        [Parameter] public object? Options { get; set; }
        [Parameter] public object? Filters { get; set; }
        [Parameter] public object? Rules { get; set; }
        [Parameter] public EventCallback<string> OnRulesChanged { get; set; }
        [Parameter] public string CssClass { get; set; } = "";
        
        private IJSObjectReference? _jsModule;
        private DotNetObjectReference<QueryBuilder>? _dotNetRef;
        private bool _initialized = false;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                _dotNetRef = DotNetObjectReference.Create(this);
                _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./_content/BlazorQueryBuilder/js/blazor-querybuilder-interop.js");
                
                var options = new
                {
                    filters = Filters,
                    rules = Rules,
                    options = Options
                };
                
                await _jsModule.InvokeVoidAsync("initialize", Id, options, _dotNetRef);
                _initialized = true;
            }
        }

        [JSInvokable]
        public async Task OnRulesChangedCallback(string rules)
        {
            if (OnRulesChanged.HasDelegate)
            {
                await OnRulesChanged.InvokeAsync(rules);
            }
        }

        /// <summary>
        /// Get the current rules from the QueryBuilder
        /// </summary>
        public async Task<string> GetRulesAsync()
        {
            if (_jsModule != null && _initialized)
            {
                return await _jsModule.InvokeAsync<string>("getRules", Id);
            }
            return "{}";
        }

        /// <summary>
        /// Set rules in the QueryBuilder
        /// </summary>
        public async Task SetRulesAsync(object rules)
        {
            if (_jsModule != null && _initialized)
            {
                await _jsModule.InvokeVoidAsync("setRules", Id, rules);
            }
        }

        /// <summary>
        /// Clear all rules
        /// </summary>
        public async Task ClearAsync()
        {
            if (_jsModule != null && _initialized)
            {
                await _jsModule.InvokeVoidAsync("clear", Id);
            }
        }

        /// <summary>
        /// Validate the current rules
        /// </summary>
        public async Task<bool> ValidateAsync()
        {
            if (_jsModule != null && _initialized)
            {
                return await _jsModule.InvokeAsync<bool>("validate", Id);
            }
            return false;
        }

        public async ValueTask DisposeAsync()
        {
            if (_jsModule != null)
            {
                await _jsModule.InvokeVoidAsync("dispose", Id);
                await _jsModule.DisposeAsync();
            }
            _dotNetRef?.Dispose();
        }
    }
}