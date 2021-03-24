using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dimenzo90.Vectors;
using Dimenzo90.Shapes.Templates;

namespace Dimenzo90.Shapes
{
    class Tesseract : Shape<Vector4D, TesseractTemplate>
    {
        public override void Rotate(double yz, double xz) => Rotate(yz, xz, 0, 0, 0, 0);

        public void Rotate(double yz, double xz = 0, double xy = 0, double xw = 0, double yw = 0, double zw = 0)
        {
            for (int i = 0; i < TesseractTemplate.Points.Length; i++)
                Points[i] = TesseractTemplate.Points[i].Rotate(Rad(yz), Rad(xz), Rad(xy), Rad(xw), Rad(yw), Rad(zw));

            for (int i = 0; i < Axes.GetLength(0); i++)
            {
                Axes[i, 0] = TesseractTemplate.Axes[i, 0].Rotate(Rad(yz), Rad(xz), Rad(xy), Rad(xw), Rad(yw), Rad(zw));
                Axes[i, 1] = TesseractTemplate.Axes[i, 1].Rotate(Rad(yz), Rad(xz), Rad(xy), Rad(xw), Rad(yw), Rad(zw));
            }
        }

        private double Rad(double angle) => angle * Math.PI / 180;

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
