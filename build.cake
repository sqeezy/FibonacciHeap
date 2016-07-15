var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
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

RunTarget(target);