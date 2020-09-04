using Graphics.Entities.Interfaces;

namespace Graphics.Entities
{
    class Point : IPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
