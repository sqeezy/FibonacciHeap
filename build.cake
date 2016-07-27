var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  NuGetRestore("./");
  if(IsRunningOnUnix())
  {
      XBuild("FibonacciHeap.sln",new XBuildSettings().WithProperty("POSIX","True"));
  }
  else
  {
      MSBuild("FibonacciHeap.sln");
  }
});

RunTarget(target);