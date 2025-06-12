# Blazor QueryBuilder Test App Runner (PowerShell)
# This script builds and runs the test application to demonstrate the QueryBuilder in action

Write-Host "🔍 Blazor QueryBuilder Test Application" -ForegroundColor Cyan
Write-Host "======================================" -ForegroundColor Cyan
Write-Host ""

# Check if we're in the right directory
if (-not (Test-Path "BlazorQueryBuilder.TestApp.csproj")) {
    Write-Host "❌ Error: Please run this script from the BlazorQueryBuilder.TestApp directory" -ForegroundColor Red
    Write-Host "📁 Expected path: BlazorQueryBuilder\BlazorQueryBuilder.TestApp\" -ForegroundColor Yellow
    exit 1
}

Write-Host "📁 Current directory: $(Get-Location)" -ForegroundColor Green
Write-Host ""

# Check .NET SDK
Write-Host "🔍 Checking .NET SDK..." -ForegroundColor Blue
try {
    $dotnetVersion = & dotnet --version 2>$null
    if ($LASTEXITCODE -eq 0) {
        Write-Host "✅ .NET SDK found: $dotnetVersion" -ForegroundColor Green
    } else {
        throw "dotnet command failed"
    }
} catch {
    Write-Host "❌ Error: .NET SDK not found. Please install .NET 8.0 SDK" -ForegroundColor Red
    Write-Host "📥 Download from: https://dotnet.microsoft.com/download/dotnet/8.0" -ForegroundColor Yellow
    exit 1
}
Write-Host ""

# Build the library first
Write-Host "🔨 Building BlazorQueryBuilder library..." -ForegroundColor Blue
Set-Location ".."
$buildResult = & dotnet build --configuration Release
if ($LASTEXITCODE -eq 0) {
    Write-Host "✅ Library build successful" -ForegroundColor Green
} else {
    Write-Host "❌ Library build failed" -ForegroundColor Red
    exit 1
}
Write-Host ""

# Build the test app
Write-Host "🔨 Building test application..." -ForegroundColor Blue
Set-Location "BlazorQueryBuilder.TestApp"
$buildResult = & dotnet build --configuration Release
if ($LASTEXITCODE -eq 0) {
    Write-Host "✅ Test app build successful" -ForegroundColor Green
} else {
    Write-Host "❌ Test app build failed" -ForegroundColor Red
    exit 1
}
Write-Host ""

# Run the application
Write-Host "🚀 Starting Blazor QueryBuilder Test Application..." -ForegroundColor Magenta
Write-Host ""
Write-Host "📋 Test Scenarios to Try:" -ForegroundColor Yellow
Write-Host "   1. Home page - Overview and quick start guide"
Write-Host "   2. Examples page - Interactive QueryBuilder with samples"
Write-Host "   3. Advanced page - Performance testing and API demo"
Write-Host ""
Write-Host "🎯 Key Features to Test:" -ForegroundColor Yellow
Write-Host "   • Create simple rules with different data types"
Write-Host "   • Add nested groups with AND/OR conditions"
Write-Host "   • Load sample data and complex queries"
Write-Host "   • Test async methods and performance"
Write-Host "   • Real-time rule change events"
Write-Host ""
Write-Host "🌐 The application will be available at: http://localhost:5000" -ForegroundColor Cyan
Write-Host "🛑 Press Ctrl+C to stop the application" -ForegroundColor Yellow
Write-Host ""
Write-Host "Starting server..." -ForegroundColor Green

# Start the application
& dotnet run --configuration Release