using System.Collections.Generic;

namespace Parcel.Models
{
  public class Parcel
  {
    public int Dimensions {get; set;}
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (int dimensions)
    {
      Dimensions = dimensions;
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}