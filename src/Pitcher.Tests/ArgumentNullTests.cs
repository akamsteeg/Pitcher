using System;
using Xunit;

namespace Pitcher.Tests
{
  public class ArgumentNullTests
  {
    [Fact]
    public void For_Throws()
    {
      Assert.Throws<ArgumentNullException>("TEST", () => Throw.ArgumentNull.For("TEST"));
    }

    [Fact]
    public void For_WithMessage_Throws()
    {
      Assert.Throws<ArgumentNullException>("TEST", () => Throw.ArgumentNull.For("TEST", "message"));
    }

    [Fact]
    public void When_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentNullException>("TEST", () => Throw.ArgumentNull.When(true, "TEST"));
    }

    [Fact]
    public void When_ConditionFalse_DoesNotThrow()
    {
      Throw.ArgumentNull.When(false, "TEST");
    }

    [Fact]
    public void When_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentNullException>("TEST", () => Throw.ArgumentNull.When(true, "TEST", "message"));
    }

    [Fact]
    public void When_WithMessage_ConditionFalse_DoesNotThrow()
    {
      Throw.ArgumentNull.When(false, "TEST", "message");
    }

    [Fact]
    public void WhenNull_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNull(null, "TEST")
      );
    }

    [Fact]
    public void WhenNull_WithObject_DoesNotThrow()
    {
      Throw.ArgumentNull.WhenNull(new object(), "TEST");
    }

    [Fact]
    public void WhenNull_WithNull_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNull(null, parameterName)
      );
    }

    [Fact]
    public void WhenNull_WithMessage_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNull(null, "TEST", "message")
      );
    }

    [Fact]
    public void WhenNull_WithMessage_WithObject_DoesNotThrow()
    {
      Throw.ArgumentNull.WhenNull(new object(), "TEST", "message");
    }

    [Fact]
    public void WhenNull_WithMessage_WithNull_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNull(null, parameterName, "message")
      );
    }

    [Fact]
    public void WhenNull_WithMessage_WithNull_SetCorrectMessageOnException()
    {
      const string parameterName = "TEST";
      const string message = "TESTMESSAGE";

      try
      {
        Throw.ArgumentNull.WhenNull(null, parameterName, message);
      }
      catch (ArgumentNullException e)
      {
        Assert.Contains(message, e.Message);
      }
    }
  }
}
