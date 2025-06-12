@echo off
echo 🚀 Starting BlazorQueryBuilder Demo
echo ==================================

rem Build the solution
echo 📦 Building BlazorQueryBuilder solution...
cd ../
dotnet build

if %ERRORLEVEL% EQU 0 (
    echo ✅ Solution built successfully!
    
    rem Run the demo
    echo 🎯 Starting demo application...
    echo 🌐 Open http://localhost:5000 in your browser
    cd BlazorQueryBuilder.Demo
    dotnet run
) else (
    echo ❌ Solution build failed!
    exit /b 1
)