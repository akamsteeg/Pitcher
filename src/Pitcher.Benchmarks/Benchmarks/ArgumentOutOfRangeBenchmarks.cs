using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Pitcher.Benchmarks.Benchmarks
{
  public class ArgumentOutOfRangeBenchmarks
  {
    [Benchmark(Baseline = true)]
    public void IfOutOfRangeThenThrow()
    {
      try
      {
        if (1 < 2)
        {
          throw new ArgumentOutOfRangeException("foo", "bar");
        }
      }
      catch
      {
      }
    }

    [Benchmark]
    public void ThrowArgumentOutOfRangeFor()
    {
      try
      {
        Throw.ArgumentOutOfRange.For("foo", "bar");
      }
      catch
      {
      }
    }

    [Benchmark]
    public void ThrowArgumentOutOfRangeWhen()
    {
      try
      {
        Throw.ArgumentOutOfRange.When(1 < 2, "foo", "bar");
      }
      catch
      {
      }
    }
  }
}
