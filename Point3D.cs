public class Point3D : Point2D
{
    private float z = 0.0f;

    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    public Point3D() : base() { }

    public float GetZ()
    {
        return z;
    }

    public void SetZ(float z)
    {
        this.z = z;
    }

    public void SetXYZ(float x, float y, float z)
    {
        this.SetXY(x, y);
        this.z = z;
    }

    public float[] GetXYZ()
    {
        return new float[] 
        { 
            this.GetX(),
            this.GetY(),
            this.GetZ()
        };
    }

    public override string ToString()
    {
        return $"({this.GetX()},{this.GetY()},{this.GetZ()})";
    }
}
