var target = Argument("target", "Default");
var outputDir = "./bin";

Task("Default")
  .IsDependentOn("Test");

Task("Test")
  .IsDependentOn("Build")
  .Does(()=>
  {
    DotNetTest("./src/FibonacciHeap.Tests/FibonacciHeap.Tests.csproj");
  });

Task("Build")
  .IsDependentOn("NugetRestore")
  .Does(()=>
  {
    var settings = new DotNetBuildSettings{Configuration = "Release"};
    DotNetBuild("FibonacciHeap.sln", settings);
  });

Task("NugetRestore")
  .IsDependentOn("Clean")
  .Does(()=>
  {
    DotNetRestore();
  });

Task("Publish-NuGet")
  .IsDependentOn("Build")
  .Does(() =>
{
  // Resolve the API key.
  var apiKey = EnvironmentVariable("NUGET_API_KEY");
  if(string.IsNullOrEmpty(apiKey)) {
    throw new InvalidOperationException("Could not resolve NuGet API key.");
  }

  // Resolve the API url.
  var apiUrl = EnvironmentVariable("NUGET_API_URL");
  if(string.IsNullOrEmpty(apiUrl)) {
    throw new InvalidOperationException("Could not resolve NuGet API url.");
  }

  var packagePath = GetFiles("./src/FibonacciHeap/bin/Release/FibonacciHeap.*.nupkg")
                      .Single()
                      .FullPath;
  Information($"Publish {packagePath}");
  // Push the package.
  NuGetPush(packagePath, new NuGetPushSettings {
    ApiKey = apiKey,
    Source = apiUrl
  });
});

Task("Clean")
  .Does(()=>
  {
    CleanDirectories("**/bin/**");
    CleanDirectories("**/obj/**");
    CleanDirectories("nupkgs");
  });

RunTarget(target);