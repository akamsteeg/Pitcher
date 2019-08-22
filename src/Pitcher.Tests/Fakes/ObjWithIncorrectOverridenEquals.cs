namespace Pitcher.Tests.Fakes
{
  internal sealed class ObjWithIncorrectOverridenEquals
  {
    public override bool Equals(object obj)
    {
      var result = false;

      if (obj == null)
      {
        result = true; // INCORRECT
      }
      else
      {
        result = base.Equals(obj);
      }

      return result;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
