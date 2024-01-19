class Program
{
    public static void Main(string[] args)
    {
        Point2D point2D = new Point2D(10, 23);
        Console.WriteLine(point2D);

        Point3D point3D = new Point3D(1, 2, 3);
        point3D.SetXYZ(3, 4, 5);
        Console.WriteLine(point3D);
    }
}