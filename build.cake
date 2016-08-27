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
    XUnit2(outputDir+"/**/*.Tests.dll");
  });

Task("Build")
  .IsDependentOn("NuGet-Restore")
  .Does(()=>
  {
    if(IsRunningOnUnix())
    {
        XBuild("FibonacciHeap.sln",new XBuildSettings().WithProperty("POSIX","True"));
    }
    else
    {
      MSBuild("FibonacciHeap.sln", new MSBuildSettings {
        Configuration = "Release",
        Verbosity = Verbosity.Minimal
      });
    }
  });

Task("NuGet-Restore")
  .IsDependentOn("Clean")
  .Does(()=>
  {
    NuGetRestore("./", new NuGetRestoreSettings {
          Verbosity = NuGetVerbosity.Quiet
    });
  });

Task("Clean")
  .Does(()=>
  {
    CleanDirectory(outputDir);
  });

RunTarget(target);