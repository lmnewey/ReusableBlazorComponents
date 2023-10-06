namespace ReusableBlazorComponents
{
  [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
  sealed class ShouldRenderAttribute : Attribute
  {
      public bool Render { get; }

      public ShouldRenderAttribute(bool render)
      {
          Render = render;
      }
  }

  public class Person
  {
      public int Id { get; set; }
      [ShouldRender(true)]
      public string FirstName { get; set; }
      [ShouldRender(true)]
      public string LastName { get; set; }
      public int Age { get; set; }
  }
  public class mbroker
  {
      public int Id { get; set; }
      public string BrokerName { get; set; }
      public string url { get; set; }
      [ShouldRender(false)]
      public int port { get; set; }
  }

}