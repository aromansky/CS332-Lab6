using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS332_Lab6.Geometry.Transform
{
    internal class Transform
    {
        /// <summary>
        /// Создаёт матрицу сдвига
        /// </summary>
        /// <param name="tx">Сдвиг по оси X</param>
        /// <param name="ty">Сдвиг по оси Y</param>
        /// <param name="tz">Сдвиг по оси Z</param>
        /// <returns>Матрица сдвига 4x4</returns>
        private static Matrix CreateTranslationMatrix(float tx, float ty, float tz)
        {
            return new Matrix(new float[,]
            {
                {1, 0, 0, 0 },
                {0, 1, 0, 0 },
                {0, 0, 1, 0 },
                {tx, ty, tz, 1 }
            });
        }

        /// <summary>
        /// Создаёт матрицу поворота вокруг оси X
        /// </summary>
        /// <param name="angle">Угол поворота в радианах</param>
        /// <returns>Матрица поворота вокруг оси X 4x4</returns>
        private static Matrix CreateRotationAboutXMatrix(float angle)
        {
            float sin = (float)Math.Sin(angle);
            float cos = (float)Math.Cos(angle);

            return new Matrix(new float[,]
            {
                {1, 0, 0, 0 },
                {0, cos, sin, 0 },
                {0, -sin, cos, 0 },
                {0, 0, 0, 1 }
            });
        }

        /// <summary>
        /// Создаёт матрицу поворота вокруг оси Y
        /// </summary>
        /// <param name="angle">Угол поворота в радианах</param>
        /// <returns>Матрица поворота вокруг оси Y 4x4</returns>
        private static Matrix CreateRotationAboutYMatrix(float angle)
        {
            float sin = (float)Math.Sin(angle);
            float cos = (float)Math.Cos(angle);

            return new Matrix(new float[,]
            {
                {cos, 0, -sin, 0 },
                {0, 1, 0, 0 },
                {sin, 0, cos, 0 },
                {0, 0, 0, 1 }
            });
        }

        /// <summary>
        /// Создаёт матрицу поворота вокруг оси Z
        /// </summary>
        /// <param name="angle">Угол поворота в радианах</param>
        /// <returns>Матрица поворота вокруг оси Z 4x4</returns>
        private static Matrix CreateRotationAboutZMatrix(float angle)
        {
            float sin = (float)Math.Sin(angle);
            float cos = (float)Math.Cos(angle);

            return new Matrix(new float[,]
            {
                {cos, sin, 0, 0 },
                {-sin, cos, 0, 0 },
                {0, 0, 1, 0 },
                {0, 0, 0, 1 }
            });
        }

        /// <summary>
        /// Создаёт матрицу масштабирования
        /// </summary>
        /// <param name="scaleX">Масштаб по оси X (от 0 до 1)</param>
        /// <param name="scaleY">Масштаб по оси Y(от 0 до 1)</param>
        /// <param name="scaleZ">Масштаб по оси Z(от 0 до 1)</param>
        /// <returns>Матрица масштабирования 4x4</returns>
        private static Matrix CreateScaleMatrix(float scaleX = 1, float scaleY = 1, float scaleZ = 1)
        {
            return new Matrix(new float[,]
            {
                {scaleX, 0, 0, 0 },
                {0, scaleY, 0, 0 },
                {0, 0, scaleZ, 0 },
                {0, 0, 0, 1 }
            });
        }
    }
}