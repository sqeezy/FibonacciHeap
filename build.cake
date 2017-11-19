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
  .IsDependentOn("NugetRestore")
  .Does(()=>
  {
    DotNetCoreMSBuild("FibonacciHeap.sln");
  });

Task("NugetRestore")
  .IsDependentOn("Clean")
  .Does(()=>
  {
    DotNetCoreRestore();
  });

Task("NugetPack")
  .IsDependentOn("Clean")
  .Does(()=>
  {
    var settings = new DotNetCorePackSettings
    {
      Configuration = "Release",
      OutputDirectory = "nupkgs"
    };

    DotNetCorePack("src/FibonacciHeap", settings);
  });

Task("Clean")
  .Does(()=>
  {
    CleanDirectories("**/bin/**");
    CleanDirectories("**/obj/**");
    CleanDirectories("nupkgs");
  });

RunTarget(target);