﻿using System.Globalization;

namespace Obj2Tiles.Library.Geometry;

public class Vertex3D
{
    
    private static int Index = 0;
    private readonly int index;
    
    public readonly double x;
    public readonly double y;
    public readonly double z;

    public Vertex3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z; 
        index = Index++;
    }

    public override string ToString()
    {
        return  $"[{index}] ({x}; {y}; {z})";
    }

    private static readonly CultureInfo culture = new("en-US");
    
    public string ToObj()
    {
        return string.Format(culture, "v {0} {1} {2}", x, y, z);
    }

    protected bool Equals(Vertex3D other)
    {
        return x.Equals(other.x) && y.Equals(other.y) && y.Equals(other.z);
    }
    
    public override bool Equals(object? obj)
    {
        return !ReferenceEquals(null, obj) &&
               (ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals((Vertex3D)obj));
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y, z);
    }
    
    public static bool operator ==(Vertex3D a, Vertex3D b)
    {
        return Math.Abs(a.x - b.x) < double.Epsilon && Math.Abs(a.y - b.y) < double.Epsilon && Math.Abs(a.z - b.z) < double.Epsilon;
    }
    
    public static bool operator !=(Vertex3D a, Vertex3D b)
    {
        return Math.Abs(a.x - b.x) > double.Epsilon || Math.Abs(a.y - b.y) > double.Epsilon && Math.Abs(a.z - b.z) > double.Epsilon;
    }

    public double Distance(Vertex3D other)
    {
        return Math.Sqrt((x - other.x) * (x - other.x) + (y - other.y) * (y - other.y) + (z - other.z) * (z - other.z));
    }
}