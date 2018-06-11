using System;

namespace $rootnamespace$.Helpers
{
  /// <summary>
  /// Represents a throw helper for exceptions
  /// </summary>
  internal static class Throw
  {
    /// <summary>
    /// Throw the specified <see cref="Exception"/>
    /// </summary>
    /// <param name="exceptionToThrow">
    /// The <see cref="Exception"/> to throw
    /// </param>
    public static void This(Exception exceptionToThrow)
    {
      _ = exceptionToThrow ?? throw new ArgumentNullException(nameof(exceptionToThrow));

      throw exceptionToThrow;
    }

    /// <summary>
    /// Throw the specified <see cref="Exception"/> when the specified condition
    /// is true
    /// </summary>
    /// <param name="condition">
    /// The condition to determine whether to throw the <see cref="Exception"/>
    /// or not
    /// </param>
    /// <param name="exceptionToThrow">
    /// The <see cref="Exception"/> to throw
    /// </param>
    public static void When(bool condition, Exception exceptionToThrow)
    {
      _ = exceptionToThrow ?? throw new ArgumentNullException(nameof(exceptionToThrow));

      if (condition)
      {
        throw exceptionToThrow;
      }
    }

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
        Throw.This(new ArgumentNullException(parameterName));

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
        Throw.This(new ArgumentNullException(parameterName, message));

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
      public static void When(bool condition, string parameterName) =>
        Throw.When(condition, new ArgumentNullException(parameterName));

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
      public static void When(bool condition, string parameterName, string message) =>
        Throw.When(condition, new ArgumentNullException(parameterName, message));

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
      public static void WhenNull(object obj, string parameterName) =>
        Throw.When(obj == null, new ArgumentNullException(parameterName));

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
      public static void WhenNull(object obj, string parameterName, string message) =>
        Throw.When(obj == null, new ArgumentNullException(parameterName, message));
    }

    /// <summary>
    /// Represents a throw helper for see <see cref="ArgumentOutOfRangeException"/>
    /// </summary>
    public static class ArgumentOutOfRange
    {
      /// <summary>
      /// Throw an <see cref="ArgumentOutOfRange"/> for the specified
      /// parameter name
      /// </summary>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentOutOfRange"/> for
      /// </param>
      public static void For(string parameterName) =>
        Throw.This(new ArgumentOutOfRangeException(parameterName));

      /// <summary>
      /// Throw an <see cref="ArgumentOutOfRange"/> for the specified
      /// parameter name
      /// </summary>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentOutOfRange"/> for
      /// </param>
      /// <param name="message">
      /// The message to include in the <see cref="ArgumentOutOfRange"/>
      /// </param>
      public static void For(string parameterName, string message) =>
        Throw.This(new ArgumentOutOfRangeException(parameterName, message));

      /// <summary>
      /// Throw an <see cref="ArgumentOutOfRangeException"/> for the specified
      /// parameter name when the specified condition is true
      /// </summary>
      /// <param name="condition">
      /// The condition to determine whether to throw the <see cref="ArgumentOutOfRangeException"/> or not
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentOutOfRangeException"/> for
      /// </param>
      public static void When(bool condition, string parameterName) =>
        Throw.When(condition, new ArgumentOutOfRangeException(parameterName));

      /// <summary>
      /// Throw an <see cref="ArgumentOutOfRangeException"/> for the specified
      /// parameter name when the specified condition is true
      /// </summary>
      /// <param name="condition">
      /// The condition to determine whether to throw the <see
      /// cref="ArgumentOutOfRangeException"/> or not
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentOutOfRangeException"/> for
      /// </param>
      /// <param name="message">
      /// The message to include in the <see cref="ArgumentOutOfRangeException"/>
      /// </param>
      public static void When(bool condition, string parameterName, string message) =>
        Throw.When(condition, new ArgumentOutOfRangeException(parameterName, message));
    }
  }
}
