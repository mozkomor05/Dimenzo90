using System.Drawing;
using System.Linq;

namespace Dimenzo90.Shapes
{
    abstract class Shape<Vector, Template>
        where Vector : Vectors.Vector
        where Template : Templates.Template<Vector>
    {
        public Vector[] Points { get; protected set; } = (Vector[])typeof(Template).GetProperty("Points").GetValue(null, null);
        public Vector[,] Axes { get; } = (Vector[,])typeof(Template).GetProperty("Axes").GetValue(null, null);
        public byte[,] Faces { get; } = (byte[,])typeof(Template).GetProperty("Faces").GetValue(null, null);

        public int[] FacesOrder { get; protected set; }
        private Color[] FaceColors { get; set; }

        public abstract void Rotate(double angleX, double angleY);

        public void Rotate(double angleX) => Rotate(angleX, 0);
        public void SetFaceBrush(int faceindex, int r, int g, int b) => FaceColors[faceindex] = Color.FromArgb(r, g, b);
        public Brush GetFaceBrush(int faceindex, int alpha) => new SolidBrush(Color.FromArgb(alpha, FaceColors[faceindex % FaceColors.Length]));

        protected Shape()
        {
            FacesOrder = Enumerable.Range(0, Faces.GetLength(0)).ToArray();

            FaceColors = new Color[Faces.GetLength(0) / 2];
            for (int i = 0; i < FaceColors.Length; i++)
                FaceColors[i] = Color.FromArgb(0, 0, 255);
        }
    }
}
