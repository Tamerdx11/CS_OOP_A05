namespace CS_OOP_A05;

internal class Program
{
    static void Main(string[] args)
    {
        /* -------------------------- First Project Test -------------------------- */

        //Point3D p = new Point3D(10);
        //Console.WriteLine(p);
        // ----- 3: Read 2 Points P1, P2 From User Input -----
        // P1
        //Console.Write("Enter Point P1 X: ");
        //int.TryParse(Console.ReadLine()!, out int x1);
        //Console.Write("Enter Point P1 Y: ");
        //int.TryParse(Console.ReadLine()!, out int y1);
        //Console.Write("Enter Point P1 Z: ");
        //int.TryParse(Console.ReadLine()!, out int z1);
        //Point3D p1 = new Point3D(x1, y1, z1);
        //// P2
        //Console.Write("Enter Point P2 X: ");
        //int.TryParse(Console.ReadLine()!, out int x2);
        //Console.Write("Enter Point P2 Y: ");
        //int.TryParse(Console.ReadLine()!, out int y2);
        //Console.Write("Enter Point P2 Z: ");
        //int.TryParse(Console.ReadLine()!, out int z2);
        //Point3D p2 = new Point3D(x2, y2, z2);

        //Console.WriteLine($"P1: {p1}");
        //Console.WriteLine($"P2: {p2}");

        // ----- 4: P1 == P2 : '==' Compare the two points reference -----
        //if (p1 == p2)
        //    Console.WriteLine("P1 reference == P2 reference");

        // ----- 5: Array of Points -----
        //Point3D[] points = 
        //    {
        //        new(4, 5, 6),
        //        new(10, 11, 12),
        //        new(13, 14, 15),
        //        new(7, 8, 9),
        //        new(1, 2, 3)
        //    };
        //Array.Sort(points);
        //foreach (var point in points)
        //{
        //    Console.WriteLine(point);
        //}

        // ----- 6: Clone -----
        //Point3D p3 = new(1, 2, 3);
        //Point3D p4 = (Point3D)p3.Clone();
        //Console.WriteLine($"P4: {p4}");


        /* -------------------------- Second Project Test -------------------------- */

        //double x = 10, y = 5;
        //Console.WriteLine($"X = {x}, Y = {y}");

        //Console.WriteLine($"Add: {Maths.Add(x, y)}");  
        //Console.WriteLine($"Subtract: {Maths.Subtract(x, y)}"); 
        //Console.WriteLine($"Multiply: {Maths.Multiply(x, y)}");
        //Console.WriteLine($"Divide: {Maths.Divide(x, y)}");



        Console.ReadKey();
    }
}

#region First Project
class Point3D : IComparable<Point3D>, ICloneable
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point3D(int x)
    {
        X = x;
    }
    public Point3D(int x, int y) : this(x)
    {
        Y = y;
    }
    public Point3D(int x, int y, int z) : this(x, y)
    {
        Z = z;
    }

    public override string ToString() => $"Point Coordinates: ({X}, {Y}, {Z})";

    public int CompareTo(Point3D? other)
    {
        if (X == other?.X) return Y.CompareTo(other.Y);
        else return X.CompareTo(other?.X);
    }

    public object Clone() => new Point3D(X, Y, Z);

}

#endregion


#region Second Project
public static class Maths
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0) return 0;
        return a / b;
    }
}
#endregion
