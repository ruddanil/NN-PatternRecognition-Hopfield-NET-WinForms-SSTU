﻿using MathNet.Numerics.LinearAlgebra;
using System.Drawing;

namespace Hopfield
{
    public static class BitmapParser
    {
        public static Matrix Noise(Bitmap pic, int ammount)
        {
            Matrix picMatrix = pic.ToMatrix();
            return Noise(picMatrix, ammount);
        }

        public static Matrix Noise(Matrix pic, int ammount)
        {
            Matrix noised = pic.Clone();
            for (int r = 0; r < pic.RowCount; ++r)
            {
                for (int c = 0; c < pic.ColumnCount; ++c)
                {
                    if (RandomGenerator.Match(ammount))
                    {
                        noised[r, c] = noised[r, c] > 0 ? -1 : +1;
                    }
                }
            }
            return noised;
        }

        public static Bitmap Scale(Matrix matrix, int times)
        {
            Bitmap pic = new Bitmap(matrix.RowCount * times, matrix.ColumnCount * times);
            for (int r = 0; r < pic.Height; ++r)
            {
                for (int c = 0; c < pic.Width; ++c)
                {
                    Color color = matrix[r / times, c / times] > 0 ? Color.Black : Color.White;
                    pic.SetPixel(c, r, color);
                }
            }
            return pic;
        }

        public static Bitmap Scale(Bitmap pic, int times)
        {
            return Scale(pic.ToMatrix(), times);
        }
    }
}
