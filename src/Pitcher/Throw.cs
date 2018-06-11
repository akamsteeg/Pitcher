using System;

namespace Pitcher
{
  /// <summary>
  /// Represents a throw helper for exceptions
  /// </summary>
  public static class Throw
  {
    /// <summary>
    /// Represents a throw helper for <see cref="ArgumentNullException"/>
    /// </summary>
    public static class ArgumentNull
    {
      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter name
      /// </summary>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      public static void For(string parameterName) =>
        throw new ArgumentNullException(parameterName);

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter name
      /// </summary>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      /// <param name="message">
      /// The message to include in the <see cref="ArgumentNullException"/>
      /// </param>
      public static void For(string parameterName, string message) =>
        throw new ArgumentNullException(parameterName, message);

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter name when the specified condition is true
      /// </summary>
      /// <param name="condition">
      /// The condition to determine whether to throw the <see cref="ArgumentNullException"/> or not
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      public static void When(bool condition, string parameterName)
      {
        if (condition)
        {
          throw new ArgumentNullException(parameterName);
        }
      }

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter name when the specified condition is true
      /// </summary>
      /// <param name="condition">
      /// The condition to determine whether to throw the <see
      /// cref="ArgumentNullException"/> or not
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      /// <param name="message">
      /// The message to include in the <see cref="ArgumentNullException"/>
      /// </param>
      public static void When(bool condition, string parameterName, string message)
      {
        if (condition)
        {
          throw new ArgumentNullException(parameterName, message);
        }
      }

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter name when the specified <see cref="Func{TResult}"/> returns true
      /// </summary>
      /// <param name="condition">
      /// The <see cref="Func{TResult}"/> to determine whether to throw the <see cref="ArgumentNullException"/> or not
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      public static void When(Func<bool> condition, string parameterName)
      {
        _ = condition ?? throw new ArgumentNullException(nameof(condition));

        var mustThrow = condition.Invoke();

        if (mustThrow)
        {
          throw new ArgumentNullException(parameterName);
        }
      }

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter name when the specified <see cref="Func{TResult}"/> returns true
      /// </summary>
      /// <param name="condition">
      /// The <see cref="Func{TResult}"/> to determine whether to throw the <see
      /// cref="ArgumentNullException"/> or not
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      /// <param name="message">
      /// The message to include in the <see cref="ArgumentNullException"/>
      /// </param>
      public static void When(Func<bool> condition, string parameterName, string message)
      {
        _ = condition ?? throw new ArgumentNullException(nameof(condition));

        var mustThrow = condition.Invoke();

        if (mustThrow)
        {
          throw new ArgumentNullException(parameterName, message);
        }
      }

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter when the specified <see cref="object"/> is null
      /// </summary>
      /// <param name="obj">
      /// The <see cref="object"/> to check for null
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      public static void WhenNull(object obj, string parameterName)
      {
        if (obj == null)
        {
          throw new ArgumentNullException(parameterName);
        }
      }

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter when the specified <see cref="object"/> is null
      /// </summary>
      /// <param name="obj">
      /// The <see cref="object"/> to check for null
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      /// <param name="message">
      /// The message to include in the <see cref="ArgumentNullException"/>
      /// </param>
      public static void WhenNull(object obj, string parameterName, string message)
      {
        if (obj == null)
        {
          throw new ArgumentNullException(parameterName, message);
        }
      }
    }

  }
}
