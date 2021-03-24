using System;

namespace Dimenzo90.Vectors
{
    class Vector4D : Vector3D
    {
        private double[,] RotationMatrixYZ(double rad) => new double[,] {
            { 1, 0, 0, 0 },
            { 0, Math.Cos(rad), -Math.Sin(rad), 0 },
            { 0, Math.Sin(rad), Math.Cos(rad), 0 },
            { 0, 0, 0, 1 }
        };

        private double[,] RotationMatrixXZ(double rad) => new double[,] {
            { Math.Cos(rad), 0, Math.Sin(rad), 0 },
            { 0, 1, 0, 0 },
            { -Math.Sin(rad), 0, Math.Cos(rad), 0 },
            { 0, 0, 0, 1}
        };

        private double[,] RotationMatrixXY(double rad) => new double[,] {
            { Math.Cos(rad), -Math.Sin(rad), 0, 0 },
            { Math.Sin(rad), Math.Cos(rad), 0, 0  },
            { 0, 0, 1, 0},
            { 0, 0, 0, 1}
        };

        private double[,] RotationMatrixXW(double rad) => new double[,] {
            { Math.Cos(rad), 0, 0, Math.Sin(rad) },
            { 0, 1, 0, 0},
            { 0, 0, 1, 0},
            { -Math.Sin(rad), 0, 0, Math.Cos(rad)  },
        };

        private double[,] RotationMatrixYW(double rad) => new double[,] {
            { 1, 0, 0, 0 },
            { 0, Math.Cos(rad), 0, -Math.Sin(rad) },
            { 0, 0, 1, 0},
            { 0, Math.Sin(rad), 0, Math.Cos(rad)  }
        };

        private double[,] RotationMatrixZW(double rad) => new double[,] {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, Math.Cos(rad), -Math.Sin(rad) },
            { 0, 0, Math.Sin(rad), Math.Cos(rad) }
        };

        [Component]
        public double W { get; }

        public Vector4D(double x, double y, double z, double w) : base(x, y, z)
        {
            W = w;
        }

        public override Vector3D Rotate(double yz, double xz = 0, double xy = 0) => Rotate(yz, xz, xy, 0);

        public Vector4D Rotate(double yz, double xz = 0, double xy = 0, double xw = 0, double yw = 0, double zw = 0)
        {
            if (yz == 0 && xz == xy && xy == xw && xw == yw && yw == zw)
                return this;

            return ToVector<Vector4D>(MultiplyMatrix(yz != 0 ? RotationMatrixYZ(yz) : null, xz != 0 ? RotationMatrixXZ(xz) : null,
                xy != 0 ? RotationMatrixXY(xy) : null, xw != 0 ? RotationMatrixXW(xw) : null, yw != 0 ? RotationMatrixYW(yw) : null,
                zw != 0 ? RotationMatrixZW(zw) : null, ToMatrix()));
        }

        public override Vector Project(int size, int projectionType = 0)
        {

            switch (projectionType)
            {
                case 2:
                    return new Vector(X, Y).Project(size);
                case 1:
                    return new Vector3D(X, Y, Z).Project(size, 0);
                default:
                    double factor = 4 / (4 + W);
                    return new Vector3D(X * factor, Y * factor, Z * factor).Project(size, projectionType);
            }
        }
    }
}
