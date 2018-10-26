var target = Argument("target", "Default");
var outputDir = "./bin";

Task("Default")
  .IsDependentOn("Xunit");

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
    var settings = new DotNetCoreBuildSettings{Configuration = "Release"};
    DotNetCoreBuild("FibonacciHeap.sln", settings);
  });

Task("NugetRestore")
  .IsDependentOn("Clean")
  .Does(()=>
  {
    DotNetCoreRestore();
  });

Task("Clean")
  .Does(()=>
  {
    CleanDirectories("**/bin/**");
    CleanDirectories("**/obj/**");
    CleanDirectories("nupkgs");
  });

RunTarget(target);