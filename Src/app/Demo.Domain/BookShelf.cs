using System;
using SharpLite.Domain;

namespace Demo.Domain
{
  public class BookShelf : EntityWithTypedId<Guid>
  {
    public virtual string BookName { get; set; }
  }
}