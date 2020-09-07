using Graphics.Entities;
using Graphics.Entities.Interfaces;
using System.Collections.Generic;

namespace Graphics.Logic
{
    static class Reflect
    {
        //Отражение относительно оси OX
        static public IPoint[] OX(IPoint[] matrix, double coefficient)
        {
            IPoint[] temp = { new Point(coefficient, 0), new Point(0, -coefficient) };  //Матрица, на которую будет домножаться
            return Matrix.Multiply(matrix, temp);
        }

        static public List<IPoint> OX(List<IPoint> matrix, double coefficient)
        {
            List<IPoint> temp = new List<IPoint>();//Матрица, на которую будет домножаться
            temp.Add(new Point(coefficient, 0));
            temp.Add(new Point(0, -coefficient));
            return Matrix.Multiply(matrix, temp);
        }

        static public List<IPoint> OX(List<IPoint> matrix, double coefficient, double m, double n)
        {
            List<IPoint> temp = new List<IPoint>();//Матрица, на которую будет домножаться
            temp.Add(new Point(coefficient, 0));
            temp.Add(new Point(0, -coefficient));
            temp.Add(new Point(m, n));
            return Matrix.Multiply3D(matrix, temp);
        }

        //Отражение относительно оси OY
        static public IPoint[] OY(IPoint[] matrix, double coefficient)
        {
            IPoint[] temp = { new Point(-coefficient, 0), new Point(0, coefficient) };  //Матрица, на которую будет домножаться
            return Matrix.Multiply(matrix, temp);
        }

        static public List<IPoint> OY(List<IPoint> matrix, double coefficient)
        {
            List<IPoint> temp = new List<IPoint>();//Матрица, на которую будет домножаться
            temp.Add(new Point(-coefficient, 0));
            temp.Add(new Point(0, coefficient));
            return Matrix.Multiply(matrix, temp);
        }

        static public List<IPoint> OY(List<IPoint> matrix, double coefficient, double m, double n)
        {
            List<IPoint> temp = new List<IPoint>();//Матрица, на которую будет домножаться
            temp.Add(new Point(-coefficient, 0));
            temp.Add(new Point(0, coefficient));
            temp.Add(new Point(m, n));
            return Matrix.Multiply3D(matrix, temp);
        }

        //Определение четверти, в которой находится точка
        static public byte PointFourth(IPoint point)
        {
            if (point.X > 0)
            {
                if (point.Y > 0)
                {
                    return 1; //1 четверть
                }
                else //if (point.Y < 0)
                {
                    return 4; //4 четверть
                }
            }
            else //if (point.X < 0)
            {
                if (point.Y > 0)
                {
                    return 2; //2 четверть
                }
                else //if (point.Y < 0)
                {
                    return 3; //3 четверть
                }
            }
        }

        //Определение четверти, в которой находится фигура
        public static byte FigureFourth(IPoint[] matrix)
        {
            byte firstPoinstFourth = PointFourth(matrix[0]);
            foreach (IPoint point in matrix)
            {
                if (PointFourth(point) != firstPoinstFourth)
                {
                    return 0; //Если фигура находится в нескольких четвертях
                }
            }
            return firstPoinstFourth;
        }

        public static byte FigureFourth(List<IPoint> matrix)
        {
            byte firstPoinstFourth = PointFourth(matrix[0]);
            foreach (IPoint point in matrix)
            {
                if (PointFourth(point) != firstPoinstFourth)
                {
                    return 0; //Если фигура находится в нескольких четвертях
                }
            }
            return firstPoinstFourth;
        }

        static public IPoint[] XY(IPoint[] matrix, double coefficient)
        {
            if (FigureFourth(matrix) == 1 || FigureFourth(matrix) == 3) //1 и 3 четверть отражаются относительно XY
            {
                IPoint[] temp = { new Point(-coefficient, 0),
                                  new Point(0, -coefficient) };  //Матрица, на которую будет домножаться
                return Matrix.Multiply(matrix, temp);
            }
            else if (FigureFourth(matrix) == 2 || FigureFourth(matrix) == 4) //2 и 4 четверть отражаются относительно -XY
            {
                IPoint[] temp = { new Point(0, coefficient),
                                  new Point(coefficient, 0) };  //Матрица, на которую будет домножаться          
                return Matrix.Multiply(matrix, temp);
            }
            else //Если фигура находится в нескольких четвертях
            {
                return null;
            }
        }

        static public List<IPoint> XY(List<IPoint> matrix, double coefficient)
        {
            //1 и 3 четверть отражаются относительно -XY
            //2 и 4 четверть отражаются относительно XY
            if (FigureFourth(matrix) == 1 || FigureFourth(matrix) == 3)
            {
                List<IPoint> temp = new List<IPoint>();//Матрица, на которую будет домножаться
                temp.Add(new Point(0, -coefficient));
                temp.Add(new Point(-coefficient, 0));
                return Matrix.Multiply(matrix, temp);
            }
            else if (FigureFourth(matrix) == 2 || FigureFourth(matrix) == 4)
            {
                List<IPoint> temp = new List<IPoint>();//Матрица, на которую будет домножаться
                temp.Add(new Point(0, coefficient));
                temp.Add(new Point(coefficient, 0));
                return Matrix.Multiply(matrix, temp);
            }
            else //Если фигура находится в нескольких четвертях
            {
                return null;
            }
        }

        static public List<IPoint> XY(List<IPoint> matrix, double coefficient, double m, double n)
        {
            //1 и 3 четверть отражаются относительно -XY
            //2 и 4 четверть отражаются относительно XY
            if (FigureFourth(matrix) == 1 || FigureFourth(matrix) == 3)
            {
                List<IPoint> temp = new List<IPoint>();//Матрица, на которую будет домножаться
                temp.Add(new Point(0, -coefficient));
                temp.Add(new Point(-coefficient, 0));
                temp.Add(new Point(m, n));
                return Matrix.Multiply3D(matrix, temp);
            }
            else if (FigureFourth(matrix) == 2 || FigureFourth(matrix) == 4)
            {
                List<IPoint> temp = new List<IPoint>();//Матрица, на которую будет домножаться
                temp.Add(new Point(0, coefficient));
                temp.Add(new Point(coefficient, 0));
                temp.Add(new Point(m, n));
                return Matrix.Multiply3D(matrix, temp);
            }
            else //Если фигура находится в нескольких четвертях
            {
                return null;
            }
        }
    }
}

