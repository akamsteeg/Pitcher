using System;
using BenchmarkDotNet.Attributes;

namespace Pitcher.Benchmarks.Benchmarks
{
  public class ArgumentNullBenchmarks
  {
    [Benchmark]
    public void IfNullThenThrow()
    {
      try
      {
        object obj = null;

        if (obj == null)
        {
          throw new ArgumentNullException(nameof(obj));
        }
      }
      catch
      {
      }
    }

    [Benchmark]
    public void ThrowArgumentNullFor()
    {
      try
      {
        object obj = null;

        Throw.ArgumentNull.For(nameof(obj));
      }
      catch
      {
      }
    }

    [Benchmark]
    public void ThrowArgumentNullWhen()
    {
      try
      {
        object obj = null;

        Throw.ArgumentNull.When(obj == null, nameof(obj));
      }
      catch
      {
      }
    }

    [Benchmark]
    public void ThrowArgumentNullWhenNull()
    {
      try
      {
        object obj = null;

        Throw.ArgumentNull.WhenNull(obj, nameof(obj));
      }
      catch
      {
      }
    }
  }
}
