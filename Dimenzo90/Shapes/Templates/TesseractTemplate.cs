using Dimenzo90.Vectors;

namespace Dimenzo90.Shapes.Templates
{
    class TesseractTemplate : Template<Vector4D>
    {
        private static readonly Vector4D[] points = new Vector4D[] {
            new Vector4D(-1, -1, -1, -1), //A
            new Vector4D(1, -1, -1, -1), //B
            new Vector4D(1, -1, 1, -1), //C
            new Vector4D(-1, -1, 1, -1), //D
            new Vector4D(-1, 1, -1, -1), //E
            new Vector4D(1, 1, -1, -1), //F
            new Vector4D(1, 1, 1, -1), //G
            new Vector4D(-1, 1, 1, -1), //H
            new Vector4D(-1, -1, -1, 1), //A
            new Vector4D(1, -1, -1, 1), //B
            new Vector4D(1, -1, 1, 1), //C
            new Vector4D(-1, -1, 1, 1), //D
            new Vector4D(-1, 1, -1, 1), //E
            new Vector4D(1, 1, -1, 1), //F
            new Vector4D(1, 1, 1, 1), //G
            new Vector4D(-1, 1, 1, 1) //H
        };

        private static readonly byte[,] faces = {
            {0, 1, 5, 4}, //ABFE
            {2, 3, 7, 6}, //CDHG
            {1, 2, 6, 5}, //BCGF
            {3, 0, 4, 7}, //DAEH
            {3, 2, 1, 0}, //DCBA
            {5, 4, 7, 6}, //FEHG
            {8, 9, 13, 12}, //IJNM
            {10, 11, 15, 14}, //KLPO
            {9, 10, 14, 13}, //JKON
            {11, 8, 12, 15}, //LIMP
            {11, 10, 9, 8}, //LKJI
            {15, 12, 13, 14}, //PMNO
            {0, 1, 9, 8}, //ABJI
            {3, 2, 10, 11}, //DCKL
            {1, 2, 10, 9}, //BCKJ
            {3, 0, 8, 11}, //DAIL
            {5, 4, 12, 13}, //FEMN
            {6, 7, 15, 14}, //GHPO
            {5, 6, 14, 13}, //FGON
            {4, 7, 15, 12}, //EHPM
            {4, 0, 8, 12}, //EAIM
            {1, 5, 13, 9}, //BFNJ
            {2, 6, 14, 10}, //CGOK
            {7, 3, 11, 15} //HDLP
        };
        private static readonly Vector4D[,] axes = {
                    { new Vector4D(0, 1, 0, 0), new Vector4D(0, -1, 0, 0) },
                    { new Vector4D(1, 0, 0, 0), new Vector4D(-1, 0, 0, 0) },
                    { new Vector4D(0, 0, 1, 0), new Vector4D(0, 0, -1, 0) },
                    { new Vector4D(0, 0, 0, 1), new Vector4D(1, 0, 0, -1) }
        };

        public static new Vector4D[] Points => (Vector4D[])points.Clone();
        public static new byte[,] Faces => (byte[,])faces.Clone();
        public static new Vector4D[,] Axes => (Vector4D[,])axes.Clone();
    }
}
