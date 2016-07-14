var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  MSBuild("FibonacciHeap.Sln");
});

RunTarget(target);