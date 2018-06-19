using System;
using Xunit;

namespace Pitcher.Tests
{
  public class ThrowTTests
  {
    [Fact]
    public void Now_Throws()
    {
      Assert.ThrowsAny<Exception>(() => Throw<Exception>.Now());
    }

    [Fact]
    public void When_ConditionTrue_Throws()
    {
      Assert.ThrowsAny<Exception>(() => Throw<Exception>.When(true));
    }

    [Fact]
    public void When_ConditionFalse_DoesNotThrow()
    {
      Throw<Exception>.When(false);
    }
  }
}
