using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Pitcher.Benchmarks.Benchmarks
{
  public class ThrowTBenchmarks
  {
    [Benchmark]
    public void ThrowException()
    {
      try
      {
        throw new Exception();
      }
      catch
      {

      }
    }

    [Benchmark]
    public void ThrowTNow()
    {
      try
      {
        Throw<Exception>.Now();
      }
      catch
      {

      }
    }

    [Benchmark]
    public void ThrowTWhen()
    {
      try
      {
        Throw<Exception>.When(1 < 2);
      }
      catch
      {

      }
    }
  }
}
