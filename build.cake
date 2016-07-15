var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  if(IsRunningOnUnix())
  {
      XBuild("FibonacciHeap.Sln").WithProperty("POSIX","True");
  }
  else
  {
      MSBuild("FibonacciHeap.Sln");
  }
});

RunTarget(target);
