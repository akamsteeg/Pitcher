using System;
using System.Collections.Generic;
using System.Linq;

namespace Pitcher
{
  /// <summary>
  /// Represents a throw helper for exceptions
  /// </summary>
  /// <typeparam name="TException">
  /// The type of <see cref="Exception"/> to throw
  /// </typeparam>
  public static class Throw<TException>
    where TException : Exception, new()
  {
    /// <summary>
    /// Throw the <see cref="Exception"/> of the specified type
    /// </summary>
    public static void Now()
    {
      var ex = Create();

      throw ex;
    }

    /// <summary>
    /// Throw the <see cref="Exception"/> of the specified type when the
    /// specified condition is true
    /// </summary>
    /// <param name="condition">
    /// The condition to determine whether to throw the <see cref="Exception"/>
    /// or not
    /// </param>
    public static void When(bool condition)
    {
      if (condition)
      {
        Now();
      }
    }

    /// <summary>
    /// Create a new <see cref="Exception"/> of the specified type
    /// </summary>
    /// <returns>
    /// A new <see cref="Exception"/> of the specified type
    /// </returns>
    private static TException Create()
    {
      var result = Activator.CreateInstance<TException>();
      return result;
    }
  }

  /// <summary>
  /// Represents a throw helper for exceptions
  /// </summary>
  public static class Throw
  {
    /// <summary>
    /// Throw the specified <see cref="Exception"/>
    /// </summary>
    /// <param name="exceptionToThrow">
    /// The <see cref="Exception"/> to throw
    /// </param>
    public static void This(Exception exceptionToThrow)
    {
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
      if (condition)
      {
        throw exceptionToThrow;
      }
    }

    /// <summary>
    /// Throw the specified <see cref="Exception"/> when the specified condition
    /// is true
    /// </summary>
    /// <param name="condition">
    /// The condition to determine whether to throw the <see cref="Exception"/>
    /// or not
    /// </param>
    /// <param name="exceptionFactory">
    /// The <see cref="Func{TResult}"/> that creates the <see cref="Exception"/>
    /// to throw
    /// </param>
    public static void When(bool condition, Func<Exception> exceptionFactory)
    {
      if (condition)
      {
        throw exceptionFactory.Invoke();
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
      public static void When(bool condition, string parameterName)
      {
        if (condition)
        {
          Throw.This(new ArgumentNullException(parameterName));
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
          Throw.This(new ArgumentNullException(parameterName, message));
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
      public static void WhenNull(object obj, string parameterName) =>
        Throw.ArgumentNull.When(obj == null, parameterName);

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
        Throw.ArgumentNull.When(obj == null, parameterName, message);

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
      [Obsolete("Use WhenNullOrEmpty(string, string)")]
      public static void WhenNull(string obj, string parameterName) =>
        Throw.ArgumentNull.When(string.IsNullOrEmpty(obj), parameterName);

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
      [Obsolete("Use WhenNullOrEmpty(string, string, string)")]
      public static void WhenNull(string obj, string parameterName, string message) =>
        Throw.ArgumentNull.When(string.IsNullOrEmpty(obj), parameterName, message);

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter when the specified <see cref="string"/> is null or empty
      /// </summary>
      /// <param name="obj">
      /// The <see cref="string"/> to check for null or empty string
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      public static void WhenNullOrEmpty(string obj, string parameterName) =>
        Throw.ArgumentNull.When(string.IsNullOrEmpty(obj), parameterName);

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter when the specified <see cref="string"/> is null or empty
      /// </summary>
      /// <param name="obj">
      /// The <see cref="string"/> to check for null or empty string
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      /// <param name="message">
      /// The message to include in the <see cref="ArgumentNullException"/>
      /// </param>
      public static void WhenNullOrEmpty(string obj, string parameterName, string message) =>
        Throw.ArgumentNull.When(string.IsNullOrEmpty(obj), parameterName, message);

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter when the specified <see cref="IEnumerable{T}"/> is null 
      /// or empty
      /// </summary>
      /// <param name="obj">
      /// The <see cref="IEnumerable{T}"/> to check for null or emptiness
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      public static void WhenNullOrEmpty<T>(IEnumerable<T> obj, string parameterName) =>
        Throw.ArgumentNull.When(obj == null || !obj.Any(), parameterName);

      /// <summary>
      /// Throw an <see cref="ArgumentNullException"/> for the specified
      /// parameter when the specified <see cref="IEnumerable{T}"/> is null 
      /// or empty
      /// </summary>
      /// <param name="obj">
      /// The <see cref="IEnumerable{T}"/> to check for null or emptiness
      /// </param>
      /// <param name="parameterName">
      /// The name of the parameter to throw the <see
      /// cref="ArgumentNullException"/> for
      /// </param>
      /// <param name="message">
      /// The message to include in the <see cref="ArgumentNullException"/>
      /// </param>
      public static void WhenNullOrEmpty<T>(IEnumerable<T> obj, string parameterName, string message) =>
        Throw.ArgumentNull.When(obj == null || !obj.Any(), parameterName, message);
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
      public static void When(bool condition, string parameterName)
      {
        if (condition)
        {
          Throw.This(new ArgumentOutOfRangeException(parameterName));
        }
      }

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
      public static void When(bool condition, string parameterName, string message)
      {
        if (condition)
        {
          Throw.This(new ArgumentOutOfRangeException(parameterName, message));
        }
      }
    }
  }
}
