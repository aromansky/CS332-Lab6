namespace Geometry
{
    public class Point3D: ICloneable
    {

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3D(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point3D(Point3D other)
        {
            (this.X, this.Y, this.Z) = other.GetCoords();
        }

        public (float x, float y, float z) GetCoords()
        {
            return (X, Y, Z);
        }

        public object Clone() => new Point3D(this);

        public static Point3D operator *(Point3D point, float scalar)
        {
            (float x, float y, float z) = point.GetCoords();
            point = new Point3D(x * scalar, y * scalar, z * scalar);
            return point;
        }
}
}
