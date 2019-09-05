using System;

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
}
