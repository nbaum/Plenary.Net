using System;

namespace Plenary.Math {

  public static class Extensions {

    public static double Deg2Rad(this double val)
    {
      return (System.Math.PI / 180) * val;
    }

    public static double Deg2Rad(this float val)
    {
      return (System.Math.PI / 180) * val;
    }

    public static double Deg2Rad(this int val)
    {
      return (System.Math.PI / 180) * val;
    }

  }

}

