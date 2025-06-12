#!/bin/bash

# Blazor QueryBuilder Test App Runner
# This script builds and runs the test application to demonstrate the QueryBuilder in action

set -e

echo "🔍 Blazor QueryBuilder Test Application"
echo "======================================"
echo ""

# Check if we're in the right directory
if [ ! -f "BlazorQueryBuilder.TestApp.csproj" ]; then
    echo "❌ Error: Please run this script from the BlazorQueryBuilder.TestApp directory"
    echo "📁 Expected path: BlazorQueryBuilder/BlazorQueryBuilder.TestApp/"
    exit 1
fi

echo "📁 Current directory: $(pwd)"
echo ""

# Check .NET SDK
echo "🔍 Checking .NET SDK..."
if ! command -v dotnet &> /dev/null; then
    echo "❌ Error: .NET SDK not found. Please install .NET 8.0 SDK"
    echo "📥 Download from: https://dotnet.microsoft.com/download/dotnet/8.0"
    exit 1
fi

DOTNET_VERSION=$(dotnet --version)
echo "✅ .NET SDK found: $DOTNET_VERSION"
echo ""

# Build the library first
echo "🔨 Building BlazorQueryBuilder library..."
cd ../
if dotnet build --configuration Release; then
    echo "✅ Library build successful"
else
    echo "❌ Library build failed"
    exit 1
fi
echo ""

# Build the test app
echo "🔨 Building test application..."
cd BlazorQueryBuilder.TestApp/
if dotnet build --configuration Release; then
    echo "✅ Test app build successful"
else
    echo "❌ Test app build failed"
    exit 1
fi
echo ""

# Run the application
echo "🚀 Starting Blazor QueryBuilder Test Application..."
echo ""
echo "📋 Test Scenarios to Try:"
echo "   1. Home page - Overview and quick start guide"
echo "   2. Examples page - Interactive QueryBuilder with samples"
echo "   3. Advanced page - Performance testing and API demo"
echo ""
echo "🎯 Key Features to Test:"
echo "   • Create simple rules with different data types"
echo "   • Add nested groups with AND/OR conditions"
echo "   • Load sample data and complex queries"
echo "   • Test async methods and performance"
echo "   • Real-time rule change events"
echo ""
echo "🌐 The application will open in your default browser"
echo "🛑 Press Ctrl+C to stop the application"
echo ""
echo "Starting server..."

# Start the application
dotnet run --configuration Release