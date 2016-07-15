var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  if(IsRunningOnUnix())
  {
      XBuild("FibonacciHeap.Sln",new XBuildSettings().WithProperty("POSIX","True"));
  }
  else
  {
      MSBuild("FibonacciHeap.Sln");
  }
});

RunTarget(target);
