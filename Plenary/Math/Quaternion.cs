using System;

namespace Plenary.Math
{

  public struct Quaternion
  {

    public double X, Y, Z, W;
  
    Quaternion (double x, double y, double z, double w)
    {
      X = x;
      Y = y;
      Z = z;
      W = w;
    }

  }

}

