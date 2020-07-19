﻿namespace Polynomial
{
    public class Polynomial
    {
        #region Properties
        public readonly double[] Coefficients;

        public readonly int Degree;
        #endregion

        #region Constructor
        public Polynomial(params double[] coefficients)
        {
            Coefficients = coefficients;
            Degree = Coefficients.Length;
        }
        #endregion

        #region Methods
        public static Polynomial operator +(Polynomial polynomial1, Polynomial polynomial2)
        {
            int maxDegree;
            if (polynomial1.Degree >= polynomial2.Degree)
                maxDegree = polynomial1.Degree;
            else
                maxDegree = polynomial2.Degree;

            var newPolynomialCoefficients = new double[maxDegree];

            for (int i = 0; i < maxDegree; i++)
            {
                double coefficient1 = 0;
                double coefficient2 = 0;

                if (i < polynomial1.Degree)
                    coefficient1 = polynomial1.Coefficients[i];

                if (i < polynomial2.Degree)
                    coefficient2 = polynomial2.Coefficients[i];

                newPolynomialCoefficients[i] = coefficient1 + coefficient2;
            }

            return new Polynomial(newPolynomialCoefficients);
        }

        public static Polynomial operator -(Polynomial polynomial1, Polynomial polynomial2)
        {
            int maxDegree;
            if (polynomial1.Degree >= polynomial2.Degree)
                maxDegree = polynomial1.Degree;
            else
                maxDegree = polynomial2.Degree;

            var newPolynomialCoefficients = new double[maxDegree];

            for (int i = 0; i < maxDegree; i++)
            {
                double coefficient1 = 0;
                double coefficient2 = 0;

                if (i < polynomial1.Degree)
                    coefficient1 = polynomial1.Coefficients[i];

                if (i < polynomial2.Degree)
                    coefficient2 = polynomial2.Coefficients[i];

                newPolynomialCoefficients[i] = coefficient1 - coefficient2;
            }

            return new Polynomial(newPolynomialCoefficients);
        }


        public static Polynomial operator /(Polynomial polynomial, double number)
        {
            var newPolynomialCoefficients = polynomial.Coefficients;

            for (int i = 0; i < newPolynomialCoefficients.Length; i++)
                newPolynomialCoefficients[i] /= number;

            return new Polynomial(newPolynomialCoefficients);
        }

        public static Polynomial operator *(Polynomial polynomial, double number)
        {
            var newPolynomialCoefficients = polynomial.Coefficients;

            for (int i = 0; i < newPolynomialCoefficients.Length; i++)
                newPolynomialCoefficients[i] *= number;

            return new Polynomial(newPolynomialCoefficients);
        }

        public static Polynomial operator *(Polynomial polynomial1, Polynomial polynomial2)
        {
            var newPolynomialCoefficients = new double[polynomial1.Degree + polynomial2.Degree - 1];

            for (int i = 0; i < polynomial1.Degree; i++)
                for (int j = 0; j < polynomial2.Degree; j++)
                    newPolynomialCoefficients[i + j] += polynomial1.Coefficients[i] * polynomial2.Coefficients[j];

            return new Polynomial(newPolynomialCoefficients);
        }

        /// <summary>
        ///  Method Equals.
        ///  Lets you compare two objects.
        ///  Input parameters: object.
        ///  Returned value: bool.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (!(obj is Polynomial))
                return false;
            
            var polynomial = (Polynomial)obj;

            if (Degree != polynomial.Degree)
                return false;

            return Coefficients == polynomial.Coefficients;
        }

        /// <summary>
        ///  Method GetHashCode.
        ///  Method gets the hash code of the object.
        ///  Input parameters: null.
        ///  Returned value: int.
        /// </summary>
        public override int GetHashCode() => Coefficients.GetHashCode() + Degree.GetHashCode();

        /// <summary>
        ///  Method ToString.
        ///  Allows you to get class status information as a string.
        ///  Input parameters: null.
        ///  Returned value: string.
        /// </summary>
        public override string ToString() => $"Coefficients: {Coefficients}, Degree: {Degree}";
        #endregion
    }
}
