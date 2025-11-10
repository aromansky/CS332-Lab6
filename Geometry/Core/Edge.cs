namespace Geometry
{
    public class Edge: ICloneable
    {
        public Point3D Start { get; private set; }
        public Point3D End { get; private set; }
        public Vector3 Vector3 { get; private set; }

        public Edge(Point3D start, Point3D end)
        {
            this.Start = start;
            this.End = end;

            this.Vector3 = new Vector3(end.X - start.X, end.Y - start.Y, end.Z - start.Z);
        }

        public Edge(Edge other)
        {
            this.Start = (Point3D)other.Start.Clone();
            this.End = (Point3D)other.End.Clone();
            this.Vector3 = other.Vector3;
        }

        public object Clone() => new Edge(this);
        
    }
}
