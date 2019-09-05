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

      config.Add(BenchmarkDotNet.Diagnosers.MemoryDiagnoser.Default);

      config.Add(Job.ShortRun.With(CsProjCoreToolchain.NetCoreApp20).AsBaseline());
      config.Add(Job.ShortRun.With(CsProjCoreToolchain.NetCoreApp30));
      config.Add(Job.ShortRun.With(CsProjClassicNetToolchain.Net47));

      return config;
    }
  }
}