namespace Geometry
{
    public struct Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        /// <summary>
        /// Создаёт ненормированный вектор
        /// </summary>
        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Vector3 Normalized()
        {
            float length = (float)Math.Sqrt(X * X + Y * Y + Z * Z);
            if (length == 0)
                throw new InvalidOperationException("Невозможно нормализовать нулевой вектор");
            return new Vector3(X / length, Y / length, Z / length);
        }

        public bool IsZero()
        {
            return X == 0 && Y == 0 && Z == 0;
        }

        public static Vector3 VectorProduct(Vector3 v1, Vector3 v2)
        {
            return new Vector3(
                v1.Y * v2.Z - v1.Z * v2.Y,
                v1.Z * v2.X - v1.X * v2.Z,
                v1.X * v2.Y - v1.Y * v2.X
            );
        }

    }
}
