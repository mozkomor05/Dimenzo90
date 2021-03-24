using System;

namespace Dimenzo90.Vectors
{
    class Vector3D : Vector
    {
        private double[,] RotationMatrixX(double rad) => new double[,] {
            { 1, 0, 0 },
            { 0, Math.Cos(rad), -Math.Sin(rad) },
            { 0, Math.Sin(rad), Math.Cos(rad) }
        };

        private double[,] RotationMatrixY(double rad) => new double[,] {
            { Math.Cos(rad), 0, Math.Sin(rad) },
            { 0, 1, 0 },
            { -Math.Sin(rad), 0, Math.Cos(rad) }
        };

        private double[,] RotationMatrixZ(double rad) => new double[,] {
            { Math.Cos(rad), -Math.Sin(rad), 0 },
            { Math.Sin(rad), Math.Cos(rad), 0  },
            { 0, 0, 1}
        };

        [Component]
        public double Z { get; }

        public Vector3D(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }

        public override Vector Rotate(double radian) => Rotate(radian, 0, 0);

        public virtual Vector3D Rotate(double radianX, double radianY = 0, double radianZ = 0)
        {
            if (radianX == 0 && radianX == radianY && radianY == radianZ)
                return this;

            return ToVector<Vector3D>(MultiplyMatrix(radianZ != 0 ? RotationMatrixZ(radianZ) : null, 
                radianY != 0 ? RotationMatrixY(radianY) : null, radianX != 0 ? RotationMatrixX(radianX) : null, ToMatrix()));
        }

        public override Vector Project(int size, int projectionType = 0)
        {
            switch (projectionType)
            {
                case 0:
                    double factor = 4 * size / (4 + Z);
                    return new Vector(X * factor, Y * factor);
                default:
                    return new Vector(X, Y).Project(size);
            }
        }
    }
}