var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
});

Task("Build")
  .IsDependentOn("Nuget")
  .Does(()=>
  {
    if(IsRunningOnUnix())
    {
        XBuild("FibonacciHeap.sln",new XBuildSettings().WithProperty("POSIX","True"));
    }
    else
    {
        MSBuild("FibonacciHeap.sln");
    }
  });

Task("Nuget")
  .IsDependentOn("Clean")
  .Does(()=>
  {
    NuGetRestore("./");
  });

Task("Clean")
  .Does(()=>
  {

  });

RunTarget(target);