using System;
using BenchmarkDotNet.Attributes;

namespace Pitcher.Benchmarks.Benchmarks
{
  public class ThrowBenchmarks
  {
    [Benchmark(Baseline = true)]
    public void ThrowException()
    {
      try
      {
        throw new Exception("foo");
      }
      catch
      {

      }
    }

    [Benchmark]
    public void ThrowThis()
    {
      try
      {
        Throw.This(new Exception("foo"));
      }
      catch
      {

      }
    }

    [Benchmark]
    public void ThrowWhen()
    {
      try
      {
        Throw.When(1 < 2, new Exception("foo"));
      }
      catch
      {
      }
    }
  }
}
