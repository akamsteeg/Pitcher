using System.Reflection;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;

namespace Pitcher.Benchmarks
{
  internal static class Program
  {
    private static void Main(string[] args)
    {
      var config = GetConfig();
      BenchmarkRunner.Run(Assembly.GetExecutingAssembly(), config);
    }

    private static IConfig GetConfig()
    {
      var config = ManualConfig.Create(DefaultConfig.Instance);

      config
        .AddDiagnoser(BenchmarkDotNet.Diagnosers.MemoryDiagnoser.Default);

      config.AddJob(
        Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp60).AsBaseline(),
        Job.Default.WithToolchain(CsProjCoreToolchain.NetCoreApp31)
        Job.Default.WithToolchain(CsProjClassicNetToolchain.Net48)
        );

      return config;
    }
  }
}