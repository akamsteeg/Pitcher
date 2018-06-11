using System;
using Xunit;

namespace Pitcher.Tests
{
  public class ArgumentOutOfRangeTests
  {
    [Fact]
    public void For_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.For("TEST"));
    }

    [Fact]
    public void For_WithMessage_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.For("TEST", "message"));
    }

    [Fact]
    public void When_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.When(true, "TEST"));
    }

    [Fact]
    public void When_ConditionFalse_DoesNotThrow()
    {
      Throw.ArgumentNull.When(false, "TEST");
    }

    [Fact]
    public void When_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.When(true, "TEST", "message"));
    }

    [Fact]
    public void When_WithMessage_ConditionFalse_DoesNotThrow()
    {
      Throw.ArgumentNull.When(false, "TEST", "message");
    }
  }
}
