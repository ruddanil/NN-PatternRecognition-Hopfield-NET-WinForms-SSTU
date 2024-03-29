﻿using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;
using System.Drawing;

namespace Hopfield
{
    public static class MatrixExtensions
    {
        // Into a vector by columns
        public static Vector ToVectorByColumns(this Matrix m)
        {
            List<double> vector = new List<double>();
            for (int i = 0; i < m.ColumnCount; ++i)
            {
                vector.AddRange(m.GetColumnVector(i).ToArray());
            }
            return new Vector(vector.ToArray());
        }

        // Into the picture
        public static Bitmap ToBitmap(this Matrix m)
        {
            Bitmap pic = new Bitmap(width: m.ColumnCount, height: m.RowCount);
            for (int r = 0; r < m.RowCount; ++r)
            {
                for (int c = 0; c < m.ColumnCount; ++c)
                {
                    Color color = m[r, c] > 0 ? Color.Black : Color.White;
                    pic.SetPixel(c, r, color);
                }
            }
            return pic;
        }
    }
}
