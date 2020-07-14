using System;
using System.Text;

namespace Task1
{
    public class Vector
    {
        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public static Vector operator +(Vector vector1, Vector vector2) => new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y, vector1.Z + vector2.Z);

        public static Vector operator -(Vector vector1, Vector vector2) => new Vector(vector1.X - vector2.X, vector1.Y - vector2.Y, vector1.Z - vector2.Z);

        public static Vector operator -(Vector vector) => new Vector(vector.X * (-1), vector.Y * (-1), vector.Z * (-1));

        public static int operator *(Vector vector1, Vector vector2) => (vector1.X * vector2.X) + (vector1.Y * vector2.Y) + (vector1.Z * vector2.Z);

        public static Vector operator *(Vector vector, int number) => new Vector(vector.X * number, vector.Y * number, vector.Z * number);

        public static Vector operator /(Vector vector1, Vector vector2) => new Vector(vector1.X - vector2.X, vector1.Y - vector2.Y, vector1.Z - vector2.Z);

        public static Vector operator /(Vector vector, int number)
        {
            if (number == 0)
            {
                throw new ArgumentException("Error, division by zero!", "number");
            }

            return new Vector (vector.X / number, vector.Y / number, vector.Z / number);
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            var vector = (Vector)obj;

            return X == vector.X && Y == vector.Y && Z == vector.Z;
        }

        public override int GetHashCode() => X.GetHashCode() * Y.GetHashCode() * Z.GetHashCode();

        public override string ToString() => $"({ X }; { Y }; { Z })\n";
    }
}
