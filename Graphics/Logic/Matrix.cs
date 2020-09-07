using Graphics.Entities;
using Graphics.Entities.Interfaces;
using System.Collections.Generic;

namespace Graphics.Logic
{
    static class Matrix
    {
        //Перемножение матриц
        static public IPoint[] Multiply(IPoint[] matrix, IPoint[] temp)
        {
            Point[] result = new Point[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new Point(matrix[i].X * temp[0].X + matrix[i].Y * temp[1].X,
                                      matrix[i].X * temp[0].Y + matrix[i].Y * temp[1].Y);
            }
            return result;
        }

        static public List<IPoint> Multiply(List<IPoint> matrix, List<IPoint> temp)
        {
            List<IPoint> result = new List<IPoint>();
            for (int i = 0; i < matrix.Count; i++)
            {
                result.Add(new Point(matrix[i].X * temp[0].X + matrix[i].Y * temp[1].X,
                                     matrix[i].X * temp[0].Y + matrix[i].Y * temp[1].Y));
            }
            return result;
        }

        static public List<IPoint> Multiply3D(List<IPoint> matrix, List<IPoint> temp)
        {
            List<IPoint> result = new List<IPoint>();
            for (int i = 0; i < matrix.Count; i++)
            {
                result.Add(new Point(matrix[i].X * temp[0].X + matrix[i].Y * temp[1].X + temp[2].X,
                                     matrix[i].X * temp[0].Y + matrix[i].Y * temp[1].Y + temp[2].Y));
            }
            return result;
        }
    }
}
