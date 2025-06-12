#!/bin/bash

echo "🚀 Starting BlazorQueryBuilder Demo"
echo "=================================="

# Build the package first
echo "📦 Building BlazorQueryBuilder package..."
cd ../
dotnet build --configuration Release

if [ $? -eq 0 ]; then
    echo "✅ Package built successfully!"
    
    # Run the demo
    echo "🎯 Starting demo application..."
    cd BlazorQueryBuilder.Demo
    dotnet run
else
    echo "❌ Package build failed!"
    exit 1
fi