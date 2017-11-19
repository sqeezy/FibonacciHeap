#tool "nuget:?package=xunit.runner.console"

var target = Argument("target", "Default");
var outputDir = "./bin";

Task("Default")
  .IsDependentOn("Xunit")
  .Does(() =>
{
});

Task("Xunit")
  .IsDependentOn("Build")
  .Does(()=>
  {
    DotNetCoreTest("./src/FibonacciHeap.Tests/FibonacciHeap.Tests.csproj");
  });

Task("Build")
  .IsDependentOn("Nuget")
  .Does(()=>
  {
    DotNetCoreMSBuild("FibonacciHeap.sln");
  });

Task("Nuget")
  .IsDependentOn("Clean")
  .Does(()=>
  {
    DotNetCoreRestore();
  });

Task("Clean")
  .Does(()=>
  {
    CleanDirectories(outputDir+"/**");
  });

RunTarget(target);