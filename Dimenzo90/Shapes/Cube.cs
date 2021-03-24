using System;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Linq;

using Dimenzo90.Vectors;
using Dimenzo90.Shapes.Templates;

namespace Dimenzo90.Shapes
{
    class Cube : Shape<Vector3D, CubeTemplate>
    {
        public override void Rotate(double angleX, double angleY) => Rotate(angleX, angleY, 0);

        public virtual void Rotate(double angleX, double angleY, double angleZ)
        {
            double radX = angleX * Math.PI / 180;
            double radY = angleY * Math.PI / 180;
            double radZ = angleZ * Math.PI / 180;

            for (int i = 0; i < CubeTemplate.Points.Length; i++)
                Points[i] = CubeTemplate.Points[i].Rotate(radX, radY, radZ);

            for (int i = 0; i < Axes.GetLength(0); i++)
            {
                Axes[i, 0] = CubeTemplate.Axes[i, 0].Rotate(radX, radY, radZ);
                Axes[i, 1] = CubeTemplate.Axes[i, 1].Rotate(radX, radY, radZ);
            }
        }

        public virtual void SortFaces()
        {
            double[] avgZ = new double[Faces.GetLength(0)];

            for (int i = 0; i < Faces.GetLength(0); i++)
            {
                for (int j = 0; j < Faces.GetLength(1); j++)
                    avgZ[i] += Points[Faces[i, j]].Z;

                avgZ[i] /= Faces.GetLength(1);
            }

            FacesOrder = Enumerable.Range(0, Faces.GetLength(0)).ToArray();

            Array.Sort(avgZ, FacesOrder);
            Array.Reverse(FacesOrder);
        }
    }
}
