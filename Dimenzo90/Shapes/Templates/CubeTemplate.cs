using Dimenzo90.Vectors;

namespace Dimenzo90.Shapes.Templates
{
    class CubeTemplate : Template<Vector3D>
    {
        private static readonly Vector3D[] points = new Vector3D[] {
            new Vector3D(-1, -1, -1), //A
            new Vector3D(1, -1, -1), //B
            new Vector3D(1, 1, -1), //C
            new Vector3D(-1, 1, -1), //D
            new Vector3D(-1, -1, 1), //E
            new Vector3D(1, -1, 1), //F
            new Vector3D(1, 1, 1), //G
            new Vector3D(-1, 1, 1) //H
        };

        private static readonly byte[,] faces = {
                { 0, 1, 2, 3 }, //ABCD
                { 0, 1, 5, 4 }, //ABFE
                { 1, 2, 6, 5 }, //BCGF
                { 4, 5, 6, 7 }, //EFGH
                { 2, 3, 7, 6 }, //CDHG
                { 3, 0, 4, 7 } //DAEH
        };
        private static readonly Vector3D[,] axes = {
                    { new Vector3D(0, 1, 0), new Vector3D(0, -1, 0) },
                    { new Vector3D(1, 0, 0), new Vector3D(-1, 0, 0) },
                    { new Vector3D(0, 0, 1), new Vector3D(0, 0, -1) }
        };

        public static new Vector3D[] Points => (Vector3D[])points.Clone();
        public static new byte[,] Faces => (byte[,])faces.Clone();
        public static new Vector3D[,] Axes => (Vector3D[,])axes.Clone();
    }
}