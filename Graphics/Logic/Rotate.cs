using Graphics.Entities;
using Graphics.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics.Logic
{
    static class Rotate
    {
        //Дискретный поворот на ... градусов
        public static IPoint[] PerGraduses(IPoint[] matrix, double graduses)
        {
            double radians = graduses * (Math.PI / 180);
            IPoint[] temp = { new Point(Math.Cos(radians), Math.Sin(radians)), new Point(-Math.Sin(radians), Math.Cos(radians)) };  //Матрица, на которую будет домножаться
            return Matrix.Multiply(matrix, temp);
        }

        public static List<IPoint> PerGraduses(List<IPoint> matrix, double graduses)
        {
            double radians = graduses * (Math.PI / 180);
            List<IPoint> temp = new List<IPoint>();
            temp.Add(new Point(Math.Cos(radians), Math.Sin(radians)));
            temp.Add(new Point(-Math.Sin(radians), Math.Cos(radians)));
            //Матрица, на которую будет домножаться
            return Matrix.Multiply(matrix, temp);
        }
    }
}
