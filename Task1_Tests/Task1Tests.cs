using Task1;
using Xunit;

namespace Task1_Tests
{
    public class Task1Tests
    {
        [Fact]
        public void VectorAditionVector_PozitivVector1AndPozitivVector2_Equal()
        {
            // arrange
            float vector1_x = 1;
            float vector1_y = 2;
            float vector1_z = 3;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float vector2_x = 1;
            float vector2_y = 2;
            float vector2_z = 3;
            Vector vector2 = new Vector(vector2_x, vector2_y, vector2_z);

            float vector3_x = 2;
            float vector3_y = 4;
            float vector3_z = 6;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = vector1 + vector2;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorAditionVector_NegativVector1AndPozitivVector2_Equal()
        {
            // arrange
            float vector1_x = -1;
            float vector1_y = -2;
            float vector1_z = -3;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float vector2_x = 1;
            float vector2_y = 2;
            float vector2_z = 3;
            Vector vector2 = new Vector(vector2_x, vector2_y, vector2_z);

            float vector3_x = 0;
            float vector3_y = 0;
            float vector3_z = 0;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = vector1 + vector2;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorAditionVector_NegativVector1AndNegativVector2_Equal()
        {
            // arrange
            float vector1_x = -1;
            float vector1_y = -2;
            float vector1_z = -3;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float vector2_x = -1;
            float vector2_y = -2;
            float vector2_z = -3;
            Vector vector2 = new Vector(vector2_x, vector2_y, vector2_z);

            float vector3_x = -2;
            float vector3_y = -4;
            float vector3_z = -6;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = vector1 + vector2;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorAditionNumber_NegativVectorAndNegativNumber_Equal()
        {
            // arrange
            float vector_x = -1;
            float vector_y = -2;
            float vector_z = -3;
            Vector vector1 = new Vector(vector_x, vector_y, vector_z);

            int x = -1;

            float vector2_x = -2;
            float vector2_y = -3;
            float vector2_z = -4;
            Vector expectedVector3 = new Vector(vector2_x, vector2_y, vector2_z);

            // act
            Vector actual = vector1 + x;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorAditionFloatNumber_PozitivVectorAndPozitivNumber_Equal()
        {
            // arrange
            float vector_x = 1;
            float vector_y = 2;
            float vector_z = 3;
            Vector vector1 = new Vector(vector_x, vector_y, vector_z);

            float x = 1;

            float vector2_x = 2;
            float vector2_y = 3;
            float vector2_z = 4;
            Vector expectedVector3 = new Vector(vector2_x, vector2_y, vector2_z);

            // act
            Vector actual = vector1 + x;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorAditionIntNumber_PozitivVectorAndPozitivNumber_Equal()
        {
            // arrange
            float vector_x = 1;
            float vector_y = 2;
            float vector_z = 3;
            Vector vector1 = new Vector(vector_x, vector_y, vector_z);

            int x = 1;

            float vector2_x = 2;
            float vector2_y = 3;
            float vector2_z = 4;
            Vector expectedVector3 = new Vector(vector2_x, vector2_y, vector2_z);

            // act
            Vector actual = vector1 + x;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorDecrementVector_PozitivVector1AndPozitivVector2_Equal()
        {
            // arrange
            float vector1_x = 1;
            float vector1_y = 1;
            float vector1_z = 1;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float vector2_x = 2;
            float vector2_y = 2;
            float vector2_z = 2;
            Vector vector2 = new Vector(vector2_x, vector2_y, vector2_z);

            float vector3_x = -1;
            float vector3_y = -1;
            float vector3_z = -1;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = vector1 - vector2;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorDecrement_PozitivVector1AndPozitivVector2_Equal()
        {
            // arrange
            float vector_x = 1;
            float vector_y = 1;
            float vector_z = 1;
            Vector vector1 = new Vector(vector_x, vector_y, vector_z);


            float vector2_x = -1;
            float vector2_y = -1;
            float vector2_z = -1;
            Vector expectedVector3 = new Vector(vector2_x, vector2_y, vector2_z);

            // act
            Vector actual =- vector1;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorDecrementVector_PozitivVector1AndNegativVector2_Equal()
        {
            // arrange
            float vector1_x = 1;
            float vector1_y = 1;
            float vector1_z = 1;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float vector2_x = -2;
            float vector2_y = -2;
            float vector2_z = -2;
            Vector vector2 = new Vector(vector2_x, vector2_y, vector2_z);

            float vector3_x = 3;
            float vector3_y = 3;
            float vector3_z = 3;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = vector1 - vector2;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorDecrementFloatNumber_PozitivVectorAndNegativNumber_Equal()
        {
            // arrange
            float vector_x = 1;
            float vector_y = 1;
            float vector_z = 1;
            Vector vector = new Vector(vector_x, vector_y, vector_z);

            float number = -3;

            float vector3_x = 4;
            float vector3_y = 4;
            float vector3_z = 4;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = vector - number;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorDecrementIntNumber_PozitivVectorAndNegativNumber_Equal()
        {
            // arrange
            float vector_x = 1;
            float vector_y = 1;
            float vector_z = 1;
            Vector vector = new Vector(vector_x, vector_y, vector_z);

            int number = -3;

            float vector3_x = 4;
            float vector3_y = 4;
            float vector3_z = 4;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = vector - number;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void VectorMultiplicationVector1_PozitivVectorAndNegativNumber_Equal()
        {
            // arrange
            float vector1_x = 2;
            float vector1_y = 3;
            float vector1_z = 4;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float vector2_x = 2;
            float vector2_y = 2;
            float vector2_z = 2;
            Vector vector2 = new Vector(vector2_x, vector2_y, vector2_z);

            float expected = 18;

            // act
            float actual = vector1 * vector2;

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void VectorMultiplicationNumber_PozitivVectorAndNegativNumber_Equal()
        {
            // arrange
            float vector1_x = 2;
            float vector1_y = 3;
            float vector1_z = 4;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float number = 2;

            float vector2_x = 4;
            float vector2_y = 6;
            float vector2_z = 8;
            Vector expectedVector2 = new Vector(vector2_x, vector2_y, vector2_z);

            // act
            Vector actual = vector1 * number;

            // assert;
            Assert.Equal(expectedVector2, actual);
        }

        [Fact]
        public void VectorMultiplicationVector_PozitivVectorAndNegativNumber_Equal()
        {
            // arrange
            float vector1_x = 2;
            float vector1_y = 3;
            float vector1_z = 4;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float vector2_x = 5;
            float vector2_y = 6;
            float vector2_z = 7;
            Vector vector2 = new Vector(vector2_x, vector2_y, vector2_z);

            float vector3_x = -3;
            float vector3_y = 6;
            float vector3_z = -3;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = Vector.VectorMultiplication(vector1, vector2);

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void DivisionVectorsNumber_PozitivVectorAndPozitivNumber_Equal()
        {
            // arrange
            float vector_x = 4;
            float vector_y = 6;
            float vector_z = 8;
            Vector vector = new Vector(vector_x, vector_y, vector_z);

            int number = 2;

            float vector3_x = 2;
            float vector3_y = 3;
            float vector3_z = 4;
            Vector expectedVector3 = new Vector(vector3_x, vector3_y, vector3_z);

            // act
            Vector actual = vector / number;

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void GetLength_Vector_Equal()
        {
            // arrange
            float vector_x = 2;
            float vector_y = 3;
            float vector_z = 4;
            Vector vector = new Vector(vector_x, vector_y, vector_z);

            double expectedVector3 = 5.385164807134504;

            // act
            double actual = Vector.GetLength(vector);

            // assert;
            Assert.Equal(expectedVector3, actual);
        }

        [Fact]
        public void Equa_Vector1andVector1_Equal()
        {
            // arrange
            // arrange
            float vector1_x = 2;
            float vector1_y = 2;
            float vector1_z = 2;
            Vector vector1 = new Vector(vector1_x, vector1_y, vector1_z);

            float vector2_x = 2;
            float vector2_y = 2;
            float vector2_z = 2;
            Vector vector2 = new Vector(vector2_x, vector2_y, vector2_z);

            bool expecte = true;

            // act
            bool actual = Equals(vector1, vector2);

            // assert;
            Assert.Equal(expecte, actual);
        }
    }
}
