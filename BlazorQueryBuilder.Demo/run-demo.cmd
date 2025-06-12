@echo off
echo 🚀 Starting BlazorQueryBuilder Demo
echo ==================================

rem Build the package first
echo 📦 Building BlazorQueryBuilder package...
cd ../
dotnet build --configuration Release

if %ERRORLEVEL% EQU 0 (
    echo ✅ Package built successfully!
    
    rem Run the demo
    echo 🎯 Starting demo application...
    cd BlazorQueryBuilder.Demo
    dotnet run
) else (
    echo ❌ Package build failed!
    exit /b 1
)