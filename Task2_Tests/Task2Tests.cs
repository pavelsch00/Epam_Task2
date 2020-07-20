using Polynomials;
using System;
using Xunit;

namespace Task2_Tests
{
    public class Task2Tests
    {
        [Fact]
        public void PolynomialAditionPolynomial_PolynomialAndPolynomial_Equal()
        {
            // arrange
            double polynomial_x1 = 1;
            double polynomial_x2 = 1;
            double polynomial_x3 = 1;
            double polynomial_x4 = 1;

            Polynomial polynomial1 = new Polynomial(polynomial_x1, polynomial_x2, polynomial_x3, polynomial_x4);

            double polynomial2_x1 = 2;
            double polynomial2_x2 = 3;
            double polynomial2_x3 = 4;
            double polynomial2_x4 = 5;

            Polynomial polynomial2 = new Polynomial(polynomial2_x1, polynomial2_x2, polynomial2_x3, polynomial2_x4);

            double polynomial3_x1 = 3;
            double polynomial3_x2 = 4;
            double polynomial3_x3 = 5;
            double polynomial3_x4 = 6;

            Polynomial polynomial3Expected = new Polynomial(polynomial3_x1, polynomial3_x2, polynomial3_x3, polynomial3_x4);

            // act
            Polynomial actual = polynomial1 + polynomial2;

            // assert;
            Assert.Equal(polynomial3Expected, actual);
        }

        [Fact]
        public void PolynomialMultiplyPolynomial_PolynomialAndPolynomial_Equal()
        {
            // arrange
            double polynomial_x1 = 2;
            double polynomial_x2 = 2;

            Polynomial polynomial1 = new Polynomial(polynomial_x1, polynomial_x2);

            double polynomial2_x1 = 2;
            double polynomial2_x2 = 3;
            double polynomial2_x3 = 4;

            Polynomial polynomial2 = new Polynomial(polynomial2_x1, polynomial2_x2, polynomial2_x3);

            double polynomial3_x1 = 4;
            double polynomial3_x2 = 10;
            double polynomial3_x3 = 14;
            double polynomial3_x4 = 8;

            Polynomial polynomial3Expected = new Polynomial(polynomial3_x1, polynomial3_x2, polynomial3_x3, polynomial3_x4);

            // act
            Polynomial actual = polynomial1 * polynomial2;

            // assert;
            Assert.Equal(polynomial3Expected, actual);
        }

        [Fact]
        public void PolynomialDecrementPolynomial_PozitivPolynomial1AndPozitivPolynomial2_Equal()
        {
            // arrange
            double polynomial_x1 = 2;
            double polynomial_x2 = 3;
            double polynomial_x3 = 4;
            double polynomial_x4 = 15;

            Polynomial polynomial1 = new Polynomial(polynomial_x1, polynomial_x2, polynomial_x3, polynomial_x4);

            double polynomial2_x1 = 1;
            double polynomial2_x2 = 2;
            double polynomial2_x3 = 3;
            double polynomial2_x4 = 4;

            Polynomial polynomial2 = new Polynomial(polynomial2_x1, polynomial2_x2, polynomial2_x3, polynomial2_x4);

            double polynomial3_x1 = 1;
            double polynomial3_x2 = 1;
            double polynomial3_x3 = 1;
            double polynomial3_x4 = 11;

            Polynomial polynomial3Expected = new Polynomial(polynomial3_x1, polynomial3_x2, polynomial3_x3, polynomial3_x4);

            // act
            Polynomial actual = polynomial1 - polynomial2;

            // assert;
            Assert.Equal(polynomial3Expected, actual);
        }

        [Fact]
        public void DivisionPolynomialNumber_PozitivVectorAndPozitivNumber_Equal()
        {
            // arrange
            double polynomial_x1 = 2;
            double polynomial_x2 = 4;
            double polynomial_x3 = 8;
            double polynomial_x4 = 16;

            Polynomial polynomial1 = new Polynomial(polynomial_x1, polynomial_x2, polynomial_x3, polynomial_x4);

            double number = 2;

            double polynomial3_x1 = 1;
            double polynomial3_x2 = 2;
            double polynomial3_x3 = 4;
            double polynomial3_x4 = 8;

            Polynomial polynomial3Expected = new Polynomial(polynomial3_x1, polynomial3_x2, polynomial3_x3, polynomial3_x4);

            // act
            Polynomial actual = polynomial1 / number;

            // assert;
            Assert.Equal(polynomial3Expected, actual);
        }

        [Fact]
        public void PolynomialMultiplyNumber_PozitivVectorAndPozitivNumber_Equal()
        {
            // arrange
            double polynomial_x1 = 2;
            double polynomial_x2 = 4;
            double polynomial_x3 = 8;
            double polynomial_x4 = 16;

            Polynomial polynomial1 = new Polynomial(polynomial_x1, polynomial_x2, polynomial_x3, polynomial_x4);

            double number = 2;

            double polynomial3_x1 = 4;
            double polynomial3_x2 = 8;
            double polynomial3_x3 = 16;
            double polynomial3_x4 = 32;

            Polynomial polynomial3Expected = new Polynomial(polynomial3_x1, polynomial3_x2, polynomial3_x3, polynomial3_x4);

            // act
            Polynomial actual = polynomial1 * number;

            // assert;
            Assert.Equal(polynomial3Expected, actual);
        }

        [Fact]
        public void Equal_PozitivPolynomial1AndPozitivPolynomial2_Equal()
        {
            // arrange
            double polynomial_x1 = 2;
            double polynomial_x2 = 3;
            double polynomial_x3 = 4;
            double polynomial_x4 = 15;

            Polynomial polynomial1 = new Polynomial(polynomial_x1, polynomial_x2, polynomial_x3, polynomial_x4);

            double polynomial2_x1 = 2;
            double polynomial2_x2 = 3;
            double polynomial2_x3 = 4;
            double polynomial2_x4 = 15;

            Polynomial polynomial2 = new Polynomial(polynomial2_x1, polynomial2_x2, polynomial2_x3, polynomial2_x4);

            bool expected = true;
            // act
            bool actual = Polynomial.Equals(polynomial1, polynomial2);

            // assert;
            Assert.Equal(expected, actual);
        }
    }
}
