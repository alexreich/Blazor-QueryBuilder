#!/bin/bash

echo "🚀 Starting BlazorQueryBuilder Demo"
echo "=================================="

# Build the solution
echo "📦 Building BlazorQueryBuilder solution..."
cd ../
dotnet build

if [ $? -eq 0 ]; then
    echo "✅ Solution built successfully!"
    
    # Run the demo
    echo "🎯 Starting demo application..."
    echo "🌐 Open http://localhost:5000 in your browser"
    cd BlazorQueryBuilder.Demo
    dotnet run
else
    echo "❌ Solution build failed!"
    exit 1
fi