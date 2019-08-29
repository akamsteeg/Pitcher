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

    #region Throw.ArgumentOutOfRange.WhenNegativeNumber

    [Fact]
    public void WhenNegativeNumber_Int_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenNegativeNumber(-1, "TEST"));
    }

    [Fact]
    public void WhenNegativeNumber_Int_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenNegativeNumber(-1, "TEST", "message"));
    }

    [Fact]
    public void WhenZeroNumber_Int_WithZero_DoesNotThrow()
    {
      Throw.ArgumentOutOfRange.WhenNegativeNumber(0, "TEST");
    }

    [Fact]
    public void WhenZeroNumbe_Int_WithZero_WithMesssage_WithZero_DoesNotThrow()
    {
      Throw.ArgumentOutOfRange.WhenNegativeNumber(0, "TEST", "message");
    }

    [Fact]
    public void WhenZeroNumber_Int_WithPositive_DoesNotThrow()
    {
      Throw.ArgumentOutOfRange.WhenNegativeNumber(1, "TEST");
    }

    [Fact]
    public void WhenZeroNumbe_Int_WithPositive__WithMesssage_WithZero_DoesNotThrow()
    {
      Throw.ArgumentOutOfRange.WhenNegativeNumber(1, "TEST", "message");
    }

    [Fact]
    public void WhenNegativeNumber_Double_WithZero_DoesNotThrow()
    {
      Throw.ArgumentOutOfRange.WhenNegativeNumber(0D, "TEST");
    }

    [Fact]
    public void WhenNegativeNumber_Int_WithDoubleZero_WithMesssage_WithZero_DoesNotThrow()
    {
      Throw.ArgumentOutOfRange.WhenNegativeNumber(0D, "TEST", "message");
    }

    [Fact]
    public void WhenNegativeNumber_Double_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenNegativeNumber(-1D, "TEST"));
    }

    [Fact]
    public void WhenNegativeNumber_Double_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenNegativeNumber(-1D, "TEST", "message"));
    }


    [Fact]
    public void WhenNegativeNumber_Float_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenNegativeNumber(-1f, "TEST"));
    }

    [Fact]
    public void WhenNegativeNumber_Float_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenNegativeNumber(-1f, "TEST", "message"));
    }

    [Fact]
    public void WhenNegativeNumber_Decimal_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenNegativeNumber(-1m, "TEST"));
    }

    [Fact]
    public void WhenNegativeNumber_Decima_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenNegativeNumber(-1m, "TEST", "message"));
    }

    #endregion

    #region Throw.ArgumentOutOfRange.WhenPostiveNumber

    [Fact]
    public void WhenPositiveNumbere_Int_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenPositiveNumber(1, "TEST"));
    }

    [Fact]
    public void WhenPositiveNumber_Int_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenPositiveNumber(1, "TEST", "message"));
    }

    [Fact]
    public void WhenPositiveNumber_Double_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenPositiveNumber(1D, "TEST"));
    }

    [Fact]
    public void WhenPositiveNumber_Double_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenPositiveNumber(1D, "TEST", "message"));
    }


    [Fact]
    public void WhenPositiveNumber_Float_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenPositiveNumber(1f, "TEST"));
    }

    [Fact]
    public void WhenPositiveNumber_Float_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenPositiveNumber(1f, "TEST", "message"));
    }

    [Fact]
    public void WhenPositiveNumber_Decimal_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenPositiveNumber(1m, "TEST"));
    }

    [Fact]
    public void WhenPositiveNumber_Decimal_WithMessage_ConditionTrue_Throws()
    {
      Assert.Throws<ArgumentOutOfRangeException>("TEST", () => Throw.ArgumentOutOfRange.WhenPositiveNumber(1m, "TEST", "message"));
    }

    #endregion
  }
}
