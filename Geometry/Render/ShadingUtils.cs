using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class ShadingUtils
    {
        /// <summary>
        /// Вычисление цвета точки на основе модели Ламберта
        /// </summary>
        /// <param name="light">Источник цвета</param>
        /// <param name="point">Координаты точки</param>
        /// <param name="objectColor">Цвет материала объекта</param>
        public static Vector3 CalculateLambertColor(LightSource light, Vertex point, Vector3 objectColor)
        {
            Vector3 L = light - point;
            float cos = Math.Max(Vector3.Dot(point.Normal.Normalized(), L.Normalized()), 0);
            
            return new Vector3
            {
                X = objectColor.X * light.Color.X * cos,
                Y = objectColor.Y * light.Color.Y * cos,
                Z = objectColor.Z * light.Color.Z * cos
            };
        }
    }
}
