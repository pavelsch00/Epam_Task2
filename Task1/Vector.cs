using System;

namespace Task1
{
    /// <summary>
    ///  Class Vector.
    ///   The class is designed to work with three-dimensional vectors.
    /// </summary>
    public class Vector
    {
        #region Constructor
        public Vector(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion

        #region Properties
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }
        #endregion

        #region Methods
        /// <summary>
        ///  Method +.
        ///  Addition of two vectors
        ///  Input parameters: Vector, Vector.
        ///  Returned value: Vector.
        /// </summary>
        public static Vector operator +(Vector vector1, Vector vector2) => new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y, vector1.Z + vector2.Z);

        /// <summary>
        ///  Method +.
        ///  Addition of a vector and a number.
        ///  Input parameters: Vector, int.
        ///  Returned value: Vector.
        /// </summary>
        public static Vector operator +(Vector vector, int number) => new Vector(vector.X + number, vector.Y + number, vector.Z + number);

        /// <summary>
        ///  Method -.
        ///  Subtraction of two vectors.
        ///  Input parameters: Vector, Vector.
        ///  Returned value: Vector.
        /// </summary>
        public static Vector operator -(Vector vector1, Vector vector2) => new Vector(vector1.X - vector2.X, vector1.Y - vector2.Y, vector1.Z - vector2.Z);

        /// <summary>
        ///  Method -.
        ///  Subtract a number from a vector.
        ///  Input parameters: Vector, int.
        ///  Returned value: Vector.
        /// </summary>
        public static Vector operator -(Vector vector, int number) => new Vector(vector.X - number, vector.Y - number, vector.Z - number);

        /// <summary>
        ///  Method -.
        ///  Finding the inverse vector.
        ///  Input parameters: Vector.
        ///  Returned value: Vector.
        /// </summary>
        public static Vector operator -(Vector vector) => new Vector(vector.X * (-1), vector.Y * (-1), vector.Z * (-1));

        /// <summary>
        ///  Method *.
        ///  Scalar vector multiplication.
        ///  Input parameters: Vector, Vector.
        ///  Returned value: int.
        /// </summary>
        public static int operator *(Vector vector1, Vector vector2) => (vector1.X * vector2.X) + (vector1.Y * vector2.Y) + (vector1.Z * vector2.Z);

        /// <summary>
        ///  Method *.
        ///  Multiplication of a vector by a number
        ///  Input parameters: Vector, int.
        ///  Returned value: Vector.
        /// </summary>
        public static Vector operator *(Vector vector, int number) => new Vector(vector.X * number, vector.Y * number, vector.Z * number);

        /// <summary>
        ///  Method VectorMultiplication.
        ///  Vector Multiplication of Two Vectors.
        ///  Input parameters: Vector, Vector.
        ///  Returned value: Vector.
        /// </summary>
        public static Vector VectorMultiplication(Vector vector1, Vector vector2) => new Vector((vector1.Y * vector2.Z) - (vector1.Z * vector2.Y), (vector1.Z * vector2.X) - (vector1.X * vector2.Z), (vector1.X * vector2.Y) - (vector1.Y * vector1.X));

        /// <summary>
        ///  Method /.
        ///  Divide vector by number.
        ///  Input parameters: Vector, int.
        ///  Returned value: Vector.
        /// </summary>
        public static Vector operator /(Vector vector, int number)
        {
            if (number == 0)
                throw new ArgumentException("Error, division by zero!", "number");

            return new Vector(vector.X / number, vector.Y / number, vector.Z / number);
        }

        /// <summary>
        ///  Method /.
        ///  Divide vector by number.
        ///  Input parameters: Vector.
        ///  Returned value: double.
        /// </summary>
        public static double GetLength(Vector vector) => Math.Sqrt( (vector.X * vector.X) + (vector.Y * vector.Y) + (vector.Z * vector.Z));

        /// <summary>
        ///  Method Equals.
        ///  Lets you compare two objects.
        ///  Input parameters: object.
        ///  Returned value: bool.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            var vector = (Vector)obj;

            return X == vector.X && Y == vector.Y && Z == vector.Z;
        }

        /// <summary>
        ///  Method GetHashCode.
        ///  Method gets the hash code of the object.
        ///  Input parameters: null.
        ///  Returned value: int.
        /// </summary>
        public override int GetHashCode() => X.GetHashCode() * Y.GetHashCode() * Z.GetHashCode();

        /// <summary>
        ///  Method ToString.
        ///  Allows you to get class status information as a string.
        ///  Input parameters: null.
        ///  Returned value: string.
        /// </summary>
        public override string ToString() => $"({ X }; { Y }; { Z })\n";
        #endregion
    }
}
