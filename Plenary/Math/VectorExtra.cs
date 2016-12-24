using System;

namespace Plenary.Math {
  
  public partial struct Vec4f {

    public Vec4f (Vec3f v, float w) : this(v.X, v.Y, v.Z, w) {
    }

  }

}

