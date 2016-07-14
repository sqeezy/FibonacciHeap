var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  if(IsRunningOnUnix())
  {
      XBuild("FibonacciHeap.Sln");
  }
  else
  {
      MSBuild("FibonacciHeap.Sln");
  }
});

RunTarget(target);