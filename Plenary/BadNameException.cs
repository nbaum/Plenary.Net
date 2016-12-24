using System;
using System.Threading.Tasks;

namespace Plenary
{
  public class BadNameException<T> : Exception
  {
    public int Name;
    public BadNameException (int name)
    {
      Name = name;
    }
  }
}

