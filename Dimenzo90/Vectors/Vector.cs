using System;
using System.Linq;

namespace Dimenzo90.Vectors
{
    class Vector
    {
        public class Component : Attribute { }

        [Component]
        public double X { get; }
        [Component]
        public double Y { get; }

        private double[,] RotationMatrix(double rad) => new double[,] {
            { Math.Cos(rad), -Math.Sin(rad) },
            { Math.Sin(rad), Math.Cos(rad) }
        };

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        protected double[,] MultiplyMatrix(params double[][,] matrix)
        {
            matrix = matrix.Where(m => m != null).ToArray();

            if (matrix.Length < 2) throw new Exception();

            do
            {
                double[,] a = matrix[0], b = matrix[1];

                if (a.GetLength(1) != b.GetLength(0)) throw new Exception();

                double[,] c = new double[a.GetLength(0), b.GetLength(1)];

                for (int i = 0; i < c.GetLength(0); i++)
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.GetLength(1); k++)
                            c[i, j] = c[i, j] + a[i, k] * b[k, j];
                    }

                matrix = matrix.Skip(1).ToArray();
                matrix[0] = c;
            } while (matrix.Length > 1);


            return matrix[0];
        }

        protected double[,] ToMatrix()
        {
            var props = GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(Component))).OrderBy(prop => prop.Name).ToArray();
            double[,] matrix = new double[props.Length, 1];

            for (int i = 0; i < props.Length; i++)
                matrix[i, 0] = (double)props[i].GetValue(this);

            return matrix;
        }

        protected static T ToVector<T>(double[,] matrix) where T : Vector
        {
            if (matrix.GetLength(1) != 1) return null;
            return (T)Activator.CreateInstance(typeof(T), matrix.Cast<object>().ToArray());
        }

        public virtual Vector Rotate(double radian)
        {
            if (radian == 0) return new Vector(X, Y);
            return ToVector<Vector>(MultiplyMatrix(RotationMatrix(radian), ToMatrix()));
        }

        public virtual Vector Project(int size, int projectionType = 0)
        {
            return new Vector(X * size, Y * size);
        }
    }
}