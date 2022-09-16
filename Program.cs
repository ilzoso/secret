// See https://aka.ms/new-console-template for more information
using secret;
using System.Reflection;

Console.WriteLine("Hello, World!");

Console.WriteLine(args.Length > 0 ? args[0] : "nothing to see here...");
Console.WriteLine("... " + Environment.GetEnvironmentVariable("KEY"));

string[] resNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
foreach (string resName in resNames)
{
    Console.WriteLine($"Resource = {resName}");
    var rc = ResourceUtil.GetEmbeddedResourceContent(resName);
    Console.WriteLine($"{rc}");
}

