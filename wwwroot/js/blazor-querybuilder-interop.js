// Blazor QueryBuilder JavaScript Interop
window.blazorQueryBuilder = window.blazorQueryBuilder || {};

// Store component instances
window.blazorQueryBuilder.instances = {};

export function initialize(elementId, config, dotNetHelper) {
    const element = document.getElementById(elementId);
    if (!element) {
        console.error(`Element with id '${elementId}' not found`);
        return;
    }

    // Load jQuery QueryBuilder if not already loaded
    if (typeof $ === 'undefined' || !$.fn.queryBuilder) {
        console.error('jQuery QueryBuilder not loaded. Please include the query-builder.js file.');
        return;
    }

    // Initialize QueryBuilder
    const options = {
        ...config.options,
        filters: config.filters || [],
        rules: config.rules || {}
    };

    const $element = $(element);
    $element.queryBuilder(options);

    // Store instance reference
    window.blazorQueryBuilder.instances[elementId] = {
        element: $element,
        dotNetHelper: dotNetHelper
    };

    // Set up event handlers
    $element.on('rulesChanged.queryBuilder', function() {
        if (dotNetHelper) {
            const rules = $element.queryBuilder('getRules');
            dotNetHelper.invokeMethodAsync('OnRulesChangedCallback', JSON.stringify(rules));
        }
    });
}

export function getRules(elementId) {
    const instance = window.blazorQueryBuilder.instances[elementId];
    if (instance) {
        const rules = instance.element.queryBuilder('getRules');
        return JSON.stringify(rules);
    }
    return '{}';
}

export function setRules(elementId, rules) {
    const instance = window.blazorQueryBuilder.instances[elementId];
    if (instance) {
        instance.element.queryBuilder('setRules', rules);
    }
}

export function clear(elementId) {
    const instance = window.blazorQueryBuilder.instances[elementId];
    if (instance) {
        instance.element.queryBuilder('reset');
    }
}

export function validate(elementId) {
    const instance = window.blazorQueryBuilder.instances[elementId];
    if (instance) {
        return instance.element.queryBuilder('validate');
    }
    return false;
}

export function dispose(elementId) {
    const instance = window.blazorQueryBuilder.instances[elementId];
    if (instance) {
        instance.element.queryBuilder('destroy');
        delete window.blazorQueryBuilder.instances[elementId];
    }
}