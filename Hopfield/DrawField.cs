using MathNet.Numerics.LinearAlgebra;

namespace Hopfield
{
    // Класс области для рисования
    public class DrawField
    { 
        public const int Left = 104;
        public const int Top = 327;
        public const int Size = 180;
        public const int CellSize = 15;
        public const int CellsCount = Size / CellSize;
        private readonly int[,] _matrix;

        public DrawField()
        {
            _matrix = new int[CellsCount, CellsCount];
            FillMatrixWith(-1);
        }

        // Получение матрицы из нарисованного
        public Matrix GetMatrix()
        {
            Matrix copy = new Matrix(CellsCount, CellsCount);
            for (int r = 0; r < CellsCount; ++r)
            for (int c = 0; c < CellsCount; ++c)
                copy[r, c] = _matrix[r, c];
            return copy;
        }

        private void FillMatrixWith(int value)
        {
            for (int r = 0; r < CellsCount; ++r)
            for (int c = 0; c < CellsCount; ++c)
                _matrix[r, c] = value;
        }

        public void Clear()
        {
            FillMatrixWith(-1);
        }

        public int this[int row, int column]
        {
            get => _matrix[row, column];
            set => _matrix[row, column] = value;
        }
    }
}