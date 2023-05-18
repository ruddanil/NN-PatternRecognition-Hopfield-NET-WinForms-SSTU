using System;
using System.Linq;
using MathNet.Numerics.LinearAlgebra;

namespace Hopfield
{
    // Класс распознаватель
    public static class Recognizer
    {
        // Создание матрицы весов
        public static Matrix GenerateWeightsMatrix(Vector[] samples)
        {
            int samplesCount = samples.Length;
            int vectorLength = samples[0].Length;
            Matrix weights = new Matrix(m: vectorLength, n: vectorLength);
            for (int i = 0; i < weights.RowCount; ++i)
            {
                for (int j = 0; j < weights.ColumnCount; ++j)
                {
                    if (i == j) continue;
                    for (int k = 0; k < samplesCount; ++k)
                    {
                        weights[i, j] += samples[k][i] * samples[k][j];
                    }
                }
            }
            return weights;
        }

        // Асинхронное распознавание
        public static Matrix RecognizeAsynchronously(Matrix weights, Vector input)
        {
            Vector oldOutput = input.Clone();
            Vector newOutput = input.Clone();
            while (true)
            {
                for (int i = 0; i < input.Length; ++i)
                {
                    // биполярное кодирование
                    newOutput[i] = weights.GetRowVector(i).ArrayMultiply(newOutput).Sum() >= 0 ? +1 : -1;
                }
                if (newOutput.SequenceEqual(oldOutput))
                {
                    Matrix recognized = newOutput.ToMatrixByColumns(columnSize: (int)Math.Sqrt(input.Length));
                    return recognized;
                }
                oldOutput = newOutput.Clone();
            }
        }
    }
}
