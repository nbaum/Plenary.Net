using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using Minimod.PrettyPrint;

namespace ASIF
{
  
  public class Reader
  {

    readonly Stream stream;
    readonly BinaryReader reader;

    public Reader (string filename)
    {
      stream = File.Open (filename, FileMode.Open);
      reader = new BinaryReader (stream);
      reader.ReadUInt32 ();
      reader.ReadUInt32 ();
      reader.ReadUInt32 ();
    }

    internal void ReadArray<T> (T[] a, Func<T> f)
    {
      for (long i = 0; i < a.GetLongLength (0); ++i)
        a [i] = f ();
    }

    internal void ReadArray<T> (T[,] a, Func<T> f)
    {
      for (long i = 0; i < a.GetLongLength (0); ++i)
        for (long j = 0; j < a.GetLongLength (1); ++j)
          a [i, j] = f ();
    }

    internal void ReadArray<T> (T[,,] a, Func<T> f)
    {
      for (long i = 0; i < a.GetLongLength (0); ++i)
        for (long j = 0; j < a.GetLongLength (1); ++j)
          for (long k = 0; k < a.GetLongLength (2); ++k)
            a [i, j, k] = f ();
    }

    internal Array ReadArray<T> (Func<T> f)
    {
      var dims = reader.ReadByte ();
      Array a;
      switch (dims) {
      case 1:
        a = Array.CreateInstance (typeof(T), reader.ReadUInt32 ());
        break;
      case 2:
        a = Array.CreateInstance (typeof(T), reader.ReadUInt32(), reader.ReadUInt32());
        break;
      case 3:
        a = Array.CreateInstance (typeof(T), reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
        break;
      case 0:
        throw new InvalidDataException ("Arrays can't be dimensionless");
      default:
        throw new NotImplementedException ("Arrays with more than 3 dimension not implemented");
      }
      ReadArray ((dynamic) a, f);
      return a;
    }

    internal Array ReadArray ()
    {
      switch (reader.ReadByte ()) {
      case 0x00:
        throw new InvalidDataException ("Void arrays are not allowed");
      case 0x01:
        throw new NotImplementedException("Rune arrays not implemented");
      case 0x02:
        throw new NotImplementedException("Boolean arrays not implemented");
      case 0x03:
        return ReadArray (reader.ReadSByte);
      case 0x04:
        return ReadArray (reader.ReadInt16);
      case 0x05:
        return ReadArray (reader.ReadInt32);
      case 0x06:
        return ReadArray (reader.ReadInt64);
      case 0x07:
        throw new NotSupportedException ("Int128 not supported");
      case 0x08:
        return ReadArray (reader.ReadByte);
      case 0x09:
        return ReadArray (reader.ReadUInt16);
      case 0x0A:
        return ReadArray (reader.ReadUInt32);
      case 0x0B:
        return ReadArray (reader.ReadUInt64);
      case 0x0C:
        throw new NotSupportedException ("UInt128 not supported");
      case 0x0D:
        throw new NotSupportedException ("Float16 not supported");
      case 0x0E:
        return ReadArray (reader.ReadSingle);
      case 0x0F:
        return ReadArray (reader.ReadDouble);
      case 0x10:
        throw new NotSupportedException ("Float128 not supported");
      case 0x11:
        throw new NotSupportedException ("Float256 not supported");
      case 0x12:
        throw new NotSupportedException ("Tuple not supported");
      case 0x13:
        throw new NotImplementedException("Nested arrays not implemented");
      case 0x14:
        throw new NotImplementedException("Arrays of dicts not implemented");
      case 0x15:
        throw new NotImplementedException("Arrays of strings not implemented");
      case 0xFF:
        return ReadArray (Read);
      default:
        throw new InvalidDataException ("Unsupported data type");
      }
    }

    internal Dictionary<object, object> ReadDict ()
    {
      var d = new Dictionary<object, object> ();
      if (reader.ReadByte () != 0xFF || reader.ReadByte () != 0xFF)
        throw new NotImplementedException ("Typed dictionaries not implemented");
      var len = reader.ReadUInt32 ();
      for (long i = 0; i < len; ++i)
        d [Read ()] = Read ();
      return d;
    }

    public object Read ()
    {
      var code = reader.ReadByte ();
      switch (code) {
      case 0x00:
        return null;
      case 0x01:
        return (char) reader.ReadUInt32 ();
      case 0x02:
        return reader.ReadByte () == 1;
      case 0x03:
        return reader.ReadSByte ();
      case 0x04:
        return reader.ReadInt16 ();
      case 0x05:
        return reader.ReadInt32 ();
      case 0x06:
        return reader.ReadInt64 ();
      case 0x07:
        throw new NotSupportedException ("Int128 not supported");
      case 0x08:
        return reader.ReadByte ();
      case 0x09:
        return reader.ReadUInt16 ();
      case 0x0A:
        return reader.ReadUInt32 ();
      case 0x0B:
        return reader.ReadUInt64 ();
      case 0x0C:
        throw new NotSupportedException ("UInt128 not supported");
      case 0x0D:
        throw new NotSupportedException ("Float16 not supported");
      case 0x0E:
        return reader.ReadSingle ();
      case 0x0F:
        return reader.ReadDouble ();
      case 0x10:
        throw new NotSupportedException ("Float128 not supported");
      case 0x11:
        throw new NotSupportedException ("Float256 not supported");
      case 0x12:
        throw new NotSupportedException ("Tuple not supported");
      case 0x13:
        return ReadArray ();
      case 0x14:
        return ReadDict ();
      case 0x15:
        return Encoding.UTF8.GetString(reader.ReadBytes ((int) reader.ReadUInt32()));
      case 0xFF:
        throw new InvalidDataException ("`Any' in wrong place");
      default:
        throw new InvalidDataException (String.Format("Unsupported type code: {0:X}", code));
      }
    }

  }

}

