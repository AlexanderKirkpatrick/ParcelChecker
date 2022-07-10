using System.Collections.Generic;

namespace ParcelCheck.Models
{
  public class Parcel
  {
    private int _width;
    private int _height;
    private int _length;
    private int _weight;
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (int width, int height, int length, int weight)
    {
      _width = width;
      _height = height;
      _length = length;
      _weight = weight;
      _instances.Add(this);
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public int Volume()
    {
      return _width * _height * _length;
    }

    public int Weight()
    {
      return _weight;
    }

    public int Cost()
    {
      return (Volume() + Weight()) / 4;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Parcel Find(int searchId)
    {
      return _instances[searchId-1];
    }


  }
}