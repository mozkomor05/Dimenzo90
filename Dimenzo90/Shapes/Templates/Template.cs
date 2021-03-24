using System.Collections.ObjectModel;

namespace Dimenzo90.Shapes.Templates
{
    abstract class Template<Vector> where Vector : Vectors.Vector
    {
        public static ReadOnlyCollection<Vector> Points { get; }
        public static byte[,] Faces { get; }
        public static Vector[,] Axes { get; }
    }
}
