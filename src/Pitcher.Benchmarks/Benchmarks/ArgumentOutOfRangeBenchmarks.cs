using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Pitcher.Benchmarks.Benchmarks
{
  public class ArgumentOutOfRangeBenchmarks
  {
    [Benchmark]
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

    [Benchmark]
    public void ThrowArgumentOutOfRangeWhenNegativeNumber()
    {
      try
      {
        Throw.ArgumentOutOfRange.WhenNegativeNumber(-1, "foo", "bar");
      }
      catch
      {
      }
    }

    [Benchmark]
    public void ThrowArgumentOutOfRangeWhenPositiveNumber()
    {
      try
      {
        Throw.ArgumentOutOfRange.WhenNegativeNumber(1, "foo", "bar");
      }
      catch
      {
      }
    }

    [Benchmark]
    public void ThrowArgumentOutOfRangeWhenLessThan()
    {
      try
      {
        Throw.ArgumentOutOfRange.WhenLessThan(0, 1, "foo", "bar");
      }
      catch
      {
      }
    }

    [Benchmark]
    public void ThrowArgumentOutOfRangeWhenMoreThan()
    {
      try
      {
        Throw.ArgumentOutOfRange.WhenMoreThan(1, 0, "foo", "bar");
      }
      catch
      {
      }
    }
  }
}
