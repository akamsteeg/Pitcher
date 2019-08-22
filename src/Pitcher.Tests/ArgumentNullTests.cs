using Pitcher.Tests.Fakes;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public void For_ThrowsAndSetsCorrectArgumentName()
    {
      const string argumentName = "TEST";
      try
      {
        Throw.ArgumentNull.For(argumentName);
      }
      catch(ArgumentNullException e)
      {
        Assert.Equal(argumentName, e.ParamName);
      }
    }

    [Fact]
    public void For_WithMessage_Throws()
    {
      Assert.Throws<ArgumentNullException>("TEST", () => Throw.ArgumentNull.For("TEST", "message"));
    }

    [Fact]
    public void For_WithMessage_ThrowsAndSetsCorrectArgumentName()
    {
      const string argumentName = "TEST";
      const string message = "message";

      try
      {
        Throw.ArgumentNull.For(argumentName, message);
      }
      catch (ArgumentNullException e)
      {
        Assert.Equal(argumentName, e.ParamName);
        Assert.Contains(message, e.Message);
      }
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
        Throw.ArgumentNull.WhenNull((object)null, "TEST")
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
        Throw.ArgumentNull.WhenNull((object)null, parameterName)
      );
    }

    [Fact]
    public void WhenNull_WithMessage_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNull((object)null, "TEST", "message")
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
        Throw.ArgumentNull.WhenNull((object)null, parameterName, "message")
      );
    }

    [Fact]
    public void WhenNull_WithMessage_WithNull_SetCorrectMessageOnException()
    {
      const string parameterName = "TEST";
      const string message = "TESTMESSAGE";

      try
      {
        Throw.ArgumentNull.WhenNull((object)null, parameterName, message);
      }
      catch (ArgumentNullException e)
      {
        Assert.Contains(message, e.Message);
      }
    }

    [Fact]
    public void WhenNull_WithString_DoesNotThrow()
    {
      Throw.ArgumentNull.WhenNull("DUMMY", "TEST");
    }

    [Fact]
    public void WhenNull_String_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNull((string)null, "TEST")
      );
    }

    [Fact]
    public void WhenNull_String_WithMessage_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNull((string)null, "TEST", "message")
      );
    }

    [Fact]
    public void WhenNull_String_WithNull_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNull((string)null, parameterName)
      );
    }

    [Fact]
    public void WhenNull_String_WithMessage_WithNull_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNull((string)null, parameterName, "message")
      );
    }

    [Fact]
    public void WhenNull_String_WithMessage_WithNull_SetCorrectMessageOnException()
    {
      const string parameterName = "TEST";
      const string message = "TESTMESSAGE";

      try
      {
        Throw.ArgumentNull.WhenNull((string)null, parameterName, message);
      }
      catch (ArgumentNullException e)
      {
        Assert.Contains(message, e.Message);
      }
    }

    [Fact]
    public void WhenNull_WithNull_OfObjectWithIncorrectOverridenEquals_DoesNotThrow()
    {
      var lyingObject = new ObjWithIncorrectOverridenEquals(); // .Equals(null) returns true

      Throw.ArgumentNull.WhenNull(lyingObject, "TEST");
    }

    [Fact]
    public void WhenNull_WithNull_WithMessage_OfObjectWithIncorrectOverridenEquals_DoesNotThrow()
    {
      const string parameterName = "TEST";
      const string message = "TESTMESSAGE";

      var lyingObject = new ObjWithIncorrectOverridenEquals(); // .Equals(null) returns true

      Throw.ArgumentNull.WhenNull(lyingObject, parameterName, message);
    }

    #region Throw.ArgumentNullOrEmpty.WhenNullOrEmpty(string)

    [Fact]
    public void WhenNullOrEmpty_WithString_DoesNotThrow()
    {
      Throw.ArgumentNull.WhenNullOrEmpty("DUMMY", "TEST");
    }

    [Fact]
    public void WhenNullOrEmpty_String_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrEmpty((string)null, "TEST")
      );
    }

    [Fact]
    public void WhenNullOrEmpty_String_WithMessage_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrEmpty((string)null, "TEST", "message")
      );
    }

    [Fact]
    public void WhenNullOrEmpty_String_WithNull_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNullOrEmpty((string)null, parameterName)
      );
    }

    [Fact]
    public void WhenNullOrEmpty_String_WithMessage_WithNull_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNullOrEmpty((string)null, parameterName, "message")
      );
    }

    [Fact]
    public void WhenNullOrEmpty_String_WithMessage_WithNull_SetCorrectMessageOnException()
    {
      const string parameterName = "TEST";
      const string message = "TESTMESSAGE";

      try
      {
        Throw.ArgumentNull.WhenNullOrEmpty((string)null, parameterName, message);
      }
      catch (ArgumentNullException e)
      {
        Assert.Contains(message, e.Message);
      }
    }

    #endregion

    #region Throw.ArgumentNullOrEmpty.WhenNullOrWhiteSpace(string)

    [Fact]
    public void WhenNullOrWhiteSpace_WithString_DoesNotThrow()
    {
      Throw.ArgumentNull.WhenNullOrWhiteSpace("DUMMY", "TEST");
    }

    [Fact]
    public void WhenNullOrWhiteSpace_String_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrWhiteSpace((string)null, "TEST")
      );
    }

    [Fact]
    public void WhenNullOrWhiteSpace_String_WithEmptyString_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrWhiteSpace(string.Empty, "TEST")
      );
    }

    [Fact]
    public void WhenNullOrWhiteSpace_String_WithMessage_WithNull_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrWhiteSpace((string)null, "TEST", "message")
      );
    }

    [Fact]
    public void WhenNullOrWhiteSpace_String_WithMessage_WithEmptyString_Throws()
    {
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrWhiteSpace(string.Empty, "TEST", "message")
      );
    }

    [Fact]
    public void WhenNullOrWhiteSpace_String_WithNull_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNullOrWhiteSpace((string)null, parameterName)
      );
    }

    [Fact]
    public void WhenNullOrWhiteSpace_String_WithMessage_WithNull_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNullOrWhiteSpace((string)null, parameterName, "message")
      );
    }

    [Fact]
    public void WhenNullOrWhiteSpace_String_WithMessage_WithNull_SetCorrectMessageOnException()
    {
      const string parameterName = "TEST";
      const string message = "TESTMESSAGE";

      try
      {
        Throw.ArgumentNull.WhenNullOrWhiteSpace((string)null, parameterName, message);
      }
      catch (ArgumentNullException e)
      {
        Assert.Contains(message, e.Message);
      }
    }

    #endregion

    #region Throw.ArgumentNullOrEmpty<T>(IEnumerable<T>, string)

    [Fact]
    public void WhenNullOrEmpty_WithNullIEnumerableT_Throws()
    {
      IEnumerable<object> obj = null;
      Assert.Throws<ArgumentNullException>(() => 
        Throw.ArgumentNull.WhenNullOrEmpty(obj, nameof(obj))
      );
    }

    [Fact]
    public void WhenNullOrEmpty_WithEmptyIEnumerableT_Throws()
    {
      IEnumerable<object> obj = Enumerable.Empty<object>();
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrEmpty(obj, nameof(obj))
      );
    }

    [Fact]
    public void WhenNullOrEmpty_WithEmptyIEnumerableT_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      IEnumerable<object> obj = Enumerable.Empty<object>();

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNullOrEmpty(obj, parameterName)
      );
    }

    [Fact]
    public void WhenNullOrEmpty_WithNotEmptyIEnumerableT_DoesNotThrow()
    {
      IEnumerable<object> obj = new List<object>() { new object() };

      Throw.ArgumentNull.WhenNullOrEmpty(obj, nameof(obj));
    }


    #endregion

    #region Throw.ArgumentNull.WhenNullOrEmpty<T>(IEnumerable<T>, string string)

    [Fact]
    public void WhenNullOrEmpty_WithMessage_WithNullIEnumerableT_Throws()
    {
      IEnumerable<object> obj = null;
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrEmpty(obj, nameof(obj), "message")
      );
    }

    [Fact]
    public void WhenNullOrEmpty_WithMessage_WithEmptyIEnumerableT_Throws()
    {
      IEnumerable<object> obj = Enumerable.Empty<object>();
      Assert.Throws<ArgumentNullException>(() =>
        Throw.ArgumentNull.WhenNullOrEmpty(obj, nameof(obj), "message")
      );
    }

    [Fact]
    public void WhenNullOrEmpty_WithMessage_WithEmptyIEnumerableT_SetCorrectParameterNameOnException()
    {
      const string parameterName = "TEST";

      IEnumerable<object> obj = Enumerable.Empty<object>();

      Assert.Throws<ArgumentNullException>(parameterName, () =>
        Throw.ArgumentNull.WhenNullOrEmpty(obj, parameterName, "message")
      );
    }

    [Fact]
    public void WhenNullOrEmpty_WithMessage_WithEmptyIEnumerableT_SetCorrectMessageOnException()
    {
      const string parameterName = "TEST";
      const string message = "TESTMESSAGE";

      IEnumerable<object> obj = Enumerable.Empty<object>();

      try
      {
        Throw.ArgumentNull.WhenNullOrEmpty(obj, parameterName, message);
      }
      catch (ArgumentNullException e)
      {
        Assert.Contains(message, e.Message);
      }
    }

    [Fact]
    public void WhenNullOrEmpty_WithMessage_WithNotEmptyIEnumerableT_DoesNotThrow()
    {
      IEnumerable<object> obj = new List<object>() { new object() };

      Throw.ArgumentNull.WhenNullOrEmpty(obj, nameof(obj), "message");
    }

    #endregion
  }
}
